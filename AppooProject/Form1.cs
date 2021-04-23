using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AppooProjectClasses;

namespace AppooProjectInterface
{
    public partial class MyMailClient : Form
    {
        private readonly IMAPClient _imapClient;
        private readonly List<MyMail> _myMails;
        private Int32 _count;
        private String _currentFolder;
        private String _email;
        private String _password;
        private RadioButton[] _folders;
        private String fisierPath = null;

        public MyMailClient()
        {
            InitializeComponent();
            _imapClient = new IMAPClient();
            _myMails = new List<MyMail>();
            mailsTable.CellClick += mailsTable_CellContentClick;
            _loader.DoWork += loader_DoWork;
            _loader.ProgressChanged += loader_ProgressChanged;
            _loader.RunWorkerCompleted += loader_RunWorkerCompleted;
            _loader.WorkerSupportsCancellation = true;
            _sender.DoWork += sender_DoWork;
            _sender.RunWorkerCompleted += sender_RunWorkerCompleted;
            _sender.WorkerSupportsCancellation = true;
            mailsTable.MouseHover += (sender, evnt) => { ((DataGridView)sender).Focus(); };
            Closing += (sender, evnt) =>
            {
                if (_loader.IsBusy)
                {
                    _loader.CancelAsync();
                }
                if (_sender.IsBusy)
                {
                    _sender.CancelAsync();
                }
                _imapClient.Dispose();
            };
        }

        private void loader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            folderList.Enabled = true;
            logoutButton.Enabled = true;
            ((BackgroundWorker)sender).CancelAsync();
        }

        private void loader_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (((BackgroundWorker)sender).CancellationPending)
            {
                return;
            }
            progressBar.Value = e.ProgressPercentage + 1;
            mailCountLabel.Text = @"[" + (e.ProgressPercentage + 1) + @"/" + _count + @"]";
            mailsTable.Rows.Add();
            mailsTable.Rows[e.ProgressPercentage].Cells[0].Value = _myMails[e.ProgressPercentage].Subject;
            mailsTable.Rows[e.ProgressPercentage].Cells[1].Value = _myMails[e.ProgressPercentage].From;
            mailsTable.Rows[e.ProgressPercentage].Cells[2].Value = _myMails[e.ProgressPercentage].To;
            if (_myMails[e.ProgressPercentage].hasAttachments)
            {
                mailsTable.Rows[e.ProgressPercentage].Cells[3].Value = global::AppooProject.Properties.Resources.mail_plus;
            }
            else
            {
                mailsTable.Rows[e.ProgressPercentage].Cells[3].Value = global::AppooProject.Properties.Resources.Image1;

            }
            mailsTable.Rows[e.ProgressPercentage].Cells[4].Tag = e.ProgressPercentage.ToString();
        }

        private void loader_DoWork(object sender, DoWorkEventArgs e)
        {
            for (var i = 0; i < _count; i++)
            {
                if (((BackgroundWorker)sender).CancellationPending)
                {
                    return;
                }
                var mail = _imapClient.GetMail(i);
                _myMails.Add(mail);
                ((BackgroundWorker)sender).ReportProgress(i);
            }
        }

        private void FolderSelectedIndexChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked == false) return;
            folderList.Enabled = false;
            mailsTable.Rows.Clear();
            _myMails.Clear();
            _currentFolder = _folders.Single(f => f.Checked).Text;
            _imapClient.SelectFolder(_currentFolder);
            _count = _imapClient.MailsCount;
            progressBar.Value = 0;
            progressBar.Maximum = _count;
            mailCountLabel.Text = @"[0/" + _count + @"]";
            if (_count >= 0)
            {
                _loader.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show(@"Eroare selectare mapa.", @"Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sender_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toTextBox.Text = String.Empty;
            subjectTextBox.Text = String.Empty;
            bodyTextBox.Text = String.Empty;
            newMailBox.Enabled = true;
            fisierAles.Text = "";
            fisierPath = null;
        }

        private void sender_DoWork(object sender, DoWorkEventArgs e)
        {
            var smtpClient = new SMTPClient
            {
                Host = smtpHost.Text,
                Port = Convert.ToInt32(smtpPort.Value),
                Email = _email,
                Password = _password,
                EmailTo = toTextBox.Text,
                Subject = subjectTextBox.Text,
                Body = bodyTextBox.Text
            };
            smtpClient.Connect();
            try
            {
                smtpClient.Send(fisierPath);
                MessageBox.Show(
                        @"Email-ul a fost trimis cu succes.",
                        @"Trimis",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                        @"Eroare trimitere email " + ex.Message,
                        @"Eroare",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            smtpClient.Close();
        }

        private void sendMailButton_Click(object sender, EventArgs e)
        {
            var anddressIsEntred = !String.IsNullOrEmpty(toTextBox.Text);
            var subjectIsEntred = !String.IsNullOrEmpty(subjectTextBox.Text);
            if (anddressIsEntred && subjectIsEntred)
            {
                if (_sender.IsBusy == false)
                {
                    _sender.RunWorkerAsync();
                }
                newMailBox.Enabled = false;
            }
            else
            {
                MessageBox.Show(@"Nu ati introdus email.");
            }
        }

        private void mailsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                var mailIndex = Int32.Parse(((DataGridView)sender).Rows[e.RowIndex].Cells[4].Tag.ToString());
                var mail = _myMails[mailIndex];
                if (!mail.Body.Contains("<br>"))
                {
                    mail.Body = mail.Body.Replace("\n", "<br>");
                }
                webBrowser1.DocumentText = mail.Body;
                tabControl.SelectedTab = mailContentPage;
            }
            if (e.ColumnIndex != 4 || e.RowIndex < 0) return;
            try
            {
                var mailIndex = Int32.Parse(((DataGridView)sender).Rows[e.RowIndex].Cells[4].Tag.ToString());
                _imapClient.DeleteMail(mailIndex);
                ((DataGridView)sender).Rows.RemoveAt(e.RowIndex);
                _count--;
                mailCountLabel.Text = @"[" + _count + @"/" + _count + @"]";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    @"Eroare stergere email. " + ex.Message,
                    @"Eroare",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            _email = emailTextBox.Text;
            _password = passwordTextBox.Text;
            _imapClient.Host = imapHost.Text;
            _imapClient.Port = Convert.ToInt32(imapPort.Value);
            try
            {
                _imapClient.Connect(_email, _password);
            }
            catch (Exception excpt)
            {
                MessageBox.Show(
                    excpt.Message,
                    @"Eroare",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            var folders = _imapClient.GetFolders();
            _folders = new RadioButton[folders.Count];
            var i = 0;
            foreach (var folder in folders)
            {
                _folders[i] = new RadioButton
                {
                    Text = folder.name,
                    Location = new Point(0, i * 30 + 10)
                };
                _folders[i].CheckedChanged += FolderSelectedIndexChanged;
                folderList.Controls.Add(_folders[i]);
                i++;
            }
            logoutButton.Enabled = false;
            _folders[0].Checked = true;
            progressBar.Visible = true;
            tabControl.Controls.Add(mailListPage);
            tabControl.Controls.Add(mailContentPage);
            tabControl.Controls.Add(newMailPage);
            tabControl.Controls.Remove(authenticationPage);
        }

        private void alegeFiserButton_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                fisierPath = openFileDialog.FileName;
                fisierAles.Text = openFileDialog.FileName;
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            _loader.CancelAsync();
            _imapClient.CloseConnection();
            tabControl.Controls.Remove(mailListPage);
            tabControl.Controls.Remove(mailContentPage);
            tabControl.Controls.Remove(newMailPage);
            tabControl.Controls.Add(authenticationPage);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            imapHost.Text = "imap.mail.ru";
            imapPort.Text = "993";
            smtpHost.Text = "smtp.mail.ru";
            smtpPort.Text = "465";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            imapHost.Text = "imap.gmail.com";
            imapPort.Text = "993";
            smtpHost.Text = "smtp.gmail.com";
            smtpPort.Text = "465";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            imapHost.Text = "imap.mail.yahoo.com";
            imapPort.Text = "993";
            smtpHost.Text = "smtp.mail.yahoo.com";
            smtpPort.Text = "465";
        }
    }
}
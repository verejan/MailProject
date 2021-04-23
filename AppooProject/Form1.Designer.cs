namespace AppooProjectInterface
{
    partial class MyMailClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyMailClient));
            this.newMailBox = new System.Windows.Forms.GroupBox();
            this.fisierAles = new System.Windows.Forms.Label();
            this.alegeFiserButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.bodyTextBox = new System.Windows.Forms.TextBox();
            this.sendMailButton = new System.Windows.Forms.Button();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.bodyLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.mailsTable = new System.Windows.Forms.DataGridView();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attachment = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.mailCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this._sender = new System.ComponentModel.BackgroundWorker();
            this.newMailPage = new System.Windows.Forms.TabPage();
            this.mailListPage = new System.Windows.Forms.TabPage();
            this.logoutButton = new System.Windows.Forms.Button();
            this.folderList = new System.Windows.Forms.Panel();
            this.mailContentPage = new System.Windows.Forms.TabPage();
            this._loader = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.authenticationPage = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.imapPort = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.smtpPort = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.smtpHost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imapHost = new System.Windows.Forms.TextBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.newMailBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailsTable)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.newMailPage.SuspendLayout();
            this.mailListPage.SuspendLayout();
            this.mailContentPage.SuspendLayout();
            this.authenticationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imapPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smtpPort)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // newMailBox
            // 
            this.newMailBox.BackColor = System.Drawing.Color.Transparent;
            this.newMailBox.Controls.Add(this.fisierAles);
            this.newMailBox.Controls.Add(this.alegeFiserButton);
            this.newMailBox.Controls.Add(this.label7);
            this.newMailBox.Controls.Add(this.bodyTextBox);
            this.newMailBox.Controls.Add(this.sendMailButton);
            this.newMailBox.Controls.Add(this.subjectTextBox);
            this.newMailBox.Controls.Add(this.toTextBox);
            this.newMailBox.Controls.Add(this.bodyLabel);
            this.newMailBox.Controls.Add(this.subjectLabel);
            this.newMailBox.Controls.Add(this.toLabel);
            this.newMailBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newMailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newMailBox.Location = new System.Drawing.Point(3, 3);
            this.newMailBox.Name = "newMailBox";
            this.newMailBox.Size = new System.Drawing.Size(770, 377);
            this.newMailBox.TabIndex = 11;
            this.newMailBox.TabStop = false;
            this.newMailBox.Text = "Email nou";
            // 
            // fisierAles
            // 
            this.fisierAles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fisierAles.AutoSize = true;
            this.fisierAles.Location = new System.Drawing.Point(156, 306);
            this.fisierAles.Name = "fisierAles";
            this.fisierAles.Size = new System.Drawing.Size(0, 13);
            this.fisierAles.TabIndex = 9;
            // 
            // alegeFiserButton
            // 
            this.alegeFiserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.alegeFiserButton.Location = new System.Drawing.Point(75, 301);
            this.alegeFiserButton.Name = "alegeFiserButton";
            this.alegeFiserButton.Size = new System.Drawing.Size(75, 23);
            this.alegeFiserButton.TabIndex = 8;
            this.alegeFiserButton.Text = "Alege fisier";
            this.alegeFiserButton.UseVisualStyleBackColor = true;
            this.alegeFiserButton.Click += new System.EventHandler(this.alegeFiserButton_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Alegeti fisier:";
            // 
            // bodyTextBox
            // 
            this.bodyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bodyTextBox.Location = new System.Drawing.Point(59, 74);
            this.bodyTextBox.Multiline = true;
            this.bodyTextBox.Name = "bodyTextBox";
            this.bodyTextBox.Size = new System.Drawing.Size(705, 218);
            this.bodyTextBox.TabIndex = 5;
            this.bodyTextBox.Text = "Email text";
            // 
            // sendMailButton
            // 
            this.sendMailButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sendMailButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendMailButton.Location = new System.Drawing.Point(315, 333);
            this.sendMailButton.Name = "sendMailButton";
            this.sendMailButton.Size = new System.Drawing.Size(100, 28);
            this.sendMailButton.TabIndex = 6;
            this.sendMailButton.Text = "Trimite email";
            this.sendMailButton.UseVisualStyleBackColor = true;
            this.sendMailButton.Click += new System.EventHandler(this.sendMailButton_Click);
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectTextBox.Location = new System.Drawing.Point(59, 48);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(705, 20);
            this.subjectTextBox.TabIndex = 4;
            this.subjectTextBox.Text = "Subiect ";
            // 
            // toTextBox
            // 
            this.toTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toTextBox.Location = new System.Drawing.Point(59, 22);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(705, 20);
            this.toTextBox.TabIndex = 3;
            // 
            // bodyLabel
            // 
            this.bodyLabel.AutoSize = true;
            this.bodyLabel.Location = new System.Drawing.Point(10, 77);
            this.bodyLabel.Name = "bodyLabel";
            this.bodyLabel.Size = new System.Drawing.Size(49, 13);
            this.bodyLabel.TabIndex = 2;
            this.bodyLabel.Text = "Continut:";
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(10, 51);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(46, 13);
            this.subjectLabel.TabIndex = 1;
            this.subjectLabel.Text = "Subiect:";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(21, 25);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(35, 13);
            this.toLabel.TabIndex = 0;
            this.toLabel.Text = "Catre:";
            // 
            // mailsTable
            // 
            this.mailsTable.AllowUserToAddRows = false;
            this.mailsTable.AllowUserToDeleteRows = false;
            this.mailsTable.AllowUserToResizeRows = false;
            this.mailsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mailsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.mailsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mailsTable.BackgroundColor = System.Drawing.SystemColors.Window;
            this.mailsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mailsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mailsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.mailsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mailsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Subject,
            this.Sender,
            this.To,
            this.Attachment,
            this.Delete});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mailsTable.DefaultCellStyle = dataGridViewCellStyle20;
            this.mailsTable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mailsTable.Location = new System.Drawing.Point(207, 6);
            this.mailsTable.MultiSelect = false;
            this.mailsTable.Name = "mailsTable";
            this.mailsTable.ReadOnly = true;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mailsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.mailsTable.RowHeadersVisible = false;
            this.mailsTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mailsTable.Size = new System.Drawing.Size(566, 349);
            this.mailsTable.TabIndex = 0;
            // 
            // Subject
            // 
            this.Subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.Subject.DefaultCellStyle = dataGridViewCellStyle16;
            this.Subject.HeaderText = "Subiect";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            // 
            // Sender
            // 
            this.Sender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sender.DefaultCellStyle = dataGridViewCellStyle17;
            this.Sender.HeaderText = "De la";
            this.Sender.Name = "Sender";
            this.Sender.ReadOnly = true;
            // 
            // To
            // 
            this.To.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.To.DefaultCellStyle = dataGridViewCellStyle18;
            this.To.HeaderText = "Catre";
            this.To.Name = "To";
            this.To.ReadOnly = true;
            // 
            // Attachment
            // 
            this.Attachment.HeaderText = "Atasari";
            this.Attachment.Name = "Attachment";
            this.Attachment.ReadOnly = true;
            this.Attachment.Width = 45;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle19;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Text = "Sterge";
            this.Delete.ToolTipText = "Stergere email";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.mailCountLabel});
            this.statusStrip1.Location = new System.Drawing.Point(3, 358);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(770, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            this.progressBar.Visible = false;
            // 
            // mailCountLabel
            // 
            this.mailCountLabel.Name = "mailCountLabel";
            this.mailCountLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(820, 405);
            this.webBrowser1.TabIndex = 0;
            // 
            // newMailPage
            // 
            this.newMailPage.Controls.Add(this.newMailBox);
            this.newMailPage.Location = new System.Drawing.Point(4, 25);
            this.newMailPage.Name = "newMailPage";
            this.newMailPage.Padding = new System.Windows.Forms.Padding(3);
            this.newMailPage.Size = new System.Drawing.Size(776, 383);
            this.newMailPage.TabIndex = 3;
            this.newMailPage.Text = "Trimite Email";
            this.newMailPage.UseVisualStyleBackColor = true;
            // 
            // mailListPage
            // 
            this.mailListPage.Controls.Add(this.logoutButton);
            this.mailListPage.Controls.Add(this.statusStrip1);
            this.mailListPage.Controls.Add(this.folderList);
            this.mailListPage.Controls.Add(this.mailsTable);
            this.mailListPage.Location = new System.Drawing.Point(4, 25);
            this.mailListPage.Name = "mailListPage";
            this.mailListPage.Padding = new System.Windows.Forms.Padding(3);
            this.mailListPage.Size = new System.Drawing.Size(776, 383);
            this.mailListPage.TabIndex = 0;
            this.mailListPage.Text = "Lista email-uri";
            this.mailListPage.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(6, 332);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Iesire";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // folderList
            // 
            this.folderList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.folderList.Location = new System.Drawing.Point(9, 6);
            this.folderList.Name = "folderList";
            this.folderList.Size = new System.Drawing.Size(192, 320);
            this.folderList.TabIndex = 3;
            // 
            // mailContentPage
            // 
            this.mailContentPage.Controls.Add(this.webBrowser1);
            this.mailContentPage.Location = new System.Drawing.Point(4, 25);
            this.mailContentPage.Name = "mailContentPage";
            this.mailContentPage.Padding = new System.Windows.Forms.Padding(3);
            this.mailContentPage.Size = new System.Drawing.Size(826, 411);
            this.mailContentPage.TabIndex = 1;
            this.mailContentPage.Text = "Continut";
            this.mailContentPage.UseVisualStyleBackColor = true;
            // 
            // _loader
            // 
            this._loader.WorkerReportsProgress = true;
            this._loader.WorkerSupportsCancellation = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // authenticationPage
            // 
            this.authenticationPage.BackColor = System.Drawing.Color.Transparent;
            this.authenticationPage.Controls.Add(this.pictureBox3);
            this.authenticationPage.Controls.Add(this.pictureBox2);
            this.authenticationPage.Controls.Add(this.pictureBox1);
            this.authenticationPage.Controls.Add(this.groupBox1);
            this.authenticationPage.Location = new System.Drawing.Point(4, 25);
            this.authenticationPage.Name = "authenticationPage";
            this.authenticationPage.Padding = new System.Windows.Forms.Padding(3);
            this.authenticationPage.Size = new System.Drawing.Size(587, 317);
            this.authenticationPage.TabIndex = 2;
            this.authenticationPage.Text = "Autentificare";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(398, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(186, 166);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 166);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(198, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.imapPort);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.smtpPort);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.smtpHost);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.imapHost);
            this.groupBox1.Controls.Add(this.loadButton);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 146);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "SMTP Port:";
            // 
            // imapPort
            // 
            this.imapPort.Location = new System.Drawing.Point(364, 15);
            this.imapPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.imapPort.Name = "imapPort";
            this.imapPort.Size = new System.Drawing.Size(208, 20);
            this.imapPort.TabIndex = 8;
            this.imapPort.Value = new decimal(new int[] {
            993,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "SMTP Server:";
            // 
            // smtpPort
            // 
            this.smtpPort.Location = new System.Drawing.Point(364, 41);
            this.smtpPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.smtpPort.Name = "smtpPort";
            this.smtpPort.Size = new System.Drawing.Size(208, 20);
            this.smtpPort.TabIndex = 7;
            this.smtpPort.Value = new decimal(new int[] {
            465,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "IMAP Port:";
            // 
            // smtpHost
            // 
            this.smtpHost.Location = new System.Drawing.Point(86, 40);
            this.smtpHost.Name = "smtpHost";
            this.smtpHost.Size = new System.Drawing.Size(208, 20);
            this.smtpHost.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "IMAP Server:";
            // 
            // imapHost
            // 
            this.imapHost.Location = new System.Drawing.Point(86, 14);
            this.imapHost.Name = "imapHost";
            this.imapHost.Size = new System.Drawing.Size(208, 20);
            this.imapHost.TabIndex = 5;
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.loadButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadButton.Location = new System.Drawing.Point(243, 101);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(119, 28);
            this.loadButton.TabIndex = 4;
            this.loadButton.Text = "Autentificare ";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(364, 67);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(208, 20);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.emailTextBox.Location = new System.Drawing.Point(86, 66);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(208, 20);
            this.emailTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.authenticationPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(595, 346);
            this.tabControl.TabIndex = 1;
            // 
            // MyMailClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 346);
            this.Controls.Add(this.tabControl);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "MyMailClient";
            this.Text = "Email Client";
            this.newMailBox.ResumeLayout(false);
            this.newMailBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailsTable)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.newMailPage.ResumeLayout(false);
            this.mailListPage.ResumeLayout(false);
            this.mailListPage.PerformLayout();
            this.mailContentPage.ResumeLayout(false);
            this.authenticationPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imapPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smtpPort)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox newMailBox;
        private System.Windows.Forms.Button sendMailButton;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox bodyTextBox;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Label bodyLabel;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView mailsTable;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.ComponentModel.BackgroundWorker _sender;
        private System.Windows.Forms.TabPage mailListPage;
        private System.Windows.Forms.TabPage mailContentPage;
        private System.Windows.Forms.TabPage newMailPage;
        private System.ComponentModel.BackgroundWorker _loader;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel mailCountLabel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Attachments;
        private System.Windows.Forms.Panel folderList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewImageColumn Attachment;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label fisierAles;
        private System.Windows.Forms.Button alegeFiserButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.TabPage authenticationPage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown imapPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown smtpPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox smtpHost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox imapHost;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


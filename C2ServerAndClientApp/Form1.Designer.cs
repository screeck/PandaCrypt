namespace C2Server
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.keyPair = new System.Windows.Forms.TabControl();
            this.privKeyPage = new System.Windows.Forms.TabPage();
            this.privKeyTextBox = new System.Windows.Forms.TextBox();
            this.pubKeyPage = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.logTab = new System.Windows.Forms.TabPage();
            this.infectedList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.requestList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.denyButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.logTabTextBox = new System.Windows.Forms.TextBox();
            this.keyPair.SuspendLayout();
            this.privKeyPage.SuspendLayout();
            this.pubKeyPage.SuspendLayout();
            this.logTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(100, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "PandaCrypt C2 Server";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // keyPair
            // 
            this.keyPair.Controls.Add(this.privKeyPage);
            this.keyPair.Controls.Add(this.pubKeyPage);
            this.keyPair.Controls.Add(this.logTab);
            this.keyPair.Location = new System.Drawing.Point(524, 12);
            this.keyPair.Name = "keyPair";
            this.keyPair.SelectedIndex = 0;
            this.keyPair.Size = new System.Drawing.Size(264, 380);
            this.keyPair.TabIndex = 3;
            // 
            // privKeyPage
            // 
            this.privKeyPage.Controls.Add(this.privKeyTextBox);
            this.privKeyPage.Location = new System.Drawing.Point(4, 24);
            this.privKeyPage.Name = "privKeyPage";
            this.privKeyPage.Padding = new System.Windows.Forms.Padding(3);
            this.privKeyPage.Size = new System.Drawing.Size(256, 352);
            this.privKeyPage.TabIndex = 0;
            this.privKeyPage.Text = "Private key";
            this.privKeyPage.UseVisualStyleBackColor = true;
            // 
            // privKeyTextBox
            // 
            this.privKeyTextBox.Location = new System.Drawing.Point(6, 6);
            this.privKeyTextBox.Multiline = true;
            this.privKeyTextBox.Name = "privKeyTextBox";
            this.privKeyTextBox.ReadOnly = true;
            this.privKeyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.privKeyTextBox.Size = new System.Drawing.Size(244, 340);
            this.privKeyTextBox.TabIndex = 0;
            this.privKeyTextBox.Text = resources.GetString("privKeyTextBox.Text");
            this.privKeyTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pubKeyPage
            // 
            this.pubKeyPage.Controls.Add(this.textBox1);
            this.pubKeyPage.Location = new System.Drawing.Point(4, 24);
            this.pubKeyPage.Name = "pubKeyPage";
            this.pubKeyPage.Padding = new System.Windows.Forms.Padding(3);
            this.pubKeyPage.Size = new System.Drawing.Size(256, 352);
            this.pubKeyPage.TabIndex = 1;
            this.pubKeyPage.Text = "Public key";
            this.pubKeyPage.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(244, 340);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // logTab
            // 
            this.logTab.Controls.Add(this.logTabTextBox);
            this.logTab.Location = new System.Drawing.Point(4, 24);
            this.logTab.Name = "logTab";
            this.logTab.Padding = new System.Windows.Forms.Padding(3);
            this.logTab.Size = new System.Drawing.Size(256, 352);
            this.logTab.TabIndex = 2;
            this.logTab.Text = "Server logs";
            this.logTab.UseVisualStyleBackColor = true;
            // 
            // infectedList
            // 
            this.infectedList.BackColor = System.Drawing.Color.DimGray;
            this.infectedList.FormattingEnabled = true;
            this.infectedList.ItemHeight = 15;
            this.infectedList.Location = new System.Drawing.Point(12, 105);
            this.infectedList.Name = "infectedList";
            this.infectedList.Size = new System.Drawing.Size(230, 259);
            this.infectedList.TabIndex = 4;
            this.infectedList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Infected machines:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // requestList
            // 
            this.requestList.BackColor = System.Drawing.Color.DimGray;
            this.requestList.FormattingEnabled = true;
            this.requestList.ItemHeight = 15;
            this.requestList.Location = new System.Drawing.Point(259, 105);
            this.requestList.Name = "requestList";
            this.requestList.Size = new System.Drawing.Size(250, 259);
            this.requestList.TabIndex = 7;
            this.requestList.SelectedIndexChanged += new System.EventHandler(this.requestList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(259, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Decryption key requests";
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(434, 370);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 9;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // denyButton
            // 
            this.denyButton.Location = new System.Drawing.Point(353, 370);
            this.denyButton.Name = "denyButton";
            this.denyButton.Size = new System.Drawing.Size(75, 23);
            this.denyButton.TabIndex = 10;
            this.denyButton.Text = "Deny";
            this.denyButton.UseVisualStyleBackColor = true;
            this.denyButton.Click += new System.EventHandler(this.denyButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(341, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "IP:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ipTextBox
            // 
            this.ipTextBox.BackColor = System.Drawing.Color.Black;
            this.ipTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ipTextBox.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.ipTextBox.Location = new System.Drawing.Point(382, 32);
            this.ipTextBox.Multiline = true;
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(127, 18);
            this.ipTextBox.TabIndex = 12;
            this.ipTextBox.Text = "127.0.0.1:1234\r\n";
            this.ipTextBox.TextChanged += new System.EventHandler(this.ipTextBox_TextChanged);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(167, 370);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 13;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(86, 370);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 14;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // logTabTextBox
            // 
            this.logTabTextBox.Location = new System.Drawing.Point(5, 10);
            this.logTabTextBox.Multiline = true;
            this.logTabTextBox.Name = "logTabTextBox";
            this.logTabTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logTabTextBox.Size = new System.Drawing.Size(245, 336);
            this.logTabTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.denyButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.requestList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.infectedList);
            this.Controls.Add(this.keyPair);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.keyPair.ResumeLayout(false);
            this.privKeyPage.ResumeLayout(false);
            this.privKeyPage.PerformLayout();
            this.pubKeyPage.ResumeLayout(false);
            this.pubKeyPage.PerformLayout();
            this.logTab.ResumeLayout(false);
            this.logTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TabControl keyPair;
        private TabPage privKeyPage;
        private TextBox privKeyTextBox;
        private TabPage pubKeyPage;
        private TextBox textBox1;
        private ListBox infectedList;
        private Label label2;
        private PictureBox pictureBox1;
        private ListBox requestList;
        private Label label3;
        private Button acceptButton;
        private Button denyButton;
        private Label label4;
        private TextBox ipTextBox;
        private TabPage logTab;
        private Button startButton;
        private Button stopButton;
        private TextBox logTabTextBox;
    }
}
namespace GameMonitor
{
    partial class GameMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMonitor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startStopBtn = new System.Windows.Forms.Button();
            this.userTitleLbl = new System.Windows.Forms.Label();
            this.appStatusTitleLbl = new System.Windows.Forms.Label();
            this.playingTitleLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.playingLbl = new System.Windows.Forms.Label();
            this.userLbl = new System.Windows.Forms.Label();
            this.appStatusLbl = new System.Windows.Forms.Label();
            this.homePanel = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.loginUserTxtBox = new System.Windows.Forms.TextBox();
            this.loginPasswordlbl = new System.Windows.Forms.Label();
            this.loginUserlbl = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gamesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(288, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // gamesToolStripMenuItem
            // 
            this.gamesToolStripMenuItem.Name = "gamesToolStripMenuItem";
            this.gamesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.gamesToolStripMenuItem.Text = "Games";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fAQToolStripMenuItem,
            this.authorToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.fAQToolStripMenuItem.Text = "FAQ";
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.authorToolStripMenuItem.Text = "Author";
            // 
            // startStopBtn
            // 
            this.startStopBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.startStopBtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.startStopBtn.Location = new System.Drawing.Point(68, 377);
            this.startStopBtn.Name = "startStopBtn";
            this.startStopBtn.Size = new System.Drawing.Size(151, 38);
            this.startStopBtn.TabIndex = 1;
            this.startStopBtn.Text = "Start";
            this.startStopBtn.UseVisualStyleBackColor = true;
            this.startStopBtn.Click += new System.EventHandler(this.startStopBtn_Click);
            // 
            // userTitleLbl
            // 
            this.userTitleLbl.AutoSize = true;
            this.userTitleLbl.Location = new System.Drawing.Point(6, 16);
            this.userTitleLbl.Name = "userTitleLbl";
            this.userTitleLbl.Size = new System.Drawing.Size(32, 13);
            this.userTitleLbl.TabIndex = 2;
            this.userTitleLbl.Text = "User:";
            // 
            // appStatusTitleLbl
            // 
            this.appStatusTitleLbl.AutoSize = true;
            this.appStatusTitleLbl.Location = new System.Drawing.Point(6, 67);
            this.appStatusTitleLbl.Name = "appStatusTitleLbl";
            this.appStatusTitleLbl.Size = new System.Drawing.Size(60, 13);
            this.appStatusTitleLbl.TabIndex = 3;
            this.appStatusTitleLbl.Text = "App status:";
            // 
            // playingTitleLbl
            // 
            this.playingTitleLbl.AutoSize = true;
            this.playingTitleLbl.Location = new System.Drawing.Point(6, 43);
            this.playingTitleLbl.Name = "playingTitleLbl";
            this.playingTitleLbl.Size = new System.Drawing.Size(44, 13);
            this.playingTitleLbl.TabIndex = 4;
            this.playingTitleLbl.Text = "Playing:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.playingLbl);
            this.groupBox1.Controls.Add(this.userLbl);
            this.groupBox1.Controls.Add(this.appStatusLbl);
            this.groupBox1.Controls.Add(this.appStatusTitleLbl);
            this.groupBox1.Controls.Add(this.playingTitleLbl);
            this.groupBox1.Controls.Add(this.userTitleLbl);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 123);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // playingLbl
            // 
            this.playingLbl.AutoSize = true;
            this.playingLbl.Location = new System.Drawing.Point(56, 43);
            this.playingLbl.Name = "playingLbl";
            this.playingLbl.Size = new System.Drawing.Size(0, 13);
            this.playingLbl.TabIndex = 7;
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Location = new System.Drawing.Point(44, 16);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(0, 13);
            this.userLbl.TabIndex = 6;
            // 
            // appStatusLbl
            // 
            this.appStatusLbl.AutoSize = true;
            this.appStatusLbl.Location = new System.Drawing.Point(72, 67);
            this.appStatusLbl.Name = "appStatusLbl";
            this.appStatusLbl.Size = new System.Drawing.Size(0, 13);
            this.appStatusLbl.TabIndex = 5;
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.groupBox1);
            this.homePanel.Location = new System.Drawing.Point(21, 188);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(242, 166);
            this.homePanel.TabIndex = 8;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("logo.InitialImage")));
            this.logo.Location = new System.Drawing.Point(14, 39);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(262, 50);
            this.logo.TabIndex = 9;
            this.logo.TabStop = false;
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.loginPanel.Controls.Add(this.loginPasswordTxtBox);
            this.loginPanel.Controls.Add(this.loginUserTxtBox);
            this.loginPanel.Controls.Add(this.loginPasswordlbl);
            this.loginPanel.Controls.Add(this.loginUserlbl);
            this.loginPanel.Controls.Add(this.loginBtn);
            this.loginPanel.Location = new System.Drawing.Point(18, 178);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(245, 245);
            this.loginPanel.TabIndex = 11;
            this.loginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginPanel_Paint);
            // 
            // loginPasswordTxtBox
            // 
            this.loginPasswordTxtBox.Location = new System.Drawing.Point(101, 110);
            this.loginPasswordTxtBox.Name = "loginPasswordTxtBox";
            this.loginPasswordTxtBox.PasswordChar = '*';
            this.loginPasswordTxtBox.Size = new System.Drawing.Size(100, 20);
            this.loginPasswordTxtBox.TabIndex = 4;
            // 
            // loginUserTxtBox
            // 
            this.loginUserTxtBox.Location = new System.Drawing.Point(101, 62);
            this.loginUserTxtBox.Name = "loginUserTxtBox";
            this.loginUserTxtBox.Size = new System.Drawing.Size(100, 20);
            this.loginUserTxtBox.TabIndex = 3;
            // 
            // loginPasswordlbl
            // 
            this.loginPasswordlbl.AutoSize = true;
            this.loginPasswordlbl.Location = new System.Drawing.Point(28, 113);
            this.loginPasswordlbl.Name = "loginPasswordlbl";
            this.loginPasswordlbl.Size = new System.Drawing.Size(68, 13);
            this.loginPasswordlbl.TabIndex = 2;
            this.loginPasswordlbl.Text = "Password =>";
            // 
            // loginUserlbl
            // 
            this.loginUserlbl.AutoSize = true;
            this.loginUserlbl.Location = new System.Drawing.Point(28, 68);
            this.loginUserlbl.Name = "loginUserlbl";
            this.loginUserlbl.Size = new System.Drawing.Size(70, 13);
            this.loginUserlbl.TabIndex = 1;
            this.loginUserlbl.Text = "Username =>";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(88, 170);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // GameMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(288, 475);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.startStopBtn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameMonitor";
            this.Text = "GameMonitor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.homePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.Button startStopBtn;
        private System.Windows.Forms.Label userTitleLbl;
        private System.Windows.Forms.Label appStatusTitleLbl;
        private System.Windows.Forms.Label playingTitleLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label appStatusLbl;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.Label playingLbl;
        private System.Windows.Forms.ToolStripMenuItem gamesToolStripMenuItem;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.TextBox loginPasswordTxtBox;
        private System.Windows.Forms.TextBox loginUserTxtBox;
        private System.Windows.Forms.Label loginPasswordlbl;
        private System.Windows.Forms.Label loginUserlbl;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}


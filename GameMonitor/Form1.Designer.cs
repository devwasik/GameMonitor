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
            this.newUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startStopBtn = new System.Windows.Forms.Button();
            this.userTitleLbl = new System.Windows.Forms.Label();
            this.appStatusTitleLbl = new System.Windows.Forms.Label();
            this.playingTitleLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loadUserFileBtn = new System.Windows.Forms.Button();
            this.playingLbl = new System.Windows.Forms.Label();
            this.userLbl = new System.Windows.Forms.Label();
            this.appStatusLbl = new System.Windows.Forms.Label();
            this.editGamesPanel = new System.Windows.Forms.Panel();
            this.addGamePanel = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.addGameBtn1 = new System.Windows.Forms.Button();
            this.processNameAddLbl = new System.Windows.Forms.Label();
            this.gameNameAddLbl = new System.Windows.Forms.Label();
            this.gameProcessAddTxtBox = new System.Windows.Forms.TextBox();
            this.gameNameAddTxtBox = new System.Windows.Forms.TextBox();
            this.addGameBtn = new System.Windows.Forms.Button();
            this.gameListLbl = new System.Windows.Forms.Label();
            this.backBtn1 = new System.Windows.Forms.Button();
            this.homePanel = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.homeBtn = new System.Windows.Forms.Button();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.loginUserTxtBox = new System.Windows.Forms.TextBox();
            this.loginPasswordlbl = new System.Windows.Forms.Label();
            this.loginUserlbl = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.editGamesPanel.SuspendLayout();
            this.addGamePanel.SuspendLayout();
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
            this.newUserToolStripMenuItem,
            this.loadUserToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newUserToolStripMenuItem
            // 
            this.newUserToolStripMenuItem.Name = "newUserToolStripMenuItem";
            this.newUserToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.newUserToolStripMenuItem.Text = "New User";
            this.newUserToolStripMenuItem.Click += new System.EventHandler(this.newUserToolStripMenuItem_Click);
            // 
            // loadUserToolStripMenuItem
            // 
            this.loadUserToolStripMenuItem.Name = "loadUserToolStripMenuItem";
            this.loadUserToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.loadUserToolStripMenuItem.Text = "Load User";
            this.loadUserToolStripMenuItem.Click += new System.EventHandler(this.loadUserToolStripMenuItem_Click);
            // 
            // gamesToolStripMenuItem
            // 
            this.gamesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editGamesToolStripMenuItem,
            this.addGameToolStripMenuItem});
            this.gamesToolStripMenuItem.Name = "gamesToolStripMenuItem";
            this.gamesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.gamesToolStripMenuItem.Text = "Games";
            // 
            // editGamesToolStripMenuItem
            // 
            this.editGamesToolStripMenuItem.Name = "editGamesToolStripMenuItem";
            this.editGamesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.editGamesToolStripMenuItem.Text = "Edit Games";
            this.editGamesToolStripMenuItem.Click += new System.EventHandler(this.editGamesToolStripMenuItem_Click);
            // 
            // addGameToolStripMenuItem
            // 
            this.addGameToolStripMenuItem.Name = "addGameToolStripMenuItem";
            this.addGameToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.addGameToolStripMenuItem.Text = "Add Game";
            this.addGameToolStripMenuItem.Click += new System.EventHandler(this.addGameToolStripMenuItem_Click);
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
            this.groupBox1.Controls.Add(this.loadUserFileBtn);
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
            // loadUserFileBtn
            // 
            this.loadUserFileBtn.Location = new System.Drawing.Point(138, 11);
            this.loadUserFileBtn.Margin = new System.Windows.Forms.Padding(2);
            this.loadUserFileBtn.Name = "loadUserFileBtn";
            this.loadUserFileBtn.Size = new System.Drawing.Size(82, 19);
            this.loadUserFileBtn.TabIndex = 8;
            this.loadUserFileBtn.Text = "Load";
            this.loadUserFileBtn.UseVisualStyleBackColor = true;
            this.loadUserFileBtn.Click += new System.EventHandler(this.loadUserFileBtn_Click);
            // 
            // playingLbl
            // 
            this.playingLbl.AutoSize = true;
            this.playingLbl.Location = new System.Drawing.Point(56, 43);
            this.playingLbl.Name = "playingLbl";
            this.playingLbl.Size = new System.Drawing.Size(64, 13);
            this.playingLbl.TabIndex = 7;
            this.playingLbl.Text = "Not in game";
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Location = new System.Drawing.Point(44, 16);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(90, 13);
            this.userLbl.TabIndex = 6;
            this.userLbl.Text = "No user selected!";
            // 
            // appStatusLbl
            // 
            this.appStatusLbl.AutoSize = true;
            this.appStatusLbl.Location = new System.Drawing.Point(72, 67);
            this.appStatusLbl.Name = "appStatusLbl";
            this.appStatusLbl.Size = new System.Drawing.Size(0, 13);
            this.appStatusLbl.TabIndex = 5;
            // 
            // editGamesPanel
            // 
            this.editGamesPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.editGamesPanel.Controls.Add(this.addGamePanel);
            this.editGamesPanel.Controls.Add(this.addGameBtn);
            this.editGamesPanel.Controls.Add(this.gameListLbl);
            this.editGamesPanel.Controls.Add(this.backBtn1);
            this.editGamesPanel.Location = new System.Drawing.Point(18, 181);
            this.editGamesPanel.Name = "editGamesPanel";
            this.editGamesPanel.Size = new System.Drawing.Size(245, 234);
            this.editGamesPanel.TabIndex = 7;
            this.editGamesPanel.Visible = false;
            // 
            // addGamePanel
            // 
            this.addGamePanel.Controls.Add(this.backBtn);
            this.addGamePanel.Controls.Add(this.addGameBtn1);
            this.addGamePanel.Controls.Add(this.processNameAddLbl);
            this.addGamePanel.Controls.Add(this.gameNameAddLbl);
            this.addGamePanel.Controls.Add(this.gameProcessAddTxtBox);
            this.addGamePanel.Controls.Add(this.gameNameAddTxtBox);
            this.addGamePanel.Location = new System.Drawing.Point(0, 0);
            this.addGamePanel.Name = "addGamePanel";
            this.addGamePanel.Size = new System.Drawing.Size(245, 245);
            this.addGamePanel.TabIndex = 6;
            this.addGamePanel.Visible = false;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(23, 151);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // addGameBtn1
            // 
            this.addGameBtn1.Location = new System.Drawing.Point(116, 151);
            this.addGameBtn1.Name = "addGameBtn1";
            this.addGameBtn1.Size = new System.Drawing.Size(75, 23);
            this.addGameBtn1.TabIndex = 4;
            this.addGameBtn1.Text = "Add";
            this.addGameBtn1.UseVisualStyleBackColor = true;
            // 
            // processNameAddLbl
            // 
            this.processNameAddLbl.AutoSize = true;
            this.processNameAddLbl.Location = new System.Drawing.Point(20, 97);
            this.processNameAddLbl.Name = "processNameAddLbl";
            this.processNameAddLbl.Size = new System.Drawing.Size(77, 13);
            this.processNameAddLbl.TabIndex = 3;
            this.processNameAddLbl.Text = "Process name:";
            // 
            // gameNameAddLbl
            // 
            this.gameNameAddLbl.AutoSize = true;
            this.gameNameAddLbl.Location = new System.Drawing.Point(20, 49);
            this.gameNameAddLbl.Name = "gameNameAddLbl";
            this.gameNameAddLbl.Size = new System.Drawing.Size(67, 13);
            this.gameNameAddLbl.TabIndex = 2;
            this.gameNameAddLbl.Text = "Game name:";
            // 
            // gameProcessAddTxtBox
            // 
            this.gameProcessAddTxtBox.Location = new System.Drawing.Point(103, 94);
            this.gameProcessAddTxtBox.Name = "gameProcessAddTxtBox";
            this.gameProcessAddTxtBox.Size = new System.Drawing.Size(100, 20);
            this.gameProcessAddTxtBox.TabIndex = 1;
            // 
            // gameNameAddTxtBox
            // 
            this.gameNameAddTxtBox.Location = new System.Drawing.Point(103, 44);
            this.gameNameAddTxtBox.Name = "gameNameAddTxtBox";
            this.gameNameAddTxtBox.Size = new System.Drawing.Size(100, 20);
            this.gameNameAddTxtBox.TabIndex = 0;
            this.gameNameAddTxtBox.TextChanged += new System.EventHandler(this.gameNameAddTxtBox_TextChanged);
            // 
            // addGameBtn
            // 
            this.addGameBtn.Location = new System.Drawing.Point(141, 16);
            this.addGameBtn.Name = "addGameBtn";
            this.addGameBtn.Size = new System.Drawing.Size(75, 23);
            this.addGameBtn.TabIndex = 5;
            this.addGameBtn.Text = "Add Game";
            this.addGameBtn.UseVisualStyleBackColor = true;
            this.addGameBtn.Click += new System.EventHandler(this.addGameBtn_Click);
            // 
            // gameListLbl
            // 
            this.gameListLbl.AutoSize = true;
            this.gameListLbl.Location = new System.Drawing.Point(87, 78);
            this.gameListLbl.Name = "gameListLbl";
            this.gameListLbl.Size = new System.Drawing.Size(63, 13);
            this.gameListLbl.TabIndex = 4;
            this.gameListLbl.Text = "gameListLbl";
            // 
            // backBtn1
            // 
            this.backBtn1.Location = new System.Drawing.Point(35, 16);
            this.backBtn1.Name = "backBtn1";
            this.backBtn1.Size = new System.Drawing.Size(75, 23);
            this.backBtn1.TabIndex = 2;
            this.backBtn1.Text = "Back";
            this.backBtn1.UseVisualStyleBackColor = true;
            this.backBtn1.Click += new System.EventHandler(this.backBtn1_Click);
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
            this.logo.Location = new System.Drawing.Point(15, 93);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(262, 50);
            this.logo.TabIndex = 9;
            this.logo.TabStop = false;
            // 
            // homeBtn
            // 
            this.homeBtn.Location = new System.Drawing.Point(201, 41);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(75, 23);
            this.homeBtn.TabIndex = 10;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
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
            // 
            // GameMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(288, 475);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.editGamesPanel);
            this.Controls.Add(this.homePanel);
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
            this.editGamesPanel.ResumeLayout(false);
            this.editGamesPanel.PerformLayout();
            this.addGamePanel.ResumeLayout(false);
            this.addGamePanel.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem newUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadUserToolStripMenuItem;
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
        private System.Windows.Forms.Button loadUserFileBtn;
        private System.Windows.Forms.ToolStripMenuItem gamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGameToolStripMenuItem;
        private System.Windows.Forms.Panel editGamesPanel;
        private System.Windows.Forms.Button backBtn1;
        private System.Windows.Forms.Label gameListLbl;
        private System.Windows.Forms.Button addGameBtn;
        private System.Windows.Forms.Panel addGamePanel;
        private System.Windows.Forms.Button addGameBtn1;
        private System.Windows.Forms.Label processNameAddLbl;
        private System.Windows.Forms.Label gameNameAddLbl;
        private System.Windows.Forms.TextBox gameProcessAddTxtBox;
        private System.Windows.Forms.TextBox gameNameAddTxtBox;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.TextBox loginPasswordTxtBox;
        private System.Windows.Forms.TextBox loginUserTxtBox;
        private System.Windows.Forms.Label loginPasswordlbl;
        private System.Windows.Forms.Label loginUserlbl;
        private System.Windows.Forms.Button loginBtn;
    }
}


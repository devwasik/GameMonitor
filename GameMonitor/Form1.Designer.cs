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
            this.appHeaderLbl = new System.Windows.Forms.Label();
            this.editGamesPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backBtn1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.editGamesPanel.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(31, 216);
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
            // appHeaderLbl
            // 
            this.appHeaderLbl.AutoSize = true;
            this.appHeaderLbl.BackColor = System.Drawing.Color.Lime;
            this.appHeaderLbl.Font = new System.Drawing.Font("Gabriola", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appHeaderLbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.appHeaderLbl.Location = new System.Drawing.Point(28, 69);
            this.appHeaderLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.appHeaderLbl.Name = "appHeaderLbl";
            this.appHeaderLbl.Size = new System.Drawing.Size(245, 88);
            this.appHeaderLbl.TabIndex = 6;
            this.appHeaderLbl.Text = "GameMonitor";
            // 
            // editGamesPanel
            // 
            this.editGamesPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.editGamesPanel.Controls.Add(this.backBtn1);
            this.editGamesPanel.Controls.Add(this.label2);
            this.editGamesPanel.Controls.Add(this.label1);
            this.editGamesPanel.Location = new System.Drawing.Point(28, 181);
            this.editGamesPanel.Name = "editGamesPanel";
            this.editGamesPanel.Size = new System.Drawing.Size(245, 234);
            this.editGamesPanel.TabIndex = 7;
            this.editGamesPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "THIS IS JUST FOR TESTING // ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Game file will be loaded here";
            // 
            // backBtn1
            // 
            this.backBtn1.Location = new System.Drawing.Point(12, 16);
            this.backBtn1.Name = "backBtn1";
            this.backBtn1.Size = new System.Drawing.Size(75, 23);
            this.backBtn1.TabIndex = 2;
            this.backBtn1.Text = "Back";
            this.backBtn1.UseVisualStyleBackColor = true;
            this.backBtn1.Click += new System.EventHandler(this.backBtn1_Click);
            // 
            // GameMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(288, 475);
            this.Controls.Add(this.editGamesPanel);
            this.Controls.Add(this.appHeaderLbl);
            this.Controls.Add(this.groupBox1);
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
        private System.Windows.Forms.Label appHeaderLbl;
        private System.Windows.Forms.ToolStripMenuItem gamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGameToolStripMenuItem;
        private System.Windows.Forms.Panel editGamesPanel;
        private System.Windows.Forms.Button backBtn1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


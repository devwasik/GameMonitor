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
            this.loadUserFileBtn = new System.Windows.Forms.Button();
            this.appHeaderLbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(384, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newUserToolStripMenuItem,
            this.loadUserToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newUserToolStripMenuItem
            // 
            this.newUserToolStripMenuItem.Name = "newUserToolStripMenuItem";
            this.newUserToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.newUserToolStripMenuItem.Text = "New User";
            this.newUserToolStripMenuItem.Click += new System.EventHandler(this.newUserToolStripMenuItem_Click);
            // 
            // loadUserToolStripMenuItem
            // 
            this.loadUserToolStripMenuItem.Name = "loadUserToolStripMenuItem";
            this.loadUserToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.loadUserToolStripMenuItem.Text = "Load User";
            this.loadUserToolStripMenuItem.Click += new System.EventHandler(this.loadUserToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fAQToolStripMenuItem,
            this.authorToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.fAQToolStripMenuItem.Text = "FAQ";
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.authorToolStripMenuItem.Text = "Author";
            // 
            // startStopBtn
            // 
            this.startStopBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.startStopBtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.startStopBtn.Location = new System.Drawing.Point(91, 464);
            this.startStopBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startStopBtn.Name = "startStopBtn";
            this.startStopBtn.Size = new System.Drawing.Size(201, 47);
            this.startStopBtn.TabIndex = 1;
            this.startStopBtn.Text = "Start";
            this.startStopBtn.UseVisualStyleBackColor = true;
            this.startStopBtn.Click += new System.EventHandler(this.startStopBtn_Click);
            // 
            // userTitleLbl
            // 
            this.userTitleLbl.AutoSize = true;
            this.userTitleLbl.Location = new System.Drawing.Point(8, 20);
            this.userTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userTitleLbl.Name = "userTitleLbl";
            this.userTitleLbl.Size = new System.Drawing.Size(42, 17);
            this.userTitleLbl.TabIndex = 2;
            this.userTitleLbl.Text = "User:";
            // 
            // appStatusTitleLbl
            // 
            this.appStatusTitleLbl.AutoSize = true;
            this.appStatusTitleLbl.Location = new System.Drawing.Point(8, 82);
            this.appStatusTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.appStatusTitleLbl.Name = "appStatusTitleLbl";
            this.appStatusTitleLbl.Size = new System.Drawing.Size(79, 17);
            this.appStatusTitleLbl.TabIndex = 3;
            this.appStatusTitleLbl.Text = "App status:";
            // 
            // playingTitleLbl
            // 
            this.playingTitleLbl.AutoSize = true;
            this.playingTitleLbl.Location = new System.Drawing.Point(8, 53);
            this.playingTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playingTitleLbl.Name = "playingTitleLbl";
            this.playingTitleLbl.Size = new System.Drawing.Size(58, 17);
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
            this.groupBox1.Location = new System.Drawing.Point(41, 266);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(301, 151);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // playingLbl
            // 
            this.playingLbl.AutoSize = true;
            this.playingLbl.Location = new System.Drawing.Point(75, 53);
            this.playingLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playingLbl.Name = "playingLbl";
            this.playingLbl.Size = new System.Drawing.Size(84, 17);
            this.playingLbl.TabIndex = 7;
            this.playingLbl.Text = "Not in game";
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Location = new System.Drawing.Point(59, 20);
            this.userLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(118, 17);
            this.userLbl.TabIndex = 6;
            this.userLbl.Text = "No user selected!";
            // 
            // appStatusLbl
            // 
            this.appStatusLbl.AutoSize = true;
            this.appStatusLbl.Location = new System.Drawing.Point(96, 82);
            this.appStatusLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.appStatusLbl.Name = "appStatusLbl";
            this.appStatusLbl.Size = new System.Drawing.Size(0, 17);
            this.appStatusLbl.TabIndex = 5;
            // 
            // loadUserFileBtn
            // 
            this.loadUserFileBtn.Location = new System.Drawing.Point(184, 14);
            this.loadUserFileBtn.Name = "loadUserFileBtn";
            this.loadUserFileBtn.Size = new System.Drawing.Size(110, 23);
            this.loadUserFileBtn.TabIndex = 8;
            this.loadUserFileBtn.Text = "Load";
            this.loadUserFileBtn.UseVisualStyleBackColor = true;
            this.loadUserFileBtn.Click += new System.EventHandler(this.loadUserFileBtn_Click);
            // 
            // appHeaderLbl
            // 
            this.appHeaderLbl.AutoSize = true;
            this.appHeaderLbl.BackColor = System.Drawing.Color.Lime;
            this.appHeaderLbl.Font = new System.Drawing.Font("Gabriola", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appHeaderLbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.appHeaderLbl.Location = new System.Drawing.Point(37, 85);
            this.appHeaderLbl.Name = "appHeaderLbl";
            this.appHeaderLbl.Size = new System.Drawing.Size(305, 110);
            this.appHeaderLbl.TabIndex = 6;
            this.appHeaderLbl.Text = "GameMonitor";
            // 
            // GameMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(384, 585);
            this.Controls.Add(this.appHeaderLbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startStopBtn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GameMonitor";
            this.Text = "GameMonitor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}


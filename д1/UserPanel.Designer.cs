
namespace Demo
{
    partial class UserPanel
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Into = new System.Windows.Forms.Label();
            this.num_crushes = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.OnlyOneUserData = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogoutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeSpentOnSys = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnsuccessfulLogout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeOnSys = new System.Windows.Forms.Label();
            this.crashes = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OnlyOneUserData)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Into
            // 
            this.Into.AutoSize = true;
            this.Into.Location = new System.Drawing.Point(49, 57);
            this.Into.Name = "Into";
            this.Into.Size = new System.Drawing.Size(28, 13);
            this.Into.TabIndex = 1;
            this.Into.Text = "Intro";
            // 
            // num_crushes
            // 
            this.num_crushes.AutoSize = true;
            this.num_crushes.Location = new System.Drawing.Point(390, 57);
            this.num_crushes.Name = "num_crushes";
            this.num_crushes.Size = new System.Drawing.Size(99, 13);
            this.num_crushes.TabIndex = 2;
            this.num_crushes.Text = "Number of crushes:";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // OnlyOneUserData
            // 
            this.OnlyOneUserData.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.OnlyOneUserData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OnlyOneUserData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.LoginTime,
            this.LogoutTime,
            this.TimeSpentOnSys,
            this.UnsuccessfulLogout});
            this.OnlyOneUserData.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.OnlyOneUserData.Location = new System.Drawing.Point(12, 97);
            this.OnlyOneUserData.Name = "OnlyOneUserData";
            this.OnlyOneUserData.Size = new System.Drawing.Size(544, 341);
            this.OnlyOneUserData.TabIndex = 4;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // LoginTime
            // 
            this.LoginTime.HeaderText = "Login time";
            this.LoginTime.Name = "LoginTime";
            // 
            // LogoutTime
            // 
            this.LogoutTime.HeaderText = "Logout time";
            this.LogoutTime.Name = "LogoutTime";
            // 
            // TimeSpentOnSys
            // 
            this.TimeSpentOnSys.HeaderText = "Time spent on system";
            this.TimeSpentOnSys.Name = "TimeSpentOnSys";
            // 
            // UnsuccessfulLogout
            // 
            this.UnsuccessfulLogout.HeaderText = "Unsuccessful logout reason";
            this.UnsuccessfulLogout.Name = "UnsuccessfulLogout";
            // 
            // TimeOnSys
            // 
            this.TimeOnSys.AutoSize = true;
            this.TimeOnSys.Location = new System.Drawing.Point(202, 24);
            this.TimeOnSys.Name = "TimeOnSys";
            this.TimeOnSys.Size = new System.Drawing.Size(112, 13);
            this.TimeOnSys.TabIndex = 5;
            this.TimeOnSys.Text = "Time spent on system:";
            // 
            // crashes
            // 
            this.crashes.AutoSize = true;
            this.crashes.Location = new System.Drawing.Point(495, 57);
            this.crashes.Name = "crashes";
            this.crashes.Size = new System.Drawing.Size(0, 13);
            this.crashes.TabIndex = 6;
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.crashes);
            this.Controls.Add(this.TimeOnSys);
            this.Controls.Add(this.OnlyOneUserData);
            this.Controls.Add(this.num_crushes);
            this.Controls.Add(this.Into);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserPanel";
            this.Text = "AMONIC Airlines Automation System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserPanel_FormClosing);
            this.Load += new System.EventHandler(this.UP1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OnlyOneUserData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label Into;
        private System.Windows.Forms.Label num_crushes;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataGridView OnlyOneUserData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogoutTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeSpentOnSys;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnsuccessfulLogout;
        private System.Windows.Forms.Label TimeOnSys;
        private System.Windows.Forms.Label crashes;
    }
}

namespace Demo
{
    partial class AdminPanel
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
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.officesCB = new System.Windows.Forms.ComboBox();
            this.AllUsersData = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Office_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.LoginDisOrEnab = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllUsersData)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(677, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.addUserToolStripMenuItem.Text = "Add user";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Office";
            // 
            // officesCB
            // 
            this.officesCB.FormattingEnabled = true;
            this.officesCB.Items.AddRange(new object[] {
            "All offices",
            "Abu Dhabi",
            "Bahrain",
            "Doha"});
            this.officesCB.Location = new System.Drawing.Point(53, 32);
            this.officesCB.Name = "officesCB";
            this.officesCB.Size = new System.Drawing.Size(121, 21);
            this.officesCB.TabIndex = 2;
            this.officesCB.SelectedValueChanged += new System.EventHandler(this.officesCB_SelectedValueChanged);
            // 
            // AllUsersData
            // 
            this.AllUsersData.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AllUsersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllUsersData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.LastName,
            this.Age,
            this.UserRole,
            this.EmailAddress,
            this.Office_});
            this.AllUsersData.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.AllUsersData.Location = new System.Drawing.Point(15, 68);
            this.AllUsersData.Name = "AllUsersData";
            this.AllUsersData.Size = new System.Drawing.Size(643, 328);
            this.AllUsersData.TabIndex = 3;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last name";
            this.LastName.Name = "LastName";
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            // 
            // UserRole
            // 
            this.UserRole.HeaderText = "User Role";
            this.UserRole.Name = "UserRole";
            // 
            // EmailAddress
            // 
            this.EmailAddress.HeaderText = "Email Address";
            this.EmailAddress.Name = "EmailAddress";
            // 
            // Office_
            // 
            this.Office_.HeaderText = "Office";
            this.Office_.Name = "Office_";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Change Role";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.changeRole);
            // 
            // LoginDisOrEnab
            // 
            this.LoginDisOrEnab.Location = new System.Drawing.Point(170, 415);
            this.LoginDisOrEnab.Name = "LoginDisOrEnab";
            this.LoginDisOrEnab.Size = new System.Drawing.Size(119, 23);
            this.LoginDisOrEnab.TabIndex = 5;
            this.LoginDisOrEnab.Text = "Enable/Disable Login";
            this.LoginDisOrEnab.UseVisualStyleBackColor = true;
            this.LoginDisOrEnab.Click += new System.EventHandler(this.LoginDisOrEnab_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 451);
            this.Controls.Add(this.LoginDisOrEnab);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AllUsersData);
            this.Controls.Add(this.officesCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Text = "AMONIC Airlines Automation System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPanel_FormClosing);
            this.Load += new System.EventHandler(this.AP1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllUsersData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox officesCB;
        private System.Windows.Forms.DataGridView AllUsersData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button LoginDisOrEnab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Office_;
        private System.Windows.Forms.Timer timer;
    }
}

namespace Demo
{
    partial class Edit_Role
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fnameTB = new System.Windows.Forms.TextBox();
            this.lnameTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.Role = new System.Windows.Forms.Label();
            this.adminRadio = new System.Windows.Forms.RadioButton();
            this.userRadio = new System.Windows.Forms.RadioButton();
            this.apply = new System.Windows.Forms.Button();
            this.cencel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Last name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "First name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Email address";
            // 
            // fnameTB
            // 
            this.fnameTB.Location = new System.Drawing.Point(193, 127);
            this.fnameTB.Name = "fnameTB";
            this.fnameTB.Size = new System.Drawing.Size(167, 20);
            this.fnameTB.TabIndex = 11;
            this.fnameTB.WordWrap = false;
            // 
            // lnameTB
            // 
            this.lnameTB.Location = new System.Drawing.Point(193, 165);
            this.lnameTB.Name = "lnameTB";
            this.lnameTB.Size = new System.Drawing.Size(167, 20);
            this.lnameTB.TabIndex = 10;
            this.lnameTB.WordWrap = false;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(193, 90);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(167, 20);
            this.emailTB.TabIndex = 9;
            this.emailTB.WordWrap = false;
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Location = new System.Drawing.Point(115, 254);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(29, 13);
            this.Role.TabIndex = 15;
            this.Role.Text = "Role";
            // 
            // adminRadio
            // 
            this.adminRadio.AutoSize = true;
            this.adminRadio.Location = new System.Drawing.Point(193, 252);
            this.adminRadio.Name = "adminRadio";
            this.adminRadio.Size = new System.Drawing.Size(85, 17);
            this.adminRadio.TabIndex = 16;
            this.adminRadio.TabStop = true;
            this.adminRadio.Text = "Administrator";
            this.adminRadio.UseVisualStyleBackColor = true;
            // 
            // userRadio
            // 
            this.userRadio.AutoSize = true;
            this.userRadio.Location = new System.Drawing.Point(193, 286);
            this.userRadio.Name = "userRadio";
            this.userRadio.Size = new System.Drawing.Size(47, 17);
            this.userRadio.TabIndex = 17;
            this.userRadio.TabStop = true;
            this.userRadio.Text = "User";
            this.userRadio.UseVisualStyleBackColor = true;
            // 
            // apply
            // 
            this.apply.Location = new System.Drawing.Point(101, 322);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(75, 23);
            this.apply.TabIndex = 18;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // cencel
            // 
            this.cencel.Location = new System.Drawing.Point(285, 322);
            this.cencel.Name = "cencel";
            this.cencel.Size = new System.Drawing.Size(75, 23);
            this.cencel.TabIndex = 19;
            this.cencel.Text = "Cencel";
            this.cencel.UseVisualStyleBackColor = true;
            this.cencel.Click += new System.EventHandler(this.cencel_Click);
            // 
            // Edit_Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 367);
            this.Controls.Add(this.cencel);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.userRadio);
            this.Controls.Add(this.adminRadio);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fnameTB);
            this.Controls.Add(this.lnameTB);
            this.Controls.Add(this.emailTB);
            this.Name = "Edit_Role";
            this.Text = "Edit Role";
            this.Load += new System.EventHandler(this.Edit_Role_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fnameTB;
        private System.Windows.Forms.TextBox lnameTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.RadioButton adminRadio;
        private System.Windows.Forms.RadioButton userRadio;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Button cencel;
    }
}
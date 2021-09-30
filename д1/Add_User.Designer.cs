
namespace Demo
{
    partial class Add_User
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
            this.emailTB = new System.Windows.Forms.TextBox();
            this.lnameTB = new System.Windows.Forms.TextBox();
            this.fnameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.officesCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Birthday = new System.Windows.Forms.DateTimePicker();
            this.fillerror = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(186, 96);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(167, 20);
            this.emailTB.TabIndex = 0;
            this.emailTB.WordWrap = false;
            // 
            // lnameTB
            // 
            this.lnameTB.Location = new System.Drawing.Point(186, 171);
            this.lnameTB.Name = "lnameTB";
            this.lnameTB.Size = new System.Drawing.Size(167, 20);
            this.lnameTB.TabIndex = 1;
            this.lnameTB.WordWrap = false;
            // 
            // fnameTB
            // 
            this.fnameTB.Location = new System.Drawing.Point(186, 133);
            this.fnameTB.Name = "fnameTB";
            this.fnameTB.Size = new System.Drawing.Size(167, 20);
            this.fnameTB.TabIndex = 2;
            this.fnameTB.WordWrap = false;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(186, 291);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(167, 20);
            this.passwordTB.TabIndex = 3;
            this.passwordTB.WordWrap = false;
            // 
            // officesCB
            // 
            this.officesCB.FormattingEnabled = true;
            this.officesCB.Items.AddRange(new object[] {
            "Abu Dhabi",
            "Bahrain",
            "Doha"});
            this.officesCB.Location = new System.Drawing.Point(186, 210);
            this.officesCB.Name = "officesCB";
            this.officesCB.Size = new System.Drawing.Size(167, 21);
            this.officesCB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "First name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Office";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Birthday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(278, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Birthday
            // 
            this.Birthday.Location = new System.Drawing.Point(186, 253);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(167, 20);
            this.Birthday.TabIndex = 15;
            // 
            // fillerror
            // 
            this.fillerror.AutoSize = true;
            this.fillerror.ForeColor = System.Drawing.Color.Red;
            this.fillerror.Location = new System.Drawing.Point(129, 62);
            this.fillerror.Name = "fillerror";
            this.fillerror.Size = new System.Drawing.Size(207, 13);
            this.fillerror.TabIndex = 16;
            this.fillerror.Text = "Все поля обязательны для заполнения";
            // 
            // Add_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 436);
            this.Controls.Add(this.fillerror);
            this.Controls.Add(this.Birthday);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.officesCB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.fnameTB);
            this.Controls.Add(this.lnameTB);
            this.Controls.Add(this.emailTB);
            this.Name = "Add_User";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.Add_User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox lnameTB;
        private System.Windows.Forms.TextBox fnameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.ComboBox officesCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker Birthday;
        private System.Windows.Forms.Label fillerror;
    }
}
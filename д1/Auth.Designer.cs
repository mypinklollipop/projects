namespace Demo
{
    partial class Auth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Username = new System.Windows.Forms.Label();
            this.usernametb = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.Bloker = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Label();
            this.loginerror = new System.Windows.Forms.Label();
            this.paserror = new System.Windows.Forms.Label();
            this.blockerr = new System.Windows.Forms.Label();
            this.Passwordtb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(110, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 93);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(107, 198);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(55, 13);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username";
            // 
            // usernametb
            // 
            this.usernametb.Location = new System.Drawing.Point(188, 195);
            this.usernametb.Name = "usernametb";
            this.usernametb.Size = new System.Drawing.Size(234, 20);
            this.usernametb.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(107, 224);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(141, 313);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(115, 23);
            this.login.TabIndex = 5;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(282, 313);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(116, 23);
            this.exit.TabIndex = 6;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Bloker
            // 
            this.Bloker.Tick += new System.EventHandler(this.Bloker_Tick);
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Location = new System.Drawing.Point(138, 267);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(0, 13);
            this.timer.TabIndex = 7;
            // 
            // loginerror
            // 
            this.loginerror.AutoSize = true;
            this.loginerror.Location = new System.Drawing.Point(428, 198);
            this.loginerror.Name = "loginerror";
            this.loginerror.Size = new System.Drawing.Size(94, 13);
            this.loginerror.TabIndex = 8;
            this.loginerror.Text = "Login doesn\'t exist";
            // 
            // paserror
            // 
            this.paserror.AutoSize = true;
            this.paserror.Location = new System.Drawing.Point(428, 224);
            this.paserror.Name = "paserror";
            this.paserror.Size = new System.Drawing.Size(86, 13);
            this.paserror.TabIndex = 9;
            this.paserror.Text = "Check password";
            // 
            // blockerr
            // 
            this.blockerr.AutoSize = true;
            this.blockerr.ForeColor = System.Drawing.Color.Red;
            this.blockerr.Location = new System.Drawing.Point(206, 164);
            this.blockerr.Name = "blockerr";
            this.blockerr.Size = new System.Drawing.Size(172, 13);
            this.blockerr.TabIndex = 10;
            this.blockerr.Text = "Ваш аккаунт был заблокирован.";
            // 
            // Passwordtb
            // 
            this.Passwordtb.Location = new System.Drawing.Point(188, 221);
            this.Passwordtb.Name = "Passwordtb";
            this.Passwordtb.PasswordChar = '*';
            this.Passwordtb.Size = new System.Drawing.Size(234, 20);
            this.Passwordtb.TabIndex = 4;
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 381);
            this.Controls.Add(this.blockerr);
            this.Controls.Add(this.paserror);
            this.Controls.Add(this.loginerror);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.login);
            this.Controls.Add(this.Passwordtb);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.usernametb);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Auth";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox usernametb;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Timer Bloker;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Label loginerror;
        private System.Windows.Forms.Label paserror;
        private System.Windows.Forms.Label blockerr;
        private System.Windows.Forms.TextBox Passwordtb;
    }
}


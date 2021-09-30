namespace WindowsFormsApp2
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.butconnect = new System.Windows.Forms.Button();
            this.butdel = new System.Windows.Forms.Button();
            this.butsave = new System.Windows.Forms.Button();
            this.butadd = new System.Windows.Forms.Button();
            this.labelserver = new System.Windows.Forms.Label();
            this.labelbase = new System.Windows.Forms.Label();
            this.labeltable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(12, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(416, 279);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(120, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(179, 20);
            this.textBox3.TabIndex = 3;
            // 
            // butconnect
            // 
            this.butconnect.BackColor = System.Drawing.Color.MediumPurple;
            this.butconnect.Location = new System.Drawing.Point(306, 11);
            this.butconnect.Name = "butconnect";
            this.butconnect.Size = new System.Drawing.Size(123, 74);
            this.butconnect.TabIndex = 4;
            this.butconnect.Text = "Подключиться";
            this.butconnect.UseVisualStyleBackColor = false;
            this.butconnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // butdel
            // 
            this.butdel.BackColor = System.Drawing.Color.MediumPurple;
            this.butdel.Location = new System.Drawing.Point(12, 392);
            this.butdel.Name = "butdel";
            this.butdel.Size = new System.Drawing.Size(75, 23);
            this.butdel.TabIndex = 5;
            this.butdel.Text = "Удалить";
            this.butdel.UseVisualStyleBackColor = false;
            this.butdel.Click += new System.EventHandler(this.butdel_Click);
            // 
            // butsave
            // 
            this.butsave.BackColor = System.Drawing.Color.MediumPurple;
            this.butsave.Location = new System.Drawing.Point(353, 392);
            this.butsave.Name = "butsave";
            this.butsave.Size = new System.Drawing.Size(75, 23);
            this.butsave.TabIndex = 6;
            this.butsave.Text = "Сохранить";
            this.butsave.UseVisualStyleBackColor = false;
            this.butsave.Click += new System.EventHandler(this.butsave_Click);
            // 
            // butadd
            // 
            this.butadd.BackColor = System.Drawing.Color.MediumPurple;
            this.butadd.Location = new System.Drawing.Point(272, 392);
            this.butadd.Name = "butadd";
            this.butadd.Size = new System.Drawing.Size(75, 23);
            this.butadd.TabIndex = 7;
            this.butadd.Text = "Добавить";
            this.butadd.UseVisualStyleBackColor = false;
            this.butadd.Click += new System.EventHandler(this.butadd_Click);
            // 
            // labelserver
            // 
            this.labelserver.AutoSize = true;
            this.labelserver.BackColor = System.Drawing.Color.Lavender;
            this.labelserver.ForeColor = System.Drawing.Color.Indigo;
            this.labelserver.Location = new System.Drawing.Point(37, 15);
            this.labelserver.Name = "labelserver";
            this.labelserver.Size = new System.Drawing.Size(77, 13);
            this.labelserver.TabIndex = 8;
            this.labelserver.Text = "Имя сервера:";
            // 
            // labelbase
            // 
            this.labelbase.AutoSize = true;
            this.labelbase.BackColor = System.Drawing.Color.Lavender;
            this.labelbase.ForeColor = System.Drawing.Color.Indigo;
            this.labelbase.Location = new System.Drawing.Point(13, 42);
            this.labelbase.Name = "labelbase";
            this.labelbase.Size = new System.Drawing.Size(101, 13);
            this.labelbase.TabIndex = 9;
            this.labelbase.Text = "Имя базы данных:";
            // 
            // labeltable
            // 
            this.labeltable.AutoSize = true;
            this.labeltable.BackColor = System.Drawing.Color.Lavender;
            this.labeltable.ForeColor = System.Drawing.Color.Indigo;
            this.labeltable.Location = new System.Drawing.Point(36, 68);
            this.labeltable.Name = "labeltable";
            this.labeltable.Size = new System.Drawing.Size(78, 13);
            this.labeltable.TabIndex = 10;
            this.labeltable.Text = "Имя таблицы:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(441, 439);
            this.Controls.Add(this.labeltable);
            this.Controls.Add(this.labelbase);
            this.Controls.Add(this.labelserver);
            this.Controls.Add(this.butadd);
            this.Controls.Add(this.butsave);
            this.Controls.Add(this.butdel);
            this.Controls.Add(this.butconnect);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "Подключение к БД";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button butconnect;
        private System.Windows.Forms.Button butdel;
        private System.Windows.Forms.Button butsave;
        private System.Windows.Forms.Button butadd;
        private System.Windows.Forms.Label labelserver;
        private System.Windows.Forms.Label labelbase;
        private System.Windows.Forms.Label labeltable;
    }
}


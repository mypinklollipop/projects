namespace WindowsFormsApp1
{
    partial class Успеваемость
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this._319_6_Хисамутдинова_АлинаDataSet1 = new WindowsFormsApp1._319_6_Хисамутдинова_АлинаDataSet1();
            this.успеваемостьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.успеваемостьTableAdapter = new WindowsFormsApp1._319_6_Хисамутдинова_АлинаDataSet1TableAdapters.УспеваемостьTableAdapter();
            this.номерЗачёткиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерСеместраDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.предметDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оценкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЭкзаменаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияПреподавателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._319_6_Хисамутдинова_АлинаDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.успеваемостьBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерЗачёткиDataGridViewTextBoxColumn,
            this.номерСеместраDataGridViewTextBoxColumn,
            this.предметDataGridViewTextBoxColumn,
            this.оценкаDataGridViewTextBoxColumn,
            this.датаЭкзаменаDataGridViewTextBoxColumn,
            this.фамилияПреподавателяDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.успеваемостьBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 252);
            this.dataGridView1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(220, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 50);
            this.button3.TabIndex = 8;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(220, 326);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(220, 62);
            this.button5.TabIndex = 11;
            this.button5.Text = "Факультет/Предмет";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(446, 326);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(206, 62);
            this.button4.TabIndex = 10;
            this.button4.Text = "Специальность";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 62);
            this.button1.TabIndex = 9;
            this.button1.Text = "Студент";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _319_6_Хисамутдинова_АлинаDataSet1
            // 
            this._319_6_Хисамутдинова_АлинаDataSet1.DataSetName = "_319_6_Хисамутдинова_АлинаDataSet1";
            this._319_6_Хисамутдинова_АлинаDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // успеваемостьBindingSource
            // 
            this.успеваемостьBindingSource.DataMember = "Успеваемость";
            this.успеваемостьBindingSource.DataSource = this._319_6_Хисамутдинова_АлинаDataSet1;
            // 
            // успеваемостьTableAdapter
            // 
            this.успеваемостьTableAdapter.ClearBeforeFill = true;
            // 
            // номерЗачёткиDataGridViewTextBoxColumn
            // 
            this.номерЗачёткиDataGridViewTextBoxColumn.DataPropertyName = "Номер зачётки";
            this.номерЗачёткиDataGridViewTextBoxColumn.HeaderText = "Номер зачётки";
            this.номерЗачёткиDataGridViewTextBoxColumn.Name = "номерЗачёткиDataGridViewTextBoxColumn";
            // 
            // номерСеместраDataGridViewTextBoxColumn
            // 
            this.номерСеместраDataGridViewTextBoxColumn.DataPropertyName = "Номер семестра";
            this.номерСеместраDataGridViewTextBoxColumn.HeaderText = "Номер семестра";
            this.номерСеместраDataGridViewTextBoxColumn.Name = "номерСеместраDataGridViewTextBoxColumn";
            // 
            // предметDataGridViewTextBoxColumn
            // 
            this.предметDataGridViewTextBoxColumn.DataPropertyName = "Предмет";
            this.предметDataGridViewTextBoxColumn.HeaderText = "Предмет";
            this.предметDataGridViewTextBoxColumn.Name = "предметDataGridViewTextBoxColumn";
            // 
            // оценкаDataGridViewTextBoxColumn
            // 
            this.оценкаDataGridViewTextBoxColumn.DataPropertyName = "Оценка";
            this.оценкаDataGridViewTextBoxColumn.HeaderText = "Оценка";
            this.оценкаDataGridViewTextBoxColumn.Name = "оценкаDataGridViewTextBoxColumn";
            // 
            // датаЭкзаменаDataGridViewTextBoxColumn
            // 
            this.датаЭкзаменаDataGridViewTextBoxColumn.DataPropertyName = "Дата экзамена";
            this.датаЭкзаменаDataGridViewTextBoxColumn.HeaderText = "Дата экзамена";
            this.датаЭкзаменаDataGridViewTextBoxColumn.Name = "датаЭкзаменаDataGridViewTextBoxColumn";
            // 
            // фамилияПреподавателяDataGridViewTextBoxColumn
            // 
            this.фамилияПреподавателяDataGridViewTextBoxColumn.DataPropertyName = "Фамилия преподавателя";
            this.фамилияПреподавателяDataGridViewTextBoxColumn.HeaderText = "Фамилия преподавателя";
            this.фамилияПреподавателяDataGridViewTextBoxColumn.Name = "фамилияПреподавателяDataGridViewTextBoxColumn";
            // 
            // Успеваемость
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(674, 412);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Успеваемость";
            this.Text = "Успеваемость";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Успеваемость_FormClosed);
            this.Load += new System.EventHandler(this.Успеваемость_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._319_6_Хисамутдинова_АлинаDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.успеваемостьBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private _319_6_Хисамутдинова_АлинаDataSet1 _319_6_Хисамутдинова_АлинаDataSet1;
        private System.Windows.Forms.BindingSource успеваемостьBindingSource;
        private _319_6_Хисамутдинова_АлинаDataSet1TableAdapters.УспеваемостьTableAdapter успеваемостьTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЗачёткиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерСеместраDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn предметDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оценкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЭкзаменаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияПреподавателяDataGridViewTextBoxColumn;
    }
}
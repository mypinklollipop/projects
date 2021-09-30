namespace WindowsFormsApp1
{
    partial class Студент
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
            this._319_6_Хисамутдинова_АлинаDataSet5 = new WindowsFormsApp1._319_6_Хисамутдинова_АлинаDataSet5();
            this.студентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.студентTableAdapter = new WindowsFormsApp1._319_6_Хисамутдинова_АлинаDataSet5TableAdapters.СтудентTableAdapter();
            this.номерЗачёткиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияИмяОтчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПоступленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.факультетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.специальностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.курсDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерГруппыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._319_6_Хисамутдинова_АлинаDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерЗачёткиDataGridViewTextBoxColumn,
            this.фамилияИмяОтчествоDataGridViewTextBoxColumn,
            this.датаПоступленияDataGridViewTextBoxColumn,
            this.факультетDataGridViewTextBoxColumn,
            this.специальностьDataGridViewTextBoxColumn,
            this.курсDataGridViewTextBoxColumn,
            this.номерГруппыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.студентBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(277, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(239, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(277, 329);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(239, 59);
            this.button5.TabIndex = 9;
            this.button5.Text = "Успеваемость";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(522, 329);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(233, 59);
            this.button4.TabIndex = 8;
            this.button4.Text = "Специальность";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 59);
            this.button1.TabIndex = 7;
            this.button1.Text = "Факультет/Предмет";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // _319_6_Хисамутдинова_АлинаDataSet5
            // 
            this._319_6_Хисамутдинова_АлинаDataSet5.DataSetName = "_319_6_Хисамутдинова_АлинаDataSet5";
            this._319_6_Хисамутдинова_АлинаDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // студентBindingSource
            // 
            this.студентBindingSource.DataMember = "Студент";
            this.студентBindingSource.DataSource = this._319_6_Хисамутдинова_АлинаDataSet5;
            // 
            // студентTableAdapter
            // 
            this.студентTableAdapter.ClearBeforeFill = true;
            // 
            // номерЗачёткиDataGridViewTextBoxColumn
            // 
            this.номерЗачёткиDataGridViewTextBoxColumn.DataPropertyName = "Номер зачётки";
            this.номерЗачёткиDataGridViewTextBoxColumn.HeaderText = "Номер зачётки";
            this.номерЗачёткиDataGridViewTextBoxColumn.Name = "номерЗачёткиDataGridViewTextBoxColumn";
            // 
            // фамилияИмяОтчествоDataGridViewTextBoxColumn
            // 
            this.фамилияИмяОтчествоDataGridViewTextBoxColumn.DataPropertyName = "Фамилия, имя, отчество";
            this.фамилияИмяОтчествоDataGridViewTextBoxColumn.HeaderText = "Фамилия, имя, отчество";
            this.фамилияИмяОтчествоDataGridViewTextBoxColumn.Name = "фамилияИмяОтчествоDataGridViewTextBoxColumn";
            // 
            // датаПоступленияDataGridViewTextBoxColumn
            // 
            this.датаПоступленияDataGridViewTextBoxColumn.DataPropertyName = "Дата поступления";
            this.датаПоступленияDataGridViewTextBoxColumn.HeaderText = "Дата поступления";
            this.датаПоступленияDataGridViewTextBoxColumn.Name = "датаПоступленияDataGridViewTextBoxColumn";
            // 
            // факультетDataGridViewTextBoxColumn
            // 
            this.факультетDataGridViewTextBoxColumn.DataPropertyName = "Факультет";
            this.факультетDataGridViewTextBoxColumn.HeaderText = "Факультет";
            this.факультетDataGridViewTextBoxColumn.Name = "факультетDataGridViewTextBoxColumn";
            // 
            // специальностьDataGridViewTextBoxColumn
            // 
            this.специальностьDataGridViewTextBoxColumn.DataPropertyName = "Специальность";
            this.специальностьDataGridViewTextBoxColumn.HeaderText = "Специальность";
            this.специальностьDataGridViewTextBoxColumn.Name = "специальностьDataGridViewTextBoxColumn";
            // 
            // курсDataGridViewTextBoxColumn
            // 
            this.курсDataGridViewTextBoxColumn.DataPropertyName = "Курс";
            this.курсDataGridViewTextBoxColumn.HeaderText = "Курс";
            this.курсDataGridViewTextBoxColumn.Name = "курсDataGridViewTextBoxColumn";
            // 
            // номерГруппыDataGridViewTextBoxColumn
            // 
            this.номерГруппыDataGridViewTextBoxColumn.DataPropertyName = "Номер группы";
            this.номерГруппыDataGridViewTextBoxColumn.HeaderText = "Номер группы";
            this.номерГруппыDataGridViewTextBoxColumn.Name = "номерГруппыDataGridViewTextBoxColumn";
            // 
            // Студент
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(768, 412);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Студент";
            this.Text = "Студент";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Студент_FormClosed);
            this.Load += new System.EventHandler(this.Студент_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._319_6_Хисамутдинова_АлинаDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private _319_6_Хисамутдинова_АлинаDataSet5 _319_6_Хисамутдинова_АлинаDataSet5;
        private System.Windows.Forms.BindingSource студентBindingSource;
        private _319_6_Хисамутдинова_АлинаDataSet5TableAdapters.СтудентTableAdapter студентTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЗачёткиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияИмяОтчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПоступленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn факультетDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn специальностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn курсDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерГруппыDataGridViewTextBoxColumn;
    }
}
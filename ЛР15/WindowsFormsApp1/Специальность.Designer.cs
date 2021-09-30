namespace WindowsFormsApp1
{
    partial class Специальность
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
            this._319_6_Хисамутдинова_АлинаDataSet2 = new WindowsFormsApp1._319_6_Хисамутдинова_АлинаDataSet2();
            this.специальностьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.специальностьTableAdapter = new WindowsFormsApp1._319_6_Хисамутдинова_АлинаDataSet2TableAdapters.СпециальностьTableAdapter();
            this.кодСпециальностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеСпециальностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._319_6_Хисамутдинова_АлинаDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностьBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодСпециальностиDataGridViewTextBoxColumn,
            this.названиеСпециальностиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.специальностьBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(245, 389);
            this.dataGridView1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(354, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 61);
            this.button3.TabIndex = 2;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(354, 315);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(216, 61);
            this.button5.TabIndex = 9;
            this.button5.Text = "Успеваемость";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(354, 248);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(216, 61);
            this.button4.TabIndex = 8;
            this.button4.Text = "Факультет/Предмет";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(354, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 61);
            this.button1.TabIndex = 7;
            this.button1.Text = "Студент";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _319_6_Хисамутдинова_АлинаDataSet2
            // 
            this._319_6_Хисамутдинова_АлинаDataSet2.DataSetName = "_319_6_Хисамутдинова_АлинаDataSet2";
            this._319_6_Хисамутдинова_АлинаDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // специальностьBindingSource
            // 
            this.специальностьBindingSource.DataMember = "Специальность";
            this.специальностьBindingSource.DataSource = this._319_6_Хисамутдинова_АлинаDataSet2;
            // 
            // специальностьTableAdapter
            // 
            this.специальностьTableAdapter.ClearBeforeFill = true;
            // 
            // кодСпециальностиDataGridViewTextBoxColumn
            // 
            this.кодСпециальностиDataGridViewTextBoxColumn.DataPropertyName = "Код специальности";
            this.кодСпециальностиDataGridViewTextBoxColumn.HeaderText = "Код специальности";
            this.кодСпециальностиDataGridViewTextBoxColumn.Name = "кодСпециальностиDataGridViewTextBoxColumn";
            // 
            // названиеСпециальностиDataGridViewTextBoxColumn
            // 
            this.названиеСпециальностиDataGridViewTextBoxColumn.DataPropertyName = "Название специальности";
            this.названиеСпециальностиDataGridViewTextBoxColumn.HeaderText = "Название специальности";
            this.названиеСпециальностиDataGridViewTextBoxColumn.Name = "названиеСпециальностиDataGridViewTextBoxColumn";
            // 
            // Специальность
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(661, 413);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Специальность";
            this.Text = "Специальность";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Специальность_FormClosed);
            this.Load += new System.EventHandler(this.Специальность_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._319_6_Хисамутдинова_АлинаDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностьBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private _319_6_Хисамутдинова_АлинаDataSet2 _319_6_Хисамутдинова_АлинаDataSet2;
        private System.Windows.Forms.BindingSource специальностьBindingSource;
        private _319_6_Хисамутдинова_АлинаDataSet2TableAdapters.СпециальностьTableAdapter специальностьTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСпециальностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеСпециальностиDataGridViewTextBoxColumn;
    }
}
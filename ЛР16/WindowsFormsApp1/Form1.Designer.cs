namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxUPDATENAME = new System.Windows.Forms.TextBox();
            this.textBoxADDAUTHOR = new System.Windows.Forms.TextBox();
            this.textBoxUPDATEAUTHOR = new System.Windows.Forms.TextBox();
            this.textBoxADDPAGES = new System.Windows.Forms.TextBox();
            this.textBoxADDNAME = new System.Windows.Forms.TextBox();
            this.textBoxUPDATEPAGES = new System.Windows.Forms.TextBox();
            this.textBoxADDYEAR = new System.Windows.Forms.TextBox();
            this.textBoxUPDATEYEAR = new System.Windows.Forms.TextBox();
            this.textBoxUPDATEID = new System.Windows.Forms.TextBox();
            this.textBoxDELETEID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this._319_6_Хисамутдинова_АлинаDataSet = new WindowsFormsApp1._319_6_Хисамутдинова_АлинаDataSet();
            this.библиотекаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.библиотекаTableAdapter = new WindowsFormsApp1._319_6_Хисамутдинова_АлинаDataSetTableAdapters.БиблиотекаTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.авторDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоСтраницDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._319_6_Хисамутдинова_АлинаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.библиотекаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.авторDataGridViewTextBoxColumn,
            this.количествоСтраницDataGridViewTextBoxColumn,
            this.годDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.библиотекаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(555, 259);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxUPDATEID);
            this.panel1.Controls.Add(this.textBoxUPDATEYEAR);
            this.panel1.Controls.Add(this.textBoxUPDATEPAGES);
            this.panel1.Controls.Add(this.textBoxUPDATEAUTHOR);
            this.panel1.Controls.Add(this.textBoxUPDATENAME);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(573, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 258);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Thistle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.textBoxADDAUTHOR);
            this.panel2.Controls.Add(this.textBoxADDPAGES);
            this.panel2.Controls.Add(this.textBoxADDYEAR);
            this.panel2.Controls.Add(this.textBoxADDNAME);
            this.panel2.Location = new System.Drawing.Point(12, 277);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 132);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Thistle;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.textBoxDELETEID);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(573, 277);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 132);
            this.panel3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightYellow;
            this.button1.Location = new System.Drawing.Point(95, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightYellow;
            this.button2.Location = new System.Drawing.Point(101, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 33);
            this.button2.TabIndex = 0;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightYellow;
            this.button3.Location = new System.Drawing.Point(400, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 34);
            this.button3.TabIndex = 0;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxUPDATENAME
            // 
            this.textBoxUPDATENAME.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxUPDATENAME.Location = new System.Drawing.Point(154, 50);
            this.textBoxUPDATENAME.Name = "textBoxUPDATENAME";
            this.textBoxUPDATENAME.Size = new System.Drawing.Size(100, 20);
            this.textBoxUPDATENAME.TabIndex = 1;
            // 
            // textBoxADDAUTHOR
            // 
            this.textBoxADDAUTHOR.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxADDAUTHOR.Location = new System.Drawing.Point(127, 42);
            this.textBoxADDAUTHOR.Name = "textBoxADDAUTHOR";
            this.textBoxADDAUTHOR.Size = new System.Drawing.Size(243, 20);
            this.textBoxADDAUTHOR.TabIndex = 2;
            // 
            // textBoxUPDATEAUTHOR
            // 
            this.textBoxUPDATEAUTHOR.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxUPDATEAUTHOR.Location = new System.Drawing.Point(154, 76);
            this.textBoxUPDATEAUTHOR.Name = "textBoxUPDATEAUTHOR";
            this.textBoxUPDATEAUTHOR.Size = new System.Drawing.Size(100, 20);
            this.textBoxUPDATEAUTHOR.TabIndex = 3;
            // 
            // textBoxADDPAGES
            // 
            this.textBoxADDPAGES.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxADDPAGES.Location = new System.Drawing.Point(127, 68);
            this.textBoxADDPAGES.Name = "textBoxADDPAGES";
            this.textBoxADDPAGES.Size = new System.Drawing.Size(243, 20);
            this.textBoxADDPAGES.TabIndex = 4;
            // 
            // textBoxADDNAME
            // 
            this.textBoxADDNAME.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxADDNAME.Location = new System.Drawing.Point(127, 16);
            this.textBoxADDNAME.Name = "textBoxADDNAME";
            this.textBoxADDNAME.Size = new System.Drawing.Size(243, 20);
            this.textBoxADDNAME.TabIndex = 5;
            // 
            // textBoxUPDATEPAGES
            // 
            this.textBoxUPDATEPAGES.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxUPDATEPAGES.Location = new System.Drawing.Point(154, 102);
            this.textBoxUPDATEPAGES.Name = "textBoxUPDATEPAGES";
            this.textBoxUPDATEPAGES.Size = new System.Drawing.Size(100, 20);
            this.textBoxUPDATEPAGES.TabIndex = 6;
            // 
            // textBoxADDYEAR
            // 
            this.textBoxADDYEAR.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxADDYEAR.Location = new System.Drawing.Point(127, 94);
            this.textBoxADDYEAR.Name = "textBoxADDYEAR";
            this.textBoxADDYEAR.Size = new System.Drawing.Size(243, 20);
            this.textBoxADDYEAR.TabIndex = 7;
            // 
            // textBoxUPDATEYEAR
            // 
            this.textBoxUPDATEYEAR.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxUPDATEYEAR.Location = new System.Drawing.Point(154, 128);
            this.textBoxUPDATEYEAR.Name = "textBoxUPDATEYEAR";
            this.textBoxUPDATEYEAR.Size = new System.Drawing.Size(100, 20);
            this.textBoxUPDATEYEAR.TabIndex = 8;
            // 
            // textBoxUPDATEID
            // 
            this.textBoxUPDATEID.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxUPDATEID.Location = new System.Drawing.Point(154, 24);
            this.textBoxUPDATEID.Name = "textBoxUPDATEID";
            this.textBoxUPDATEID.Size = new System.Drawing.Size(100, 20);
            this.textBoxUPDATEID.TabIndex = 10;
            // 
            // textBoxDELETEID
            // 
            this.textBoxDELETEID.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxDELETEID.Location = new System.Drawing.Point(128, 36);
            this.textBoxDELETEID.Name = "textBoxDELETEID";
            this.textBoxDELETEID.Size = new System.Drawing.Size(100, 20);
            this.textBoxDELETEID.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Название";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Автор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Количество страниц";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Год";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Название";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Автор";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Количество страниц";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Год";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(62, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Введите id";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // _319_6_Хисамутдинова_АлинаDataSet
            // 
            this._319_6_Хисамутдинова_АлинаDataSet.DataSetName = "_319_6_Хисамутдинова_АлинаDataSet";
            this._319_6_Хисамутдинова_АлинаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // библиотекаBindingSource
            // 
            this.библиотекаBindingSource.DataMember = "Библиотека";
            this.библиотекаBindingSource.DataSource = this._319_6_Хисамутдинова_АлинаDataSet;
            // 
            // библиотекаTableAdapter
            // 
            this.библиотекаTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // авторDataGridViewTextBoxColumn
            // 
            this.авторDataGridViewTextBoxColumn.DataPropertyName = "Автор";
            this.авторDataGridViewTextBoxColumn.HeaderText = "Автор";
            this.авторDataGridViewTextBoxColumn.Name = "авторDataGridViewTextBoxColumn";
            // 
            // количествоСтраницDataGridViewTextBoxColumn
            // 
            this.количествоСтраницDataGridViewTextBoxColumn.DataPropertyName = "количество страниц";
            this.количествоСтраницDataGridViewTextBoxColumn.HeaderText = "количество страниц";
            this.количествоСтраницDataGridViewTextBoxColumn.Name = "количествоСтраницDataGridViewTextBoxColumn";
            // 
            // годDataGridViewTextBoxColumn
            // 
            this.годDataGridViewTextBoxColumn.DataPropertyName = "год";
            this.годDataGridViewTextBoxColumn.HeaderText = "год";
            this.годDataGridViewTextBoxColumn.Name = "годDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(870, 421);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._319_6_Хисамутдинова_АлинаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.библиотекаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUPDATEID;
        private System.Windows.Forms.TextBox textBoxUPDATEYEAR;
        private System.Windows.Forms.TextBox textBoxUPDATEPAGES;
        private System.Windows.Forms.TextBox textBoxUPDATEAUTHOR;
        private System.Windows.Forms.TextBox textBoxUPDATENAME;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxADDAUTHOR;
        private System.Windows.Forms.TextBox textBoxADDPAGES;
        private System.Windows.Forms.TextBox textBoxADDYEAR;
        private System.Windows.Forms.TextBox textBoxADDNAME;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxDELETEID;
        private _319_6_Хисамутдинова_АлинаDataSet _319_6_Хисамутдинова_АлинаDataSet;
        private System.Windows.Forms.BindingSource библиотекаBindingSource;
        private _319_6_Хисамутдинова_АлинаDataSetTableAdapters.БиблиотекаTableAdapter библиотекаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn авторDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоСтраницDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годDataGridViewTextBoxColumn;
    }
}


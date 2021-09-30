namespace WindowsFormsApp1
{
    partial class Факультет_Предмет
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
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.факультетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предметToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.номерФакультетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеФакультетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.факультетBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._319_6_Хисамутдинова_АлинаDataSet3 = new WindowsFormsApp1._319_6_Хисамутдинова_АлинаDataSet3();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.факультетTableAdapter = new WindowsFormsApp1._319_6_Хисамутдинова_АлинаDataSet3TableAdapters.ФакультетTableAdapter();
            this._319_6_Хисамутдинова_АлинаDataSet4 = new WindowsFormsApp1._319_6_Хисамутдинова_АлинаDataSet4();
            this.предметBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.предметTableAdapter = new WindowsFormsApp1._319_6_Хисамутдинова_АлинаDataSet4TableAdapters.ПредметTableAdapter();
            this.номерПредметаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеПредметаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.факультетBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._319_6_Хисамутдинова_АлинаDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._319_6_Хисамутдинова_АлинаDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерПредметаDataGridViewTextBoxColumn,
            this.названиеПредметаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.предметBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 259);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 265);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(373, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 57);
            this.button2.TabIndex = 5;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.факультетToolStripMenuItem,
            this.предметToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(664, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // факультетToolStripMenuItem
            // 
            this.факультетToolStripMenuItem.Name = "факультетToolStripMenuItem";
            this.факультетToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.факультетToolStripMenuItem.Text = "Предмет";
            this.факультетToolStripMenuItem.Click += new System.EventHandler(this.факультетToolStripMenuItem_Click);
            // 
            // предметToolStripMenuItem
            // 
            this.предметToolStripMenuItem.Name = "предметToolStripMenuItem";
            this.предметToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.предметToolStripMenuItem.Text = "Факультет";
            this.предметToolStripMenuItem.Click += new System.EventHandler(this.предметToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(12, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 268);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(44, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 57);
            this.button3.TabIndex = 1;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерФакультетаDataGridViewTextBoxColumn,
            this.названиеФакультетаDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.факультетBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(358, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(244, 259);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // номерФакультетаDataGridViewTextBoxColumn
            // 
            this.номерФакультетаDataGridViewTextBoxColumn.DataPropertyName = "Номер факультета";
            this.номерФакультетаDataGridViewTextBoxColumn.HeaderText = "Номер факультета";
            this.номерФакультетаDataGridViewTextBoxColumn.Name = "номерФакультетаDataGridViewTextBoxColumn";
            // 
            // названиеФакультетаDataGridViewTextBoxColumn
            // 
            this.названиеФакультетаDataGridViewTextBoxColumn.DataPropertyName = "Название факультета";
            this.названиеФакультетаDataGridViewTextBoxColumn.HeaderText = "Название факультета";
            this.названиеФакультетаDataGridViewTextBoxColumn.Name = "названиеФакультетаDataGridViewTextBoxColumn";
            // 
            // факультетBindingSource
            // 
            this.факультетBindingSource.DataMember = "Факультет";
            this.факультетBindingSource.DataSource = this._319_6_Хисамутдинова_АлинаDataSet3;
            // 
            // _319_6_Хисамутдинова_АлинаDataSet3
            // 
            this._319_6_Хисамутдинова_АлинаDataSet3.DataSetName = "_319_6_Хисамутдинова_АлинаDataSet3";
            this._319_6_Хисамутдинова_АлинаDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(15, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "Студент";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(454, 336);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(195, 57);
            this.button4.TabIndex = 5;
            this.button4.Text = "Специальность";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(229, 336);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(219, 57);
            this.button5.TabIndex = 6;
            this.button5.Text = "Успеваемость";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // факультетTableAdapter
            // 
            this.факультетTableAdapter.ClearBeforeFill = true;
            // 
            // _319_6_Хисамутдинова_АлинаDataSet4
            // 
            this._319_6_Хисамутдинова_АлинаDataSet4.DataSetName = "_319_6_Хисамутдинова_АлинаDataSet4";
            this._319_6_Хисамутдинова_АлинаDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // предметBindingSource
            // 
            this.предметBindingSource.DataMember = "Предмет";
            this.предметBindingSource.DataSource = this._319_6_Хисамутдинова_АлинаDataSet4;
            // 
            // предметTableAdapter
            // 
            this.предметTableAdapter.ClearBeforeFill = true;
            // 
            // номерПредметаDataGridViewTextBoxColumn
            // 
            this.номерПредметаDataGridViewTextBoxColumn.DataPropertyName = "Номер предмета";
            this.номерПредметаDataGridViewTextBoxColumn.HeaderText = "Номер предмета";
            this.номерПредметаDataGridViewTextBoxColumn.Name = "номерПредметаDataGridViewTextBoxColumn";
            // 
            // названиеПредметаDataGridViewTextBoxColumn
            // 
            this.названиеПредметаDataGridViewTextBoxColumn.DataPropertyName = "Название предмета";
            this.названиеПредметаDataGridViewTextBoxColumn.HeaderText = "Название предмета";
            this.названиеПредметаDataGridViewTextBoxColumn.Name = "названиеПредметаDataGridViewTextBoxColumn";
            // 
            // Факультет_Предмет
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(664, 415);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Факультет_Предмет";
            this.Text = "Факультет_Предмет";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Факультет_Предмет_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.факультетBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._319_6_Хисамутдинова_АлинаDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._319_6_Хисамутдинова_АлинаDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem факультетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предметToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private _319_6_Хисамутдинова_АлинаDataSet3 _319_6_Хисамутдинова_АлинаDataSet3;
        private System.Windows.Forms.BindingSource факультетBindingSource;
        private _319_6_Хисамутдинова_АлинаDataSet3TableAdapters.ФакультетTableAdapter факультетTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерФакультетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеФакультетаDataGridViewTextBoxColumn;
        private _319_6_Хисамутдинова_АлинаDataSet4 _319_6_Хисамутдинова_АлинаDataSet4;
        private System.Windows.Forms.BindingSource предметBindingSource;
        private _319_6_Хисамутдинова_АлинаDataSet4TableAdapters.ПредметTableAdapter предметTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерПредметаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеПредметаDataGridViewTextBoxColumn;
    }
}


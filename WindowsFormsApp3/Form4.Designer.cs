namespace WindowsFormsApp3
{
    partial class Form4
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomerdogovoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vidachaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogovorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaDataSet2 = new WindowsFormsApp3.bazaDataSet2();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dogovorTableAdapter = new WindowsFormsApp3.bazaDataSet2TableAdapters.dogovorTableAdapter();
            this.shopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopTableAdapter = new WindowsFormsApp3.bazaDataSet2TableAdapters.shopTableAdapter();
            this.shopBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shopBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bazaDataSet3 = new WindowsFormsApp3.bazaDataSet3();
            this.shopBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.shopTableAdapter1 = new WindowsFormsApp3.bazaDataSet3TableAdapters.shopTableAdapter();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogovorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(609, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Заполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomerdogovoraDataGridViewTextBoxColumn,
            this.klientDataGridViewTextBoxColumn,
            this.chenaDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.vidachaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dogovorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 220);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nomerdogovoraDataGridViewTextBoxColumn
            // 
            this.nomerdogovoraDataGridViewTextBoxColumn.DataPropertyName = "nomerdogovora";
            this.nomerdogovoraDataGridViewTextBoxColumn.HeaderText = "Номер договора";
            this.nomerdogovoraDataGridViewTextBoxColumn.Name = "nomerdogovoraDataGridViewTextBoxColumn";
            // 
            // klientDataGridViewTextBoxColumn
            // 
            this.klientDataGridViewTextBoxColumn.DataPropertyName = "klient";
            this.klientDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.klientDataGridViewTextBoxColumn.Name = "klientDataGridViewTextBoxColumn";
            // 
            // chenaDataGridViewTextBoxColumn
            // 
            this.chenaDataGridViewTextBoxColumn.DataPropertyName = "chena";
            this.chenaDataGridViewTextBoxColumn.HeaderText = "цена";
            this.chenaDataGridViewTextBoxColumn.Name = "chenaDataGridViewTextBoxColumn";
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "product";
            this.productDataGridViewTextBoxColumn.HeaderText = "продукт";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            // 
            // vidachaDataGridViewTextBoxColumn
            // 
            this.vidachaDataGridViewTextBoxColumn.DataPropertyName = "vidacha";
            this.vidachaDataGridViewTextBoxColumn.HeaderText = "выдача";
            this.vidachaDataGridViewTextBoxColumn.Name = "vidachaDataGridViewTextBoxColumn";
            // 
            // dogovorBindingSource
            // 
            this.dogovorBindingSource.DataMember = "dogovor";
            this.dogovorBindingSource.DataSource = this.bazaDataSet2BindingSource;
            // 
            // bazaDataSet2BindingSource
            // 
            this.bazaDataSet2BindingSource.DataSource = this.bazaDataSet2;
            this.bazaDataSet2BindingSource.Position = 0;
            // 
            // bazaDataSet2
            // 
            this.bazaDataSet2.DataSetName = "bazaDataSet2";
            this.bazaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(709, 188);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(709, 124);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(709, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(709, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 20;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(709, 231);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 24;
            // 
            // dogovorTableAdapter
            // 
            this.dogovorTableAdapter.ClearBeforeFill = true;
            // 
            // shopBindingSource
            // 
            this.shopBindingSource.DataMember = "shop";
            this.shopBindingSource.DataSource = this.bazaDataSet2BindingSource;
            // 
            // shopTableAdapter
            // 
            this.shopTableAdapter.ClearBeforeFill = true;
            // 
            // shopBindingSource1
            // 
            this.shopBindingSource1.DataMember = "shop";
            this.shopBindingSource1.DataSource = this.bazaDataSet2BindingSource;
            // 
            // shopBindingSource2
            // 
            this.shopBindingSource2.DataMember = "shop";
            this.shopBindingSource2.DataSource = this.bazaDataSet2BindingSource;
            // 
            // bazaDataSet3
            // 
            this.bazaDataSet3.DataSetName = "bazaDataSet3";
            this.bazaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shopBindingSource3
            // 
            this.shopBindingSource3.DataMember = "shop";
            this.shopBindingSource3.DataSource = this.bazaDataSet3;
            // 
            // shopTableAdapter1
            // 
            this.shopTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(62, 292);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 25;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(210, 294);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "*";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(606, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "номер клиента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "клиент";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(606, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(606, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "выдача";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(606, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "продукт";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "калькулятор ";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.dogovorBindingSource;
            this.comboBox1.DisplayMember = "nomerdogovora";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(418, 268);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 35;
            this.comboBox1.ValueMember = "nomerdogovora";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(436, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 36;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 396);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogovorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.BindingSource bazaDataSet2BindingSource;
        private bazaDataSet2 bazaDataSet2;
        private System.Windows.Forms.BindingSource dogovorBindingSource;
        private bazaDataSet2TableAdapters.dogovorTableAdapter dogovorTableAdapter;
        private System.Windows.Forms.BindingSource shopBindingSource;
        private bazaDataSet2TableAdapters.shopTableAdapter shopTableAdapter;
        private System.Windows.Forms.BindingSource shopBindingSource1;
        private System.Windows.Forms.BindingSource shopBindingSource2;
        private bazaDataSet3 bazaDataSet3;
        private System.Windows.Forms.BindingSource shopBindingSource3;
        private bazaDataSet3TableAdapters.shopTableAdapter shopTableAdapter1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomerdogovoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vidachaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
    }
}
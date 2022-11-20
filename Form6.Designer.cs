
namespace WindowsFormsApp1
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDProdazitovaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Tovara = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.иС_магазин_одежды_для_молодежи_DataSet = new WindowsFormsApp1.ИС_магазин_одежды_для_молодежи_DataSet();
            this.ID_Brenda = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.брендBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ID_Klienta = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.клиентBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stoimostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skidochnaykartaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID_Skidki = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.скидкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.summachekaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Razmera_Odezdi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.размерBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID_Material = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.материалОдеждыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продажаТовараBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDKlientaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imiyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDBrendaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenovaniebrendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.брендBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продажа_товараTableAdapter = new WindowsFormsApp1.ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.Продажа_товараTableAdapter();
            this.клиентTableAdapter = new WindowsFormsApp1.ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.КлиентTableAdapter();
            this.брендTableAdapter = new WindowsFormsApp1.ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.БрендTableAdapter();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.товарTableAdapter = new WindowsFormsApp1.ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.ТоварTableAdapter();
            this.скидкаTableAdapter = new WindowsFormsApp1.ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.СкидкаTableAdapter();
            this.размерTableAdapter = new WindowsFormsApp1.ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.РазмерTableAdapter();
            this.материал_одеждыTableAdapter = new WindowsFormsApp1.ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.Материал_одеждыTableAdapter();
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.иС_магазин_одежды_для_молодежи_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.брендBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.скидкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.размерBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалОдеждыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажаТовараBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.брендBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProdazitovaraDataGridViewTextBoxColumn,
            this.ID_Tovara,
            this.ID_Brenda,
            this.ID_Klienta,
            this.stoimostDataGridViewTextBoxColumn,
            this.skidochnaykartaDataGridViewCheckBoxColumn,
            this.ID_Skidki,
            this.summachekaDataGridViewTextBoxColumn,
            this.ID_Razmera_Odezdi,
            this.ID_Material});
            this.dataGridView1.DataSource = this.продажаТовараBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1043, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // iDProdazitovaraDataGridViewTextBoxColumn
            // 
            this.iDProdazitovaraDataGridViewTextBoxColumn.DataPropertyName = "ID_Prodazi_tovara";
            this.iDProdazitovaraDataGridViewTextBoxColumn.HeaderText = "ID_Prodazi_tovara";
            this.iDProdazitovaraDataGridViewTextBoxColumn.Name = "iDProdazitovaraDataGridViewTextBoxColumn";
            // 
            // ID_Tovara
            // 
            this.ID_Tovara.DataPropertyName = "ID_Tovara";
            this.ID_Tovara.DataSource = this.товарBindingSource;
            this.ID_Tovara.DisplayMember = "Naimenovanie_tovara";
            this.ID_Tovara.HeaderText = "ID_Tovara";
            this.ID_Tovara.Name = "ID_Tovara";
            this.ID_Tovara.ValueMember = "ID_Tovara";
            // 
            // товарBindingSource
            // 
            this.товарBindingSource.DataMember = "Товар";
            this.товарBindingSource.DataSource = this.иС_магазин_одежды_для_молодежи_DataSet;
            // 
            // иС_магазин_одежды_для_молодежи_DataSet
            // 
            this.иС_магазин_одежды_для_молодежи_DataSet.DataSetName = "ИС_магазин_одежды_для_молодежи_DataSet";
            this.иС_магазин_одежды_для_молодежи_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ID_Brenda
            // 
            this.ID_Brenda.DataPropertyName = "ID_Brenda";
            this.ID_Brenda.DataSource = this.брендBindingSource1;
            this.ID_Brenda.DisplayMember = "Naimenovanie_brenda";
            this.ID_Brenda.HeaderText = "ID_Brenda";
            this.ID_Brenda.Name = "ID_Brenda";
            this.ID_Brenda.ValueMember = "ID_Brenda";
            // 
            // брендBindingSource1
            // 
            this.брендBindingSource1.DataMember = "Бренд";
            this.брендBindingSource1.DataSource = this.иС_магазин_одежды_для_молодежи_DataSet;
            // 
            // ID_Klienta
            // 
            this.ID_Klienta.DataPropertyName = "ID_Klienta";
            this.ID_Klienta.DataSource = this.клиентBindingSource1;
            this.ID_Klienta.DisplayMember = "Imiya";
            this.ID_Klienta.HeaderText = "ID_Klienta";
            this.ID_Klienta.Name = "ID_Klienta";
            this.ID_Klienta.ValueMember = "ID_Klienta";
            // 
            // клиентBindingSource1
            // 
            this.клиентBindingSource1.DataMember = "Клиент";
            this.клиентBindingSource1.DataSource = this.иС_магазин_одежды_для_молодежи_DataSet;
            // 
            // stoimostDataGridViewTextBoxColumn
            // 
            this.stoimostDataGridViewTextBoxColumn.DataPropertyName = "Stoimost";
            this.stoimostDataGridViewTextBoxColumn.HeaderText = "Stoimost";
            this.stoimostDataGridViewTextBoxColumn.Name = "stoimostDataGridViewTextBoxColumn";
            // 
            // skidochnaykartaDataGridViewCheckBoxColumn
            // 
            this.skidochnaykartaDataGridViewCheckBoxColumn.DataPropertyName = "Skidochnay_karta";
            this.skidochnaykartaDataGridViewCheckBoxColumn.HeaderText = "Skidochnay_karta";
            this.skidochnaykartaDataGridViewCheckBoxColumn.Name = "skidochnaykartaDataGridViewCheckBoxColumn";
            // 
            // ID_Skidki
            // 
            this.ID_Skidki.DataPropertyName = "ID_Skidki";
            this.ID_Skidki.DataSource = this.скидкаBindingSource;
            this.ID_Skidki.DisplayMember = "Razmer_Skidki";
            this.ID_Skidki.HeaderText = "ID_Skidki";
            this.ID_Skidki.Name = "ID_Skidki";
            this.ID_Skidki.ValueMember = "ID_Skidki";
            // 
            // скидкаBindingSource
            // 
            this.скидкаBindingSource.DataMember = "Скидка";
            this.скидкаBindingSource.DataSource = this.иС_магазин_одежды_для_молодежи_DataSet;
            // 
            // summachekaDataGridViewTextBoxColumn
            // 
            this.summachekaDataGridViewTextBoxColumn.DataPropertyName = "Summa_cheka";
            this.summachekaDataGridViewTextBoxColumn.HeaderText = "Summa_cheka";
            this.summachekaDataGridViewTextBoxColumn.Name = "summachekaDataGridViewTextBoxColumn";
            // 
            // ID_Razmera_Odezdi
            // 
            this.ID_Razmera_Odezdi.DataPropertyName = "ID_Razmera_Odezdi";
            this.ID_Razmera_Odezdi.DataSource = this.размерBindingSource;
            this.ID_Razmera_Odezdi.DisplayMember = "Razmer";
            this.ID_Razmera_Odezdi.HeaderText = "ID_Razmera_Odezdi";
            this.ID_Razmera_Odezdi.Name = "ID_Razmera_Odezdi";
            this.ID_Razmera_Odezdi.ValueMember = "ID_Razmera_Odezdi";
            // 
            // размерBindingSource
            // 
            this.размерBindingSource.DataMember = "Размер";
            this.размерBindingSource.DataSource = this.иС_магазин_одежды_для_молодежи_DataSet;
            // 
            // ID_Material
            // 
            this.ID_Material.DataPropertyName = "ID_Material";
            this.ID_Material.DataSource = this.материалОдеждыBindingSource;
            this.ID_Material.DisplayMember = "Material";
            this.ID_Material.HeaderText = "ID_Material";
            this.ID_Material.Name = "ID_Material";
            this.ID_Material.ValueMember = "ID_Materiala_Odezdi";
            // 
            // материалОдеждыBindingSource
            // 
            this.материалОдеждыBindingSource.DataMember = "Материал одежды";
            this.материалОдеждыBindingSource.DataSource = this.иС_магазин_одежды_для_молодежи_DataSet;
            // 
            // продажаТовараBindingSource
            // 
            this.продажаТовараBindingSource.DataMember = "Продажа товара";
            this.продажаТовараBindingSource.DataSource = this.иС_магазин_одежды_для_молодежи_DataSet;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDKlientaDataGridViewTextBoxColumn1,
            this.imiyaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.клиентBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 213);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1043, 150);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView2_UserDeletingRow);
            // 
            // iDKlientaDataGridViewTextBoxColumn1
            // 
            this.iDKlientaDataGridViewTextBoxColumn1.DataPropertyName = "ID_Klienta";
            this.iDKlientaDataGridViewTextBoxColumn1.HeaderText = "ID_Klienta";
            this.iDKlientaDataGridViewTextBoxColumn1.Name = "iDKlientaDataGridViewTextBoxColumn1";
            // 
            // imiyaDataGridViewTextBoxColumn
            // 
            this.imiyaDataGridViewTextBoxColumn.DataPropertyName = "Imiya";
            this.imiyaDataGridViewTextBoxColumn.HeaderText = "Imiya";
            this.imiyaDataGridViewTextBoxColumn.Name = "imiyaDataGridViewTextBoxColumn";
            // 
            // клиентBindingSource
            // 
            this.клиентBindingSource.DataMember = "Клиент";
            this.клиентBindingSource.DataSource = this.иС_магазин_одежды_для_молодежи_DataSet;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDBrendaDataGridViewTextBoxColumn1,
            this.naimenovaniebrendaDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.брендBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 429);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1043, 150);
            this.dataGridView3.TabIndex = 2;
            this.dataGridView3.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView3_UserDeletingRow);
            // 
            // iDBrendaDataGridViewTextBoxColumn1
            // 
            this.iDBrendaDataGridViewTextBoxColumn1.DataPropertyName = "ID_Brenda";
            this.iDBrendaDataGridViewTextBoxColumn1.HeaderText = "ID_Brenda";
            this.iDBrendaDataGridViewTextBoxColumn1.Name = "iDBrendaDataGridViewTextBoxColumn1";
            // 
            // naimenovaniebrendaDataGridViewTextBoxColumn
            // 
            this.naimenovaniebrendaDataGridViewTextBoxColumn.DataPropertyName = "Naimenovanie_brenda";
            this.naimenovaniebrendaDataGridViewTextBoxColumn.HeaderText = "Naimenovanie_brenda";
            this.naimenovaniebrendaDataGridViewTextBoxColumn.Name = "naimenovaniebrendaDataGridViewTextBoxColumn";
            // 
            // брендBindingSource
            // 
            this.брендBindingSource.DataMember = "Бренд";
            this.брендBindingSource.DataSource = this.иС_магазин_одежды_для_молодежи_DataSet;
            // 
            // продажа_товараTableAdapter
            // 
            this.продажа_товараTableAdapter.ClearBeforeFill = true;
            // 
            // клиентTableAdapter
            // 
            this.клиентTableAdapter.ClearBeforeFill = true;
            // 
            // брендTableAdapter
            // 
            this.брендTableAdapter.ClearBeforeFill = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(93, 168);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 15;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(174, 168);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "Поиск";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 369);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(93, 585);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(174, 585);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 20;
            this.button8.Text = "Поиск";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 585);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 19;
            this.button9.Text = "Добавить";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // товарTableAdapter
            // 
            this.товарTableAdapter.ClearBeforeFill = true;
            // 
            // скидкаTableAdapter
            // 
            this.скидкаTableAdapter.ClearBeforeFill = true;
            // 
            // размерTableAdapter
            // 
            this.размерTableAdapter.ClearBeforeFill = true;
            // 
            // материал_одеждыTableAdapter
            // 
            this.материал_одеждыTableAdapter.ClearBeforeFill = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(1097, 213);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(226, 150);
            this.button10.TabIndex = 22;
            this.button10.Text = "Переход к следующей подсистеме";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.maxresdefault;
            this.ClientSize = new System.Drawing.Size(1361, 678);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "Продажа товара";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.иС_магазин_одежды_для_молодежи_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.брендBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.скидкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.размерBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалОдеждыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажаТовараBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.брендBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.DataGridView dataGridView3;
        public ИС_магазин_одежды_для_молодежи_DataSet иС_магазин_одежды_для_молодежи_DataSet;
        public System.Windows.Forms.BindingSource продажаТовараBindingSource;
        public ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.Продажа_товараTableAdapter продажа_товараTableAdapter;
        public System.Windows.Forms.BindingSource клиентBindingSource;
        public ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKlientaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn imiyaDataGridViewTextBoxColumn;
        public System.Windows.Forms.BindingSource брендBindingSource;
        public ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.БрендTableAdapter брендTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBrendaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovaniebrendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.BindingSource товарBindingSource;
        private ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.ТоварTableAdapter товарTableAdapter;
        private System.Windows.Forms.BindingSource брендBindingSource1;
        private System.Windows.Forms.BindingSource клиентBindingSource1;
        private System.Windows.Forms.BindingSource скидкаBindingSource;
        private ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.СкидкаTableAdapter скидкаTableAdapter;
        private System.Windows.Forms.BindingSource размерBindingSource;
        private ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.РазмерTableAdapter размерTableAdapter;
        private System.Windows.Forms.BindingSource материалОдеждыBindingSource;
        private ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.Материал_одеждыTableAdapter материал_одеждыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProdazitovaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Tovara;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Brenda;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Klienta;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoimostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn skidochnaykartaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Skidki;
        private System.Windows.Forms.DataGridViewTextBoxColumn summachekaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Razmera_Odezdi;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Material;
        private System.Windows.Forms.Button button10;
    }
}
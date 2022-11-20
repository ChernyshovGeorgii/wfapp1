
namespace WindowsFormsApp1
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.учетТовараBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.иС_магазин_одежды_для_молодежи_DataSet = new WindowsFormsApp1.ИС_магазин_одежды_для_молодежи_DataSet();
            this.учет_товараTableAdapter = new WindowsFormsApp1.ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.Учет_товараTableAdapter();
            this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарTableAdapter = new WindowsFormsApp1.ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.ТоварTableAdapter();
            this.брендBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.брендTableAdapter = new WindowsFormsApp1.ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.БрендTableAdapter();
            this.размерBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.размерTableAdapter = new WindowsFormsApp1.ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.РазмерTableAdapter();
            this.iDUchetatovaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvoprodannihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvoostavshegosiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaprodannogoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaostavshegosiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Tovara = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ID_Brenda = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ID_Razmer_odezdi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетТовараBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.иС_магазин_одежды_для_молодежи_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.брендBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.размерBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(93, 178);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 20;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(174, 178);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 19;
            this.button6.Text = "Поиск";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 178);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDUchetatovaraDataGridViewTextBoxColumn,
            this.kolvoprodannihDataGridViewTextBoxColumn,
            this.kolvoostavshegosiDataGridViewTextBoxColumn,
            this.summaprodannogoDataGridViewTextBoxColumn,
            this.summaostavshegosiDataGridViewTextBoxColumn,
            this.ID_Tovara,
            this.ID_Brenda,
            this.ID_Razmer_odezdi});
            this.dataGridView3.DataSource = this.учетТовараBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 22);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(847, 150);
            this.dataGridView3.TabIndex = 15;
            this.dataGridView3.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView3_UserDeletingRow);
            // 
            // учетТовараBindingSource
            // 
            this.учетТовараBindingSource.DataMember = "Учет товара";
            this.учетТовараBindingSource.DataSource = this.иС_магазин_одежды_для_молодежи_DataSet;
            // 
            // иС_магазин_одежды_для_молодежи_DataSet
            // 
            this.иС_магазин_одежды_для_молодежи_DataSet.DataSetName = "ИС_магазин_одежды_для_молодежи_DataSet";
            this.иС_магазин_одежды_для_молодежи_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // учет_товараTableAdapter
            // 
            this.учет_товараTableAdapter.ClearBeforeFill = true;
            // 
            // товарBindingSource
            // 
            this.товарBindingSource.DataMember = "Товар";
            this.товарBindingSource.DataSource = this.иС_магазин_одежды_для_молодежи_DataSet;
            // 
            // товарTableAdapter
            // 
            this.товарTableAdapter.ClearBeforeFill = true;
            // 
            // брендBindingSource
            // 
            this.брендBindingSource.DataMember = "Бренд";
            this.брендBindingSource.DataSource = this.иС_магазин_одежды_для_молодежи_DataSet;
            // 
            // брендTableAdapter
            // 
            this.брендTableAdapter.ClearBeforeFill = true;
            // 
            // размерBindingSource
            // 
            this.размерBindingSource.DataMember = "Размер";
            this.размерBindingSource.DataSource = this.иС_магазин_одежды_для_молодежи_DataSet;
            // 
            // размерTableAdapter
            // 
            this.размерTableAdapter.ClearBeforeFill = true;
            // 
            // iDUchetatovaraDataGridViewTextBoxColumn
            // 
            this.iDUchetatovaraDataGridViewTextBoxColumn.DataPropertyName = "ID_Ucheta_tovara";
            this.iDUchetatovaraDataGridViewTextBoxColumn.HeaderText = "ID_Ucheta_tovara";
            this.iDUchetatovaraDataGridViewTextBoxColumn.Name = "iDUchetatovaraDataGridViewTextBoxColumn";
            // 
            // kolvoprodannihDataGridViewTextBoxColumn
            // 
            this.kolvoprodannihDataGridViewTextBoxColumn.DataPropertyName = "Kol-vo_prodannih";
            this.kolvoprodannihDataGridViewTextBoxColumn.HeaderText = "Kol-vo_prodannih";
            this.kolvoprodannihDataGridViewTextBoxColumn.Name = "kolvoprodannihDataGridViewTextBoxColumn";
            // 
            // kolvoostavshegosiDataGridViewTextBoxColumn
            // 
            this.kolvoostavshegosiDataGridViewTextBoxColumn.DataPropertyName = "Kol-vo_ostavshegosi";
            this.kolvoostavshegosiDataGridViewTextBoxColumn.HeaderText = "Kol-vo_ostavshegosi";
            this.kolvoostavshegosiDataGridViewTextBoxColumn.Name = "kolvoostavshegosiDataGridViewTextBoxColumn";
            // 
            // summaprodannogoDataGridViewTextBoxColumn
            // 
            this.summaprodannogoDataGridViewTextBoxColumn.DataPropertyName = "Summa_prodannogo";
            this.summaprodannogoDataGridViewTextBoxColumn.HeaderText = "Summa_prodannogo";
            this.summaprodannogoDataGridViewTextBoxColumn.Name = "summaprodannogoDataGridViewTextBoxColumn";
            // 
            // summaostavshegosiDataGridViewTextBoxColumn
            // 
            this.summaostavshegosiDataGridViewTextBoxColumn.DataPropertyName = "Summa_ostavshegosi";
            this.summaostavshegosiDataGridViewTextBoxColumn.HeaderText = "Summa_ostavshegosi";
            this.summaostavshegosiDataGridViewTextBoxColumn.Name = "summaostavshegosiDataGridViewTextBoxColumn";
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
            // ID_Brenda
            // 
            this.ID_Brenda.DataPropertyName = "ID_Brenda";
            this.ID_Brenda.DataSource = this.брендBindingSource;
            this.ID_Brenda.DisplayMember = "Naimenovanie_brenda";
            this.ID_Brenda.HeaderText = "ID_Brenda";
            this.ID_Brenda.Name = "ID_Brenda";
            this.ID_Brenda.ValueMember = "ID_Brenda";
            // 
            // ID_Razmer_odezdi
            // 
            this.ID_Razmer_odezdi.DataPropertyName = "ID_Razmer_odezdi";
            this.ID_Razmer_odezdi.DataSource = this.размерBindingSource;
            this.ID_Razmer_odezdi.DisplayMember = "Razmer";
            this.ID_Razmer_odezdi.HeaderText = "ID_Razmer_odezdi";
            this.ID_Razmer_odezdi.Name = "ID_Razmer_odezdi";
            this.ID_Razmer_odezdi.ValueMember = "ID_Razmera_Odezdi";
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.maxresdefault;
            this.ClientSize = new System.Drawing.Size(984, 534);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form12";
            this.Text = "Учет товара";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетТовараBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.иС_магазин_одежды_для_молодежи_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.брендBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.размерBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.DataGridView dataGridView3;
        public ИС_магазин_одежды_для_молодежи_DataSet иС_магазин_одежды_для_молодежи_DataSet;
        public System.Windows.Forms.BindingSource учетТовараBindingSource;
        public ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.Учет_товараTableAdapter учет_товараTableAdapter;
        private System.Windows.Forms.BindingSource товарBindingSource;
        private ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.ТоварTableAdapter товарTableAdapter;
        private System.Windows.Forms.BindingSource брендBindingSource;
        private ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.БрендTableAdapter брендTableAdapter;
        private System.Windows.Forms.BindingSource размерBindingSource;
        private ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.РазмерTableAdapter размерTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUchetatovaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvoprodannihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvoostavshegosiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaprodannogoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaostavshegosiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Tovara;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Brenda;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Razmer_odezdi;
    }
}

namespace WindowsFormsApp1
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.продажаТовараBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.иС_магазин_одежды_для_молодежи_DataSet = new WindowsFormsApp1.ИС_магазин_одежды_для_молодежи_DataSet();
            this.материалОдеждыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.размерBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.скидкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.продажаТовараBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.брендBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.товарTableAdapter = new WindowsFormsApp1.ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.ТоварTableAdapter();
            this.продажа_товараTableAdapter = new WindowsFormsApp1.ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.Продажа_товараTableAdapter();
            this.брендTableAdapter = new WindowsFormsApp1.ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.БрендTableAdapter();
            this.клиентTableAdapter = new WindowsFormsApp1.ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.КлиентTableAdapter();
            this.скидкаTableAdapter = new WindowsFormsApp1.ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.СкидкаTableAdapter();
            this.размерTableAdapter = new WindowsFormsApp1.ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.РазмерTableAdapter();
            this.материал_одеждыTableAdapter = new WindowsFormsApp1.ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.Материал_одеждыTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.продажаТовараBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.иС_магазин_одежды_для_молодежи_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалОдеждыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.размерBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.скидкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажаТовараBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.брендBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(547, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox6);
            this.groupBox2.Controls.Add(this.comboBox7);
            this.groupBox2.Controls.Add(this.comboBox8);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(202, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 262);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавление проданного товара";
            // 
            // comboBox6
            // 
            this.comboBox6.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.продажаТовараBindingSource, "ID_Material", true));
            this.comboBox6.DataSource = this.материалОдеждыBindingSource;
            this.comboBox6.DisplayMember = "Material";
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(131, 230);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(263, 24);
            this.comboBox6.TabIndex = 24;
            this.comboBox6.ValueMember = "ID_Materiala_Odezdi";
            // 
            // продажаТовараBindingSource
            // 
            this.продажаТовараBindingSource.DataMember = "Продажа товара";
            this.продажаТовараBindingSource.DataSource = this.иС_магазин_одежды_для_молодежи_DataSet;
            // 
            // иС_магазин_одежды_для_молодежи_DataSet
            // 
            this.иС_магазин_одежды_для_молодежи_DataSet.DataSetName = "ИС_магазин_одежды_для_молодежи_DataSet";
            this.иС_магазин_одежды_для_молодежи_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // материалОдеждыBindingSource
            // 
            this.материалОдеждыBindingSource.DataMember = "Материал одежды";
            this.материалОдеждыBindingSource.DataSource = this.иС_магазин_одежды_для_молодежи_DataSet;
            // 
            // comboBox7
            // 
            this.comboBox7.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.продажаТовараBindingSource, "ID_Razmera_Odezdi", true));
            this.comboBox7.DataSource = this.размерBindingSource;
            this.comboBox7.DisplayMember = "Razmer";
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(131, 204);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(263, 24);
            this.comboBox7.TabIndex = 23;
            this.comboBox7.ValueMember = "ID_Razmera_Odezdi";
            // 
            // размерBindingSource
            // 
            this.размерBindingSource.DataMember = "Размер";
            this.размерBindingSource.DataSource = this.иС_магазин_одежды_для_молодежи_DataSet;
            // 
            // comboBox8
            // 
            this.comboBox8.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.продажаТовараBindingSource, "ID_Skidki", true));
            this.comboBox8.DataSource = this.скидкаBindingSource;
            this.comboBox8.DisplayMember = "Razmer_Skidki";
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(131, 152);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(263, 24);
            this.comboBox8.TabIndex = 22;
            this.comboBox8.ValueMember = "ID_Skidki";
            // 
            // скидкаBindingSource
            // 
            this.скидкаBindingSource.DataMember = "Скидка";
            this.скидкаBindingSource.DataSource = this.иС_магазин_одежды_для_молодежи_DataSet;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(131, 101);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(263, 22);
            this.textBox9.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Материал";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Размер одежды\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 22);
            this.textBox1.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Сумма чека\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Скидка\r\n";
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.продажаТовараBindingSource, "Skidochnay_karta", true));
            this.comboBox4.DataSource = this.продажаТовараBindingSource1;
            this.comboBox4.DisplayMember = "Skidochnay_karta";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(131, 125);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(263, 24);
            this.comboBox4.TabIndex = 15;
            this.comboBox4.ValueMember = "Skidochnay_karta";
            // 
            // продажаТовараBindingSource1
            // 
            this.продажаТовараBindingSource1.DataMember = "Продажа товара";
            this.продажаТовараBindingSource1.DataSource = this.иС_магазин_одежды_для_молодежи_DataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.продажаТовараBindingSource, "ID_Klienta", true));
            this.comboBox3.DataSource = this.клиентBindingSource;
            this.comboBox3.DisplayMember = "Imiya";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(131, 73);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(263, 24);
            this.comboBox3.TabIndex = 14;
            this.comboBox3.ValueMember = "ID_Klienta";
            // 
            // клиентBindingSource
            // 
            this.клиентBindingSource.DataMember = "Клиент";
            this.клиентBindingSource.DataSource = this.иС_магазин_одежды_для_молодежи_DataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.продажаТовараBindingSource, "ID_Brenda", true));
            this.comboBox2.DataSource = this.брендBindingSource;
            this.comboBox2.DisplayMember = "Naimenovanie_brenda";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(131, 47);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(263, 24);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.ValueMember = "ID_Brenda";
            // 
            // брендBindingSource
            // 
            this.брендBindingSource.DataMember = "Бренд";
            this.брендBindingSource.DataSource = this.иС_магазин_одежды_для_молодежи_DataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.продажаТовараBindingSource, "ID_Tovara", true));
            this.comboBox1.DataSource = this.товарBindingSource;
            this.comboBox1.DisplayMember = "Naimenovanie_tovara";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(131, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(263, 24);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.ValueMember = "ID_Tovara";
            // 
            // товарBindingSource
            // 
            this.товарBindingSource.DataMember = "Товар";
            this.товарBindingSource.DataSource = this.иС_магазин_одежды_для_молодежи_DataSet;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Скидочная карта\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Стоимость\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Клиент\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Бренд\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Товар\r\n\r\n";
            // 
            // товарTableAdapter
            // 
            this.товарTableAdapter.ClearBeforeFill = true;
            // 
            // продажа_товараTableAdapter
            // 
            this.продажа_товараTableAdapter.ClearBeforeFill = true;
            // 
            // брендTableAdapter
            // 
            this.брендTableAdapter.ClearBeforeFill = true;
            // 
            // клиентTableAdapter
            // 
            this.клиентTableAdapter.ClearBeforeFill = true;
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
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Добавление";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.продажаТовараBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.иС_магазин_одежды_для_молодежи_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалОдеждыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.размерBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.скидкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажаТовараBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.брендBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ComboBox comboBox6;
        public System.Windows.Forms.ComboBox comboBox7;
        public System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox comboBox4;
        public System.Windows.Forms.ComboBox comboBox3;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private ИС_магазин_одежды_для_молодежи_DataSet иС_магазин_одежды_для_молодежи_DataSet;
        private System.Windows.Forms.BindingSource товарBindingSource;
        private ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.ТоварTableAdapter товарTableAdapter;
        private System.Windows.Forms.BindingSource продажаТовараBindingSource;
        private ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.Продажа_товараTableAdapter продажа_товараTableAdapter;
        private System.Windows.Forms.BindingSource брендBindingSource;
        private ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.БрендTableAdapter брендTableAdapter;
        private System.Windows.Forms.BindingSource клиентBindingSource;
        private ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
        private System.Windows.Forms.BindingSource продажаТовараBindingSource1;
        private System.Windows.Forms.BindingSource скидкаBindingSource;
        private ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.СкидкаTableAdapter скидкаTableAdapter;
        private System.Windows.Forms.BindingSource размерBindingSource;
        private ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.РазмерTableAdapter размерTableAdapter;
        private System.Windows.Forms.BindingSource материалОдеждыBindingSource;
        private ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.Материал_одеждыTableAdapter материал_одеждыTableAdapter;
    }
}
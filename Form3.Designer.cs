
namespace WindowsFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.таргетированнаяРекламаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.иС_магазин_одежды_для_молодежи_DataSet = new WindowsFormsApp1.ИС_магазин_одежды_для_молодежи_DataSet();
            this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.типBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.таргетологBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.социальнаяСетьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.социальная_сетьTableAdapter = new WindowsFormsApp1.ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.Социальная_сетьTableAdapter();
            this.таргетированная_рекламаTableAdapter = new WindowsFormsApp1.ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.Таргетированная_рекламаTableAdapter();
            this.таргетологTableAdapter = new WindowsFormsApp1.ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.ТаргетологTableAdapter();
            this.типTableAdapter = new WindowsFormsApp1.ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.ТипTableAdapter();
            this.товарTableAdapter = new WindowsFormsApp1.ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.ТоварTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.таргетированнаяРекламаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.иС_магазин_одежды_для_молодежи_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.таргетологBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.социальнаяСетьBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(190, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 166);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавление рекламы";
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.таргетированнаяРекламаBindingSource, "ID_Tovara", true));
            this.comboBox4.DataSource = this.товарBindingSource;
            this.comboBox4.DisplayMember = "Naimenovanie_tovara";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(131, 125);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(263, 24);
            this.comboBox4.TabIndex = 15;
            this.comboBox4.ValueMember = "ID_Tovara";
            // 
            // таргетированнаяРекламаBindingSource
            // 
            this.таргетированнаяРекламаBindingSource.DataMember = "Таргетированная реклама";
            this.таргетированнаяРекламаBindingSource.DataSource = this.иС_магазин_одежды_для_молодежи_DataSet;
            // 
            // иС_магазин_одежды_для_молодежи_DataSet
            // 
            this.иС_магазин_одежды_для_молодежи_DataSet.DataSetName = "ИС_магазин_одежды_для_молодежи_DataSet";
            this.иС_магазин_одежды_для_молодежи_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // товарBindingSource
            // 
            this.товарBindingSource.DataMember = "Товар";
            this.товарBindingSource.DataSource = this.иС_магазин_одежды_для_молодежи_DataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.таргетированнаяРекламаBindingSource, "ID_Tipa", true));
            this.comboBox3.DataSource = this.типBindingSource;
            this.comboBox3.DisplayMember = "Tip_reklami";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(131, 99);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(263, 24);
            this.comboBox3.TabIndex = 14;
            this.comboBox3.ValueMember = "ID_Tipa";
            // 
            // типBindingSource
            // 
            this.типBindingSource.DataMember = "Тип";
            this.типBindingSource.DataSource = this.иС_магазин_одежды_для_молодежи_DataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.таргетированнаяРекламаBindingSource, "ID_Targetologa", true));
            this.comboBox2.DataSource = this.таргетологBindingSource;
            this.comboBox2.DisplayMember = "Familia";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(131, 73);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(263, 24);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.ValueMember = "ID_Targetologa";
            // 
            // таргетологBindingSource
            // 
            this.таргетологBindingSource.DataMember = "Таргетолог";
            this.таргетологBindingSource.DataSource = this.иС_магазин_одежды_для_молодежи_DataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.таргетированнаяРекламаBindingSource, "ID_Socialnoi_seti", true));
            this.comboBox1.DataSource = this.социальнаяСетьBindingSource;
            this.comboBox1.DisplayMember = "Naimenovanie";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(131, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(263, 24);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.ValueMember = "ID_Socialnoi_seti";
            // 
            // социальнаяСетьBindingSource
            // 
            this.социальнаяСетьBindingSource.DataMember = "Социальная сеть";
            this.социальнаяСетьBindingSource.DataSource = this.иС_магазин_одежды_для_молодежи_DataSet;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Товар";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Тип";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Фамилия";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(131, 49);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(263, 22);
            this.textBox9.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Стоимость работ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Социальная сеть";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // социальная_сетьTableAdapter
            // 
            this.социальная_сетьTableAdapter.ClearBeforeFill = true;
            // 
            // таргетированная_рекламаTableAdapter
            // 
            this.таргетированная_рекламаTableAdapter.ClearBeforeFill = true;
            // 
            // таргетологTableAdapter
            // 
            this.таргетологTableAdapter.ClearBeforeFill = true;
            // 
            // типTableAdapter
            // 
            this.типTableAdapter.ClearBeforeFill = true;
            // 
            // товарTableAdapter
            // 
            this.товарTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(535, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Добавление";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.таргетированнаяРекламаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.иС_магазин_одежды_для_молодежи_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.таргетологBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.социальнаяСетьBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.Button button1;
        private ИС_магазин_одежды_для_молодежи_DataSet иС_магазин_одежды_для_молодежи_DataSet;
        private System.Windows.Forms.BindingSource социальнаяСетьBindingSource;
        private ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.Социальная_сетьTableAdapter социальная_сетьTableAdapter;
        private System.Windows.Forms.BindingSource таргетированнаяРекламаBindingSource;
        private ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.Таргетированная_рекламаTableAdapter таргетированная_рекламаTableAdapter;
        private System.Windows.Forms.BindingSource таргетологBindingSource;
        private ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.ТаргетологTableAdapter таргетологTableAdapter;
        private System.Windows.Forms.BindingSource типBindingSource;
        private ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.ТипTableAdapter типTableAdapter;
        private System.Windows.Forms.BindingSource товарBindingSource;
        private ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.ТоварTableAdapter товарTableAdapter;
        private System.Windows.Forms.Button button2;
    }
}
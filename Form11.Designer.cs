
namespace WindowsFormsApp1
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.иС_магазин_одежды_для_молодежи_DataSet = new WindowsFormsApp1.ИС_магазин_одежды_для_молодежи_DataSet();
            this.брендBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.брендTableAdapter = new WindowsFormsApp1.ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.БрендTableAdapter();
            this.брендBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.иС_магазин_одежды_для_молодежи_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.брендBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.брендBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(190, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox11);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(190, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 181);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Добавление бренда";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(6, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Бренд\r\n";
            // 
            // иС_магазин_одежды_для_молодежи_DataSet
            // 
            this.иС_магазин_одежды_для_молодежи_DataSet.DataSetName = "ИС_магазин_одежды_для_молодежи_DataSet";
            this.иС_магазин_одежды_для_молодежи_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // брендBindingSource1
            // 
            this.брендBindingSource1.DataMember = "Бренд";
            this.брендBindingSource1.DataSource = this.иС_магазин_одежды_для_молодежи_DataSet;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(125, 67);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(268, 22);
            this.textBox11.TabIndex = 11;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form11";
            this.Text = "Добавление";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.иС_магазин_одежды_для_молодежи_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.брендBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.брендBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private ИС_магазин_одежды_для_молодежи_DataSet иС_магазин_одежды_для_молодежи_DataSet;
        private System.Windows.Forms.BindingSource брендBindingSource;
        private ИС_магазин_одежды_для_молодежи_DataSetTableAdapters.БрендTableAdapter брендTableAdapter;
        private System.Windows.Forms.BindingSource брендBindingSource1;
        private System.Windows.Forms.TextBox textBox11;
    }
}
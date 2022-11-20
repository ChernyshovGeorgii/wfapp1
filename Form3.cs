using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                DataRow nRow = main.иС_магазин_одежды_для_молодежи_DataSet.Tables[7].NewRow();
                int rc = main.dataGridView1.RowCount + 0;
                nRow[0] = rc;
                nRow[2] = textBox9.Text;
                nRow[1] = comboBox1.SelectedValue;
                nRow[3] = comboBox2.SelectedValue;
                nRow[4] = comboBox3.SelectedValue;
                nRow[5] = comboBox4.SelectedValue;
                main.иС_магазин_одежды_для_молодежи_DataSet.Tables[7].Rows.Add(nRow);
                main.таргетированная_рекламаTableAdapter.Update(main.иС_магазин_одежды_для_молодежи_DataSet.Таргетированная_реклама);
                main.иС_магазин_одежды_для_молодежи_DataSet.Tables[7].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox9.Text = "";
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иС_магазин_одежды_для_молодежи_DataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.иС_магазин_одежды_для_молодежи_DataSet.Товар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иС_магазин_одежды_для_молодежи_DataSet.Тип". При необходимости она может быть перемещена или удалена.
            this.типTableAdapter.Fill(this.иС_магазин_одежды_для_молодежи_DataSet.Тип);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иС_магазин_одежды_для_молодежи_DataSet.Таргетолог". При необходимости она может быть перемещена или удалена.
            this.таргетологTableAdapter.Fill(this.иС_магазин_одежды_для_молодежи_DataSet.Таргетолог);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иС_магазин_одежды_для_молодежи_DataSet.Таргетированная_реклама". При необходимости она может быть перемещена или удалена.
            this.таргетированная_рекламаTableAdapter.Fill(this.иС_магазин_одежды_для_молодежи_DataSet.Таргетированная_реклама);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иС_магазин_одежды_для_молодежи_DataSet.Социальная_сеть". При необходимости она может быть перемещена или удалена.
            this.социальная_сетьTableAdapter.Fill(this.иС_магазин_одежды_для_молодежи_DataSet.Социальная_сеть);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

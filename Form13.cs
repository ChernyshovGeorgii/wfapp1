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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 main = this.Owner as Form12;
            if (main != null)
            {
                DataRow nRow = main.иС_магазин_одежды_для_молодежи_DataSet.Tables[11].NewRow();
                int rc = main.dataGridView3.RowCount + 0;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                nRow[2] = textBox2.Text;
                nRow[3] = textBox3.Text;
                nRow[4] = textBox4.Text;
                nRow[5] = comboBox6.SelectedValue;
                nRow[6] = comboBox8.SelectedValue;
                nRow[7] = comboBox7.SelectedValue;


                main.иС_магазин_одежды_для_молодежи_DataSet.Tables[11].Rows.Add(nRow);
                main.учет_товараTableAdapter.Update(main.иС_магазин_одежды_для_молодежи_DataSet.Учет_товара);
                main.иС_магазин_одежды_для_молодежи_DataSet.Tables[11].AcceptChanges();
                main.dataGridView3.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
               

            }
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иС_магазин_одежды_для_молодежи_DataSet.Размер". При необходимости она может быть перемещена или удалена.
            this.размерTableAdapter.Fill(this.иС_магазин_одежды_для_молодежи_DataSet.Размер);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иС_магазин_одежды_для_молодежи_DataSet.Бренд". При необходимости она может быть перемещена или удалена.
            this.брендTableAdapter.Fill(this.иС_магазин_одежды_для_молодежи_DataSet.Бренд);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иС_магазин_одежды_для_молодежи_DataSet.Учет_товара". При необходимости она может быть перемещена или удалена.
            this.учет_товараTableAdapter.Fill(this.иС_магазин_одежды_для_молодежи_DataSet.Учет_товара);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иС_магазин_одежды_для_молодежи_DataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.иС_магазин_одежды_для_молодежи_DataSet.Товар);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

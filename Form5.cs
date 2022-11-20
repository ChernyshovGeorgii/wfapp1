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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 main = this.Owner as Form6;
            if (main != null)
            {
                DataRow nRow = main.иС_магазин_одежды_для_молодежи_DataSet.Tables[3].NewRow();
                int rc = main.dataGridView3.RowCount + 0;
                nRow[0] = rc;
                nRow[1] = comboBox1.SelectedValue;
                nRow[2] = comboBox2.SelectedValue;
                nRow[3] = comboBox3.SelectedValue;
                nRow[4] = textBox9.Text;
                nRow[5] = comboBox4.SelectedValue;
                nRow[6] = comboBox8.SelectedValue;
                nRow[7] = textBox1.Text;
                nRow[8] = comboBox7.SelectedValue;
                nRow[9] = comboBox6.SelectedValue;
                

                main.иС_магазин_одежды_для_молодежи_DataSet.Tables[3].Rows.Add(nRow);
                main.продажа_товараTableAdapter.Update(main.иС_магазин_одежды_для_молодежи_DataSet.Продажа_товара);
                main.иС_магазин_одежды_для_молодежи_DataSet.Tables[3].AcceptChanges();
                main.dataGridView3.Refresh();
                textBox9.Text = "";
                textBox1.Text = "";
                
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иС_магазин_одежды_для_молодежи_DataSet.Материал_одежды". При необходимости она может быть перемещена или удалена.
            this.материал_одеждыTableAdapter.Fill(this.иС_магазин_одежды_для_молодежи_DataSet.Материал_одежды);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иС_магазин_одежды_для_молодежи_DataSet.Размер". При необходимости она может быть перемещена или удалена.
            this.размерTableAdapter.Fill(this.иС_магазин_одежды_для_молодежи_DataSet.Размер);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иС_магазин_одежды_для_молодежи_DataSet.Скидка". При необходимости она может быть перемещена или удалена.
            this.скидкаTableAdapter.Fill(this.иС_магазин_одежды_для_молодежи_DataSet.Скидка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иС_магазин_одежды_для_молодежи_DataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.иС_магазин_одежды_для_молодежи_DataSet.Клиент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иС_магазин_одежды_для_молодежи_DataSet.Бренд". При необходимости она может быть перемещена или удалена.
            this.брендTableAdapter.Fill(this.иС_магазин_одежды_для_молодежи_DataSet.Бренд);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иС_магазин_одежды_для_молодежи_DataSet.Продажа_товара". При необходимости она может быть перемещена или удалена.
            this.продажа_товараTableAdapter.Fill(this.иС_магазин_одежды_для_молодежи_DataSet.Продажа_товара);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иС_магазин_одежды_для_молодежи_DataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.иС_магазин_одежды_для_молодежи_DataSet.Товар);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

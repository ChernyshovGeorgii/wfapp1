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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иС_магазин_одежды_для_молодежи_DataSet.Размер". При необходимости она может быть перемещена или удалена.
            this.размерTableAdapter.Fill(this.иС_магазин_одежды_для_молодежи_DataSet.Размер);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иС_магазин_одежды_для_молодежи_DataSet.Бренд". При необходимости она может быть перемещена или удалена.
            this.брендTableAdapter.Fill(this.иС_магазин_одежды_для_молодежи_DataSet.Бренд);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иС_магазин_одежды_для_молодежи_DataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.иС_магазин_одежды_для_молодежи_DataSet.Товар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иС_магазин_одежды_для_молодежи_DataSet.Учет_товара". При необходимости она может быть перемещена или удалена.
            this.учет_товараTableAdapter.Fill(this.иС_магазин_одежды_для_молодежи_DataSet.Учет_товара);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form13 af = new Form13();
            af.Owner = this;
            af.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            учетТовараBindingSource.EndEdit();
            учет_товараTableAdapter.Update(иС_магазин_одежды_для_молодежи_DataSet);
        }

        private void dataGridView3_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form14 af = new Form14();
            af.Owner = this;
            af.Show();
        }
    }
}

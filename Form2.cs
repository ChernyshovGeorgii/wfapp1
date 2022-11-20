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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                DataRow nRow = main.иС_магазин_одежды_для_молодежи_DataSet.Tables[8].NewRow();
                int rc = main.dataGridView3.RowCount + 0;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                nRow[2] = textBox2.Text;
                nRow[3] = textBox3.Text;
                nRow[4] = textBox4.Text;
                nRow[5] = comboBox5.SelectedValue;

                main.иС_магазин_одежды_для_молодежи_DataSet.Tables[8].Rows.Add(nRow);
                main.таргетологTableAdapter.Update(main.иС_магазин_одежды_для_молодежи_DataSet.Таргетолог);
                main.иС_магазин_одежды_для_молодежи_DataSet.Tables[8].AcceptChanges();
                main.dataGridView3.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иС_магазин_одежды_для_молодежи_DataSet.Таргетолог". При необходимости она может быть перемещена или удалена.
            this.таргетологTableAdapter.Fill(this.иС_магазин_одежды_для_молодежи_DataSet.Таргетолог);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

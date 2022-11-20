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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 main = this.Owner as Form6;
            if (main != null)
            {
                DataRow nRow = main.иС_магазин_одежды_для_молодежи_DataSet.Tables[0].NewRow();
                int rc = main.dataGridView2.RowCount + 0;
                nRow[0] = rc;
                nRow[1] = textBox11.Text;
                main.иС_магазин_одежды_для_молодежи_DataSet.Tables[0].Rows.Add(nRow);
                main.брендTableAdapter.Update(main.иС_магазин_одежды_для_молодежи_DataSet.Бренд);
                main.иС_магазин_одежды_для_молодежи_DataSet.Tables[0].AcceptChanges();
                main.dataGridView2.Refresh();
                textBox11.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иС_магазин_одежды_для_молодежи_DataSet.Бренд". При необходимости она может быть перемещена или удалена.
            this.брендTableAdapter.Fill(this.иС_магазин_одежды_для_молодежи_DataSet.Бренд);

        }
    }
}

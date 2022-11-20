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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                DataRow nRow = main.иС_магазин_одежды_для_молодежи_DataSet.Tables[10].NewRow();
                int rc = main.dataGridView2.RowCount + 0;
                nRow[0] = rc;
                nRow[1] = textBox11.Text;
                main.иС_магазин_одежды_для_молодежи_DataSet.Tables[10].Rows.Add(nRow);
                main.товарTableAdapter.Update(main.иС_магазин_одежды_для_молодежи_DataSet.Товар);
                main.иС_магазин_одежды_для_молодежи_DataSet.Tables[10].AcceptChanges();
                main.dataGridView2.Refresh();
                textBox11.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

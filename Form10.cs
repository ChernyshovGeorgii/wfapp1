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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 main = this.Owner as Form6;
            if (main != null)
            {
                DataRow nRow = main.иС_магазин_одежды_для_молодежи_DataSet.Tables[1].NewRow();
                int rc = main.dataGridView2.RowCount + 0;
                nRow[0] = rc;
                nRow[1] = textBox11.Text;
                main.иС_магазин_одежды_для_молодежи_DataSet.Tables[1].Rows.Add(nRow);
                main.клиентTableAdapter.Update(main.иС_магазин_одежды_для_молодежи_DataSet.Клиент);
                main.иС_магазин_одежды_для_молодежи_DataSet.Tables[1].AcceptChanges();
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

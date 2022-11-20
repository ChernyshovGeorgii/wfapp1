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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иС_магазин_одежды_для_молодежи_DataSet.Тип". При необходимости она может быть перемещена или удалена.
            this.типTableAdapter.Fill(this.иС_магазин_одежды_для_молодежи_DataSet.Тип);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иС_магазин_одежды_для_молодежи_DataSet.Социальная_сеть". При необходимости она может быть перемещена или удалена.
            this.социальная_сетьTableAdapter.Fill(this.иС_магазин_одежды_для_молодежи_DataSet.Социальная_сеть);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иС_магазин_одежды_для_молодежи_DataSet.Таргетолог". При необходимости она может быть перемещена или удалена.
            this.таргетологTableAdapter.Fill(this.иС_магазин_одежды_для_молодежи_DataSet.Таргетолог);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иС_магазин_одежды_для_молодежи_DataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.иС_магазин_одежды_для_молодежи_DataSet.Товар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иС_магазин_одежды_для_молодежи_DataSet.Таргетированная_реклама". При необходимости она может быть перемещена или удалена.
            this.таргетированная_рекламаTableAdapter.Fill(this.иС_магазин_одежды_для_молодежи_DataSet.Таргетированная_реклама);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 af = new Form3();
            af.Owner = this;
            af.Show();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 af = new Form2();
            af.Owner = this;
            af.Show();
        }

        private void dataGridView3_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 af = new Form4();
            af.Owner = this;
            af.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            таргетологBindingSource.EndEdit();
            таргетологTableAdapter.Update(иС_магазин_одежды_для_молодежи_DataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            таргетированнаяРекламаBindingSource.EndEdit();
            таргетированная_рекламаTableAdapter.Update(иС_магазин_одежды_для_молодежи_DataSet);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            товарBindingSource.EndEdit();
            товарTableAdapter.Update(иС_магазин_одежды_для_молодежи_DataSet);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form6 af = new Form6();
            af.Owner = this;
            af.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 af = new Form7();
            af.Owner = this;
            af.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form8 af = new Form8();
            af.Owner = this;
            af.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form9 af = new Form9();
            af.Owner = this;
            af.Show();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void dataGridView2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}

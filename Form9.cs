﻿using System;
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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                for (int i = 0; i < main.dataGridView2.RowCount; i++)
                {
                    main.dataGridView2.Rows[i].Selected = false;
                    for (int j = 0; j < main.dataGridView2.ColumnCount; j++)
                        if (main.dataGridView2.Rows[i].Cells[j].Value != null)
                            if (main.dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                            {
                                main.dataGridView2.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

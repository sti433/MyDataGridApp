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
            int[,] table = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    table[i, j] = (i + 1) * (j + 1);
                }
            }
            for (int j = 0; j < 10; j++)
            {
                dataGridView1.Columns.Add( "col{j}", (j + 1).ToString());
                    }
            for (int i = 0; i < 10; i++)
            {
                object[] row = new object[10];
                for (int j = 0; j < 10; j++)
                {
                    row[j] = table[i, j];
                }
                dataGridView1.Rows.Add(row);
            }



        }
    }
}

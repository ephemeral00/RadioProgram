using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RadioInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TXT|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader test = new StreamReader(ofd.FileName);
                List<Array> radioList = new List<Array>();
                string[] values;
                String line = test.ReadLine();

                //dataGridView1


                while (line != null)
                {
                    values = line.Split('|');

                    radioList.Add(values);
                    /*listBox1.Items.AddRange(new object[] {
                    line
                    });*/

                    dataGridView1.Rows.Add(values);
                    
                    line = test.ReadLine();

                    

                }

                

                label1.Text = ofd.FileName;
                label2.Text = ofd.SafeFileName;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dATToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

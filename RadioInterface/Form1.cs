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


        DataTable dt = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TXT|*.txt";

            //DataTable dt = new DataTable();
            DataColumn dc = new DataColumn("data", typeof(string));

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader test = new StreamReader(ofd.FileName);
                List<Array> radioList = new List<Array>();
                string[] values;
                String line = test.ReadLine();
                //dataGridView1.Columns.Add();
                //dataGridView1


                dt.Columns.Add("Frequency");
                dt.Columns.Add("Call Sign");
                dt.Columns.Add("Code");
                dt.Columns.Add("Licensed to");
                dt.Columns.Add("City");
                dt.Columns.Add("State");
                dt.Columns.Add("County");
                dt.Columns.Add("Latitude");
                dt.Columns.Add("Longitude");


                while (line != null)
                {
                    values = line.Split('|');

                    radioList.Add(values);
                    /*listBox1.Items.AddRange(new object[] {
                    line
                    });*/

                    dt.Rows.Add(values);
                    
                    line = test.ReadLine();

                    

                }

                dataGridView1.DataSource = dt;


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

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}

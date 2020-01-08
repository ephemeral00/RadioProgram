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

        

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "TXT|*.txt";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                printShit(ofd.FileName);
                checkShit(ofd.FileName);
            }

            label1.Text = ofd.FileName;
            label2.Text = ofd.SafeFileName;


        }

        public void printShit(string path)
        {

            DataTable dt = new DataTable();
            List<Array> radioList = new List<Array>();

            //DataTable dt = new DataTable();
            DataColumn dc = new DataColumn("data", typeof(string));


            StreamReader test = new StreamReader(path);
            string[] values;
            String line = test.ReadLine();
            //dataGridView1.Columns.Add();
            //dataGridView1


            dt.Columns.Add("Frequency");
            dt.Columns.Add("Call Sign");
            dt.Columns.Add("Svc Code");
            dt.Columns.Add("Licensee");
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

        }

        public void checkShit(string path) {
            string directory = "directory.txt";

            DialogResult dialogResult = MessageBox.Show(
                "Remember my selection?",
                "Install information",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.Yes)
            {

                if (!File.Exists(path))
                {
                    File.Create("directory.txt");
                }

                File.WriteAllText(directory, path);

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
            

            if (File.Exists("directory.txt"))
            {
                StreamReader sr = new StreamReader("directory.txt");
                string path = sr.ReadLine();

                try
                {
                    if (path != null)
                    {
                        printShit(path);
                    }
                }

                catch (Exception ex)
                {

                DialogResult dialogResult = MessageBox.Show(
                    "\nThere is an issue with the directory file stored in the program.\nTry deleting the file and re-running the program.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                }

            }

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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

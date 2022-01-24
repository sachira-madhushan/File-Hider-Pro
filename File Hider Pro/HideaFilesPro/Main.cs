using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HideaFilesPro
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hider h = new Hider();
            h.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Unhider u = new Unhider();
            u.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        StreamReader inputFile;
        private void Main_Load(object sender, EventArgs e)
        {
            
            list.Items.Clear();
            int x=0;
            Form1 f1 = new Form1();
            try
            {
                inputFile = File.OpenText(f1.configurationFile);
            }
            catch (Exception ) {

                MessageBox.Show("Important File Is Missing...{Error Code FH01}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

                while (!inputFile.EndOfStream)
                {
                    list.Items.Add(inputFile.ReadLine());

                }



            inputFile.Close();
        }
    }
}

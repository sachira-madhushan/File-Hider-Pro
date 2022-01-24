using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HideaFilesPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            probar.Maximum = 50;
            timer1.Tick += new EventHandler(timer1_Tick);
            probar.Value = 0;

        }
        public static string path;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (probar.Value != 50)
            {
                probar.Value+=10;
            }
            else
            {
                timer1.Stop();
                Main m = new Main();
                openFileDialog1.Title = "Select Your Configuration File";
                openFileDialog1.Filter = "Key File (*.key)|*.key";
                openFileDialog1.InitialDirectory = "c:\\";
                /*if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog1.FileName;
                    
                }
                  */
                m.Show();
                this.Hide();
            }

        }
        public string configurationFile = "Important/Data.key";
        private void pictureBox2_Click(object sender, EventArgs e)
        {
             
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HideaFilesPro
{
    public partial class Hider : Form
    {
        public Hider()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
        }
        StreamWriter writer;
        Form1 f1 = new Form1();
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "No File Chosen")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();
                cmd.StandardInput.WriteLine("attrib +s +h "+ textBox1.Text);
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();
                if (cmd.StandardOutput.ReadToEnd().Length>0)
                {
                    MessageBox.Show("File Is Hidden..!", "Success..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    using (writer = File.AppendText(f1.configurationFile))
                    {
                        writer.WriteLine(textBox1.Text);

                    }
                    
                }
                else
                {

                }
                writer.Close();
                
                
            }
            else
            {
                MessageBox.Show("Please Choose A File.!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open A File To Hide";
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.InitialDirectory = "c:\\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

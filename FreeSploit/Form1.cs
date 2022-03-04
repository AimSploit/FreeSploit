using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;
using System.IO;
using DiscordRPC;

namespace FreeSploit
{
    public partial class Form1 : Form
    {
        bool MouseDown;
        ExploitAPI api = new ExploitAPI();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
            System.Diagnostics.Process.Start("https://aimforum.ml/freesploitdis.html");
            if (api.isAPIAttached())
            {
                progressBar2.Visible = true;
                progressBar2.Value = 100;
                progressBar1.Visible = true;
                progressBar1.Value = 100;
                progressBar3.Visible = true;
                progressBar3.Value = 100;
                progressBar4.Visible = true;
                progressBar4.Value = 100;
            }
            else
            {
                progressBar2.Visible = false;

                progressBar1.Visible = false;

                progressBar3.Visible = false;

                progressBar4.Visible = false;

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (api.isAPIAttached())
            {
                string script = textBox1.Text;
                api.SendLuaScript(script);
            }
            else
            {
                MessageBox.Show("Api isnt injected! Press inject !");

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(textBox1.Text);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string text = File.ReadAllText(openFileDialog.FileName);
                textBox1.Text = text;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
          System.Diagnostics.Process.Start("https://github.com/AimSploit");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/AimSploit/FreeSploit");
        }

        private void Credits_Click(object sender, EventArgs e)
        {
            credits credit = new credits();
            credit.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}





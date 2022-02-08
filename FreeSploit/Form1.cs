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

namespace FreeSploit
{
    public partial class Form1 : Form
    {
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string script = textBox1.Text;
            api.SendLuaScript(script);
        }
    }
}

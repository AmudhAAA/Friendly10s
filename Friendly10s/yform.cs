using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; 

namespace Friendly10s
{
    public partial class yform : Form
    {

       
        public yform()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = Console.ReadLine();
        }

        public void button1_Click(object sender, EventArgs e)
        {

        }

        private void yform_Load(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer mysound = new SoundPlayer(@"C:\Users\zhang\source\repos\Friendly10s\Friendly10s\Resources\happy.wav3");
            mysound.Play();

        }
    }
}

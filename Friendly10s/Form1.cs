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
    public partial class Form1 : Form
    {

        public static int tally = 0;
        public static int count = 0;

        List<Button> btd = new List<Button>();
        
        


        public Form1()
        {
            InitializeComponent();
            label1.Text = "0"; 
            
        }


        public void button1_Click(object sender, EventArgs e)
        {

            tally = tally + 1;
            count = count + 1;
            btd.Add(button1);
            checker();
            button1.BackColor = Color.LightYellow;

            


        }
        public void button_genericClick(object sender, EventArgs e)
        {
            //ignore
        }

        public void button2_Click(object sender, EventArgs e)
        {
            tally = tally + 9;
            count = count + 1;
            btd.Add(button2);
            button2.BackColor = Color.LightYellow;
            checker();
            
            
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)
        {
            tally = tally + 2;
            count = count + 1;
            button3.BackColor = Color.LightYellow;
            btd.Add(button3);
            checker();
            
        }

        public void button4_Click(object sender, EventArgs e)
        {
            tally = tally + 8;
            count = count + 1;
            button1.BackColor = Color.LightYellow;
            btd.Add(button4);
            checker();
            

        }
       public void checker()
        {
            
            if (count == 1)
            {
                return;
            }

            
            if (count == 2) 
            {
                if (tally == 10)
                {
                    success();


                }
                else
                {
                    error();

                }
            }
            string ec = Globals.errorcount.ToString();
            label1.Text = ec;


        }
        public void error()
        {
            pictureBox2.Visible = true;
            timer1.Enabled = true;
            tally = 0;
            count = 0;
            Globals.errorcount = Globals.errorcount + 1;
            colourReset();
            btd.Clear();
        }
        public void success()
        {
            pictureBox3.Visible = true;
            timer2.Enabled = true;
            tally = 0;
            count = 0;
            SoundPlayer mysound = new SoundPlayer(@"C:\Users\amudh\source\repos\Friendly10s1\Friendly10s\Resources\happy.wav");
            mysound.Play();
            foreach (Button x in btd)
            {
                x.Visible = false;
                
            }

            btd.Clear();
            
            

        }
        public void colourReset()
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            button10.BackColor = Color.White;

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //ignore
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tally = tally + 3;  
            count = count + 1;
            button5.BackColor = Color.LightYellow;
            btd.Add(button5);
            checker();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tally = tally + 7;
            count = count + 1;
            button6.BackColor = Color.LightYellow;
            btd.Add(button6);
            checker();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tally = tally + 4;
            count = count + 1;
            button7.BackColor = Color.LightYellow;
            btd.Add(button7);
            checker();
            

        }

        private void button9_Click(object sender, EventArgs e)
        {
            tally = tally + 5;
            count = count + 1;
            button9.BackColor = Color.LightYellow;
            btd.Add(button9);
            checker();
            

        }

        private void button10_Click(object sender, EventArgs e)
        {
            tally = tally + 5;
            count = count + 1;
            button10.BackColor = Color.LightYellow;
            btd.Add(button10);
            checker();
            


        }

        private void button8_Click(object sender, EventArgs e)
        {
            tally = tally + 6;
            count = count + 1;
            button8.BackColor = Color.LightYellow;
            btd.Add(button8);
            checker();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            yform f2 = new yform();
            f2.ShowDialog();
           
        }

    }
   

}

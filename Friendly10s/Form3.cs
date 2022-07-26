﻿using System;
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
    public partial class Form3 : Form
    {
        public static int tally = 0;
        public static int count = 0;
        public static int successCount = 0;
        public static int errorcount = 0;

        List<Button> btd = new List<Button>();
        public Form3()
        {
            InitializeComponent();
            label1.Text = "0";
            button1.Text = "3";
            button2.Text = "27";
            button3.Text = "6";
            button4.Text = "24";
            button5.Text = "9";
            button6.Text = "21";
            button7.Text = "12";
            button8.Text = "18";
            button9.Text = "15";
            button10.Text = "15";


        }
        public void button1_Click(object sender, EventArgs e)
        {




            tally = tally + 3;
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

            tally = tally + 27;
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

            tally = tally + 6;
            count = count + 1;
            button3.BackColor = Color.LightYellow;
            btd.Add(button3);
            checker();

        }
        public void button4_Click(object sender, EventArgs e)
        {

            tally = tally + 24;
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
                if (tally == 30)
                {
                    success();


                }
                else
                {
                    error();

                }
            }
            string ec = errorcount.ToString();
            label1.Text = ec;
            Progress();


        }
        public void error()
        {
            pictureBox2.Visible = true;
            timer1.Enabled = true;
            tally = 0;
            count = 0;
            errorcount = errorcount + 1;
            colourReset();
            btd.Clear();
        }
        public void success()
        {
            pictureBox3.Visible = true;
            timer2.Enabled = true;
            tally = 0;
            count = 0;
            successCount = successCount + 2;
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

            tally = tally + 9;
            count = count + 1;
            button5.BackColor = Color.LightYellow;
            btd.Add(button5);
            checker();

        }
        private void button6_Click(object sender, EventArgs e)
        {
            
            tally = tally + 21;
            count = count + 1;
            button6.BackColor = Color.LightYellow;
            btd.Add(button6);
            checker();

        }
        private void button7_Click(object sender, EventArgs e)
        {

            tally = tally + 12;
            count = count + 1;
            button7.BackColor = Color.LightYellow;
            btd.Add(button7);
            checker();


        }
        private void button9_Click(object sender, EventArgs e)
        {

            tally = tally + 15;
            count = count + 1;
            button9.BackColor = Color.LightYellow;
            btd.Add(button9);
            checker();


        }
        private void button10_Click(object sender, EventArgs e)
        {

            tally = tally + 15;
            count = count + 1;
            button10.BackColor = Color.LightYellow;
            btd.Add(button10);
            checker();



        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            tally = tally + 18;
            count = count + 1;
            button8.BackColor = Color.LightYellow;
            btd.Add(button8);
            checker();

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //ignore
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //ignore
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //ignore

        }
        public void button11_Click(object sender, EventArgs e) // takes to next level
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        public void Progress()
        {
            if (successCount >= 8)
            {
                button12.Visible = true;

                if (errorcount <= 2)
                {
                    button11.Visible = true;

                }

            }
            else
            {
                button11.Visible = false;

            }

        }
        public void Retry()
        {
            errorcount = 0;
            successCount = 0;
            tally = 0;
            count = 0;

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = false;
            button12.Visible = false;

            colourReset();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            Retry();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            //ignore
        }
    }

}

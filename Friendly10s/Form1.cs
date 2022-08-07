namespace Friendly10s
{
    public partial class Form1 : Form
    {
        int tally = 0;
        int count = 0;
        int errorcount = 0;
        
       
        
             


        public Form1()
        {
            InitializeComponent();
            
        }


        public void button1_Click(object sender, EventArgs e)
        {

            tally = tally + 1;
            count = count + 1;
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
            checker();
            button2.BackColor = Color.LightYellow;
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)
        {
            tally = tally + 2;
            count = count + 1;
            checker();
            button3.BackColor = Color.LightYellow;
        }

        public void button4_Click(object sender, EventArgs e)
        {
            tally = tally + 8;
            count = count + 1;
            checker();
            button1.BackColor = Color.LightYellow;

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
            


        }
        public void error()
        {
            pictureBox2.Visible = true;
            timer1.Enabled = true;
            tally = 0;
            count = 0;
            errorcount = errorcount + 1;
            colourReset();
        }
        public void success()
        {
            pictureBox3.Visible = true;
            timer2.Enabled = true;
            tally = 0;
            count = 0;
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
            checker();
            button5.BackColor = Color.LightYellow;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tally = tally + 7;
            count = count + 1;
            checker();
            button6.BackColor = Color.LightYellow;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tally = tally + 4;
            count = count + 1;
            checker();
            button7.BackColor = Color.LightYellow;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            tally = tally + 5;
            count = count + 1;
            checker();
            button9.BackColor = Color.LightYellow;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            tally = tally + 5;
            count = count + 1;
            checker();
            button10.BackColor = Color.LightYellow;


        }

        private void button8_Click(object sender, EventArgs e)
        {
            tally = tally + 6;
            count = count + 1;
            checker();
            button8.BackColor = Color.LightYellow;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //ignore
        }
    }
   

}

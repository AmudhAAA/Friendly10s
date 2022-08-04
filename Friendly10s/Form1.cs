namespace Friendly10s
{
    public partial class Form1 : Form
    {
        int tally = 0;
        int count = 0;
        


        public Form1()
        {
            InitializeComponent();
            
        }


        public void button1_Click(object sender, EventArgs e)
        {

            tally = tally + 1;
            count = count + 1;
            button1.Visible = false;
            

        }
        public void button_genericClick(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            tally = tally + 9;
            count = count + 1;
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)
        {
            tally = tally + 2;
            count = count + 1;
        }

        public void button4_Click(object sender, EventArgs e)
        {
            tally = tally + 8;
            count = count + 1;

        }
       public void checker()
        {
            if (tally == 10)
            {
                if (count == 2)
                {



                }
               
            }
            else
            {
                error();

            }


        }
        public void error()
        {
            pictureBox2.Visible = true;
            tally = 0;
            count = 0;
        }
        public void success()
        {
            pictureBox2.Visible = true;
            tally = 0;
            count = 0;
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
   

}

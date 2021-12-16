namespace TempCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // input
            // นี้คือคอมเม้นท์
            Con1.Text = "Halo";
            Con2.Text = "World";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Con1.Text = "Halo";
            //Con2.Text = "World";
            string input = Con1.Text;
            // convert to f f=c x 9/5 +32
            double c = Convert.ToDouble(input);
            double f = c * 9 / 5 + 32;
            // show input to textbox=con1และ2
            Con2.Text = f.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string input = Con2.Text;
            double f = Convert.ToDouble(input);
            double c = (f-32) * 5/9 ;
            Con1.Text = c.ToString();
        }
    }
}
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
            // show input to textbox
            Con2.Text = input;
        }
    }
}
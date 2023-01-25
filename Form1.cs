namespace IRISCALCN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
            textBox3.Text = a.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int a = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text);
            textBox3.Text = a.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            int a = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text);
            textBox3.Text = a.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int a = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
            textBox3.Text = a.ToString();

        }
    }
}
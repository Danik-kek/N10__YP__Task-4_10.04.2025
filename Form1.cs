namespace N10__YP__Task_4_10._04._2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            label1.Text = random.Next(1, 7).ToString();
        }
    }
}

namespace SEDC.Oop.Class07.Example
{
    public partial class Form1 : Form
    {
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "0";
            button1.Click += button1_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter += 1;
            label1.Text = (counter).ToString();
        }
    }
}
namespace ThreadWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Maximum = 1000000;
            progressBar2.Maximum = 1000000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Loop1);
            thread.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Loop2);
            thread.Start();
        }

        private void Loop1()
        {
            for (int i = 0; i < 1000000; i++)
            {
                progressBar1.Value = i;
            }
        }
        private void Loop2()
        {
            for (int i = 0; i < 1000000; i++)
            {
                progressBar2.Value = i;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(Loop1);
            Thread thread2 = new Thread(Loop2);
            thread1.Start();
            thread2.Start();
        }
    }
}
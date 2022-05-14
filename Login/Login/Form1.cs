namespace Login
{
    public partial class Form1 : Form
    {
        int attempt = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.aa = textBox1.Text;
            string u = textBox1.Text;
            string p = textBox2.Text;
            Main M = new Main();
            if ( attempt < 4 )
            {
                if (u == "lenglee" && p == "1234")
                {
                    M.ShowDialog();
                }

                else
                {
                    MessageBox.Show("Try again and the No of attempt is " +attempt,"Error");
                }
               
            }
            else if(attempt == 4)
            {
                MessageBox.Show("login attemtp exceed");
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                this.Close();
            }
            attempt ++;
        }
    }
}
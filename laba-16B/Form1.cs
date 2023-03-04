namespace laba_16B
{
    public partial class Form1 : Form
    {
        public enum Converting : int
        {
            EuToRu = 4,
            EuToUs = -30,
            EuToUk = -28,
            RuToUs = -34,
            RuToUk = -32,
            UsToUk = 2
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length == 0 || Convert.ToUInt32(textBox1.Text) == 0)
                {
                    throw new Exception();
                }
                if (America.Checked)
                {
                    if (Europe2.Checked)
                    {
                        textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) - Convert.ToInt32(Converting.EuToUs), 10);
                    }
                    else if (America2.Checked)
                    {
                        textBox2.Text = textBox1.Text;
                    }
                    else if (Britain2.Checked)
                    {
                        textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + Convert.ToInt32(Converting.UsToUk), 10);
                    }
                    else if (Russian2.Checked)
                    {
                        textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) - Convert.ToInt32(Converting.RuToUs), 10);
                    }
                }
                else if (Europe.Checked)
                {
                    if (America2.Checked)
                    {
                        textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + Convert.ToInt32(Converting.EuToUs), 10);
                    }
                    else if (Europe2.Checked)
                    {
                        textBox2.Text = textBox1.Text;
                    }
                    else if (Britain2.Checked)
                    {
                        textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + Convert.ToInt32(Converting.EuToUk), 10);
                    }
                    else if (Russian2.Checked)
                    {
                        textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + Convert.ToInt32(Converting.EuToRu), 10);
                    }
                }
                else if (Britain.Checked)
                {
                    if (Europe2.Checked)
                    {
                        textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) - Convert.ToInt32(Converting.EuToUk), 10);
                    }
                    else if (Britain2.Checked)
                    {
                        textBox2.Text = textBox1.Text;
                    }
                    else if (America2.Checked)
                    {
                        textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) - Convert.ToInt32(Converting.UsToUk), 10);
                    }
                    else if (Russian2.Checked)
                    {
                        textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) - Convert.ToInt32(Converting.RuToUk), 10);
                    }
                }
                else if (Russian.Checked)
                {
                    if (Europe2.Checked)
                    {
                        textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) - Convert.ToInt32(Converting.EuToRu), 10);
                    }
                    else if (Russian2.Checked)
                    {
                        textBox2.Text = textBox1.Text;
                    }
                    else if (Britain2.Checked)
                    {
                        textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + Convert.ToInt32(Converting.RuToUk), 10);
                    }
                    else if (America2.Checked)
                    {
                        textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + Convert.ToInt32(Converting.RuToUs), 10);
                    }
                }
            }
            catch
            {
                Application.Exit();
            }
        }
    }
}
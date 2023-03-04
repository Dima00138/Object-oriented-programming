namespace laba_16
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.Text.Length > 0)
                {
                    string[] vars = richTextBox1.Text.Split(',');
                    uint result = 0;
                    foreach (string variable in vars)
                    {
                        if (radioButton1.Checked)
                        {
                            result = result & Convert.ToUInt32(variable);
                        }
                        else if (radioButton2.Checked)
                            result = result | Convert.ToUInt32(variable);
                        else if (radioButton3.Checked)
                            result = result ^ Convert.ToUInt32(variable);
                        else if (radioButton4.Checked)
                            result = ~result;
                    }
                    richTextBox5.Text = Convert.ToString(result, 8);
                    richTextBox6.Text = Convert.ToString(result, 2);
                    richTextBox7.Text = Convert.ToString(result, 10);
                    richTextBox8.Text = Convert.ToString(result, 16);
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox5.Clear();
            richTextBox6.Clear();
            richTextBox7.Clear();
            richTextBox8.Clear();
        }
    }
}
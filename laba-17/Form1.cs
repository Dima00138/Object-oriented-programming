using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Windows.Forms;

namespace laba_17
{
    public partial class Form1 : Form
    {
        bool[] ch = new[] { false, false, false, false, false, false, false };
        List<Lector> lectors = new List<Lector>();
        public Form1()
        {
            InitializeComponent();
        }
        public string err = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value != 100)
            {
                errorProvider1.SetError(this.button1, "Íå âñå ïîëÿ çàïîëíåíû");
                return;
            }
            Lector lector = new Lector();
            try
            {

                lector.name = textBox1.Text;
                lector.otche = textBox3.Text;
                lector.surname = richTextBox1.Text;
                lector.department = listBox1.SelectedIndex;
                lector.corpus = numericUpDown1.Value;
                lector.auditorium = maskedTextBox1.Text;
                if (radioButton1.Checked)
                {
                    lector.gender = "Ìóæ÷èíà";
                }
                else
                {
                    lector.gender = "Æåíùèíà";
                }
                if (!Validate(lector))
                {
                    throw new Exception(err);
                }
            }
            catch
            {
                MessageBox.Show(err, "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lectors.Add(lector);
            string json = JsonSerializer.Serialize(lectors);
            File.WriteAllText("lector.json", json);
        }
        void timer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !ch[0])
            {
                progressBar1.Value += 10;
                ch[0] = true;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text) && !ch[1])
            {
                progressBar1.Value += 10;
                ch[1] = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox3.Text) && !ch[2])
            {
                progressBar1.Value += 10;
                ch[2] = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked && !radioButton2.Checked && !ch[3])
            {
                progressBar1.Value += 20;
                ch[3] = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked && !radioButton1.Checked && !ch[3])
            {
                progressBar1.Value += 20;
                ch[3] = true;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ch[4])
            {
                progressBar1.Value += 20;
                ch[4] = true;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (!ch[5])
            {
                progressBar1.Value += 15;
                ch[5] = true;
            }
        }

        private void maskedTextBox1_MaskInput(object sender, EventArgs e)
        {
            if (!ch[6])
            {
                progressBar1.Value += 15;
                ch[6] = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!File.Exists("lector.json"))
            {
                errorProvider2.SetError(this.button2, "Ôàéëà íåò");
                return;
            }
            Lector lector = new Lector();
            using (Stream stream = new FileStream("lector.json", FileMode.Open))
            {
                lectors = JsonSerializer.Deserialize<List<Lector>>(stream);
            }
            lector = lectors[0];
            textBox1.Text = lector.name;
            richTextBox1.Text = lector.surname;
            textBox3.Text = lector.otche;
            listBox1.SelectedIndex = lector.department;
            numericUpDown1.Value = lector.corpus;
            maskedTextBox1.Text = lector.auditorium;
            if (lector.gender == "Ìóæ÷èíà")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form2 = new Form2(lectors);
            form2.Show();
            form2.Hide();
            form2.ShowDialog();
        }

        private void îÏðîãðàììåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version: 1.0\n" +
                "Timoshenko D. V.", "Î ïðîãðàììå", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ïîèñêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }

        private void î÷èñòêàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            richTextBox1.Text = "";
            textBox3.Text = "";
            listBox1.SelectedIndex = 0;
            numericUpDown1.Value = 0;
            maskedTextBox1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            progressBar1.Value = 0;
            for (int i = 0; i < 7;i++ )
            {
                ch[i] = false;
            }
        }
        public bool Validate(Lector obj)
        {

            List<ValidationResult> results = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(obj, null, null);

            if (!Validator.TryValidateObject(obj, context, results, true))
            {
                foreach (var item in results)
                {
                    err = item.ErrorMessage;
                }
                return false;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var timer = new System.Windows.Forms.Timer();
            timer.Tick += timer_Tick;
            timer.Start();
        }
    }
}
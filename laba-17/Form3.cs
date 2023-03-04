using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
    
namespace laba_17
{
    public partial class Form3 : Form
    {
        private string[] departments = new[] { "ИСиТ", "ПИ", "ХТиТ", "ТОВ"};
        private Lector lector;
        public Form3(Lector lector)
        {
            InitializeComponent();
            this.lector = lector;
            textBox1.Text = lector.name;
            richTextBox1.Text = lector.surname;
            textBox3.Text = lector.otche;
            textBox4.Text = departments[lector.department];
            textBox2.Text = lector.auditorium + "-" + Convert.ToString(lector.corpus);
            if (lector.gender == "Мужчина")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

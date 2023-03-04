using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Text.Json;

namespace laba_17
{
    public partial class Form2 : Form
    {
        private string[] departments = new[] { "ИСиТ", "ПИ", "ХТиТ", "ТОВ" };
        public List<Lector> lectors;
        private bool[] bulling = new bool[] { true, true, true, true, true, true };
        public Form2(List<Lector> lectors)
        {
            InitializeComponent();
            this.lectors = lectors;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender;
            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                gender = radioButton2.Text;
            }
            else
            {
                gender = "";
            }
            if (textBox1.Text.Length == 0) { return; }
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    string name = textBox1.Text;
                    foreach (Lector lector in lectors)
                    {
                        if (new Regex(@$"{name[0]}[а-яё]*[a-z]*", RegexOptions.IgnoreCase).Matches(lector.name).Count > 0
                        || lector.gender == gender)
                        {
                            Form form3 = new Form3(lector);
                            form3.Show();
                            form3.Hide();
                            form3.ShowDialog();
                        }
                    }
                    break;
                case 1:
                    string surname = textBox1.Text;
                    foreach (Lector lector in lectors)
                    {
                        if (new Regex(@$"{surname[0]}[а-яё]*[a-z]*", RegexOptions.IgnoreCase).Matches(lector.surname).Count > 0
                        || lector.gender == gender)
                        {
                            Form form3 = new Form3(lector);
                            form3.Show();
                            form3.Hide();
                            form3.ShowDialog();
                        }
                    }
                    break;
                case 2:
                    string otche = textBox1.Text;
                    foreach (Lector lector in lectors)
                    {
                        if (new Regex(@$"{otche[0]}[а-яё]*[a-z]", RegexOptions.IgnoreCase).Matches(lector.otche).Count > 0
                        || lector.gender == gender)
                        {
                            Form form3 = new Form3(lector);
                            form3.Show();
                            form3.Hide();
                            form3.ShowDialog();
                        }
                    }
                    break;
                case 3:
                    string department = textBox1.Text;
                    foreach (Lector lector in lectors)
                    {
                        if (new Regex(@$"{department[0]}[а-яё]*[a-z]", RegexOptions.IgnoreCase).Matches(departments[lector.department]).Count > 0
                        || lector.gender == gender)
                        {
                            Form form3 = new Form3(lector);
                            form3.Show();
                            form3.Hide();
                            form3.ShowDialog();
                        }
                    }
                    break;
                case 4:
                    string auditorium = textBox1.Text;
                    foreach (Lector lector in lectors)
                    {
                        if (new Regex(@$"{auditorium[0]}[0-9][0-9][-][0-4]", RegexOptions.IgnoreCase).Matches(lector.auditorium + "-" + lector.corpus).Count > 0
                        || lector.gender == gender)
                        {
                            Form form3 = new Form3(lector);
                            form3.Show();
                            form3.Hide();
                            form3.ShowDialog();
                        }
                    }
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string gender = " ";
            string name = " ";
            string surname = " ";
            string otche = " ";
            string department = " ";
            string auditorium = " ";
            if (radioButton1.Checked)
            {
                bulling[5] = false;
                gender = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                bulling[5] = false;
                gender = radioButton2.Text;
            }
            else
            {
                gender = " ";
            }

            if (textBox1.Text.Trim().Length != 0)
            {
                switch (listBox1.SelectedIndex)
                {
                    case 0:
                        bulling[1] = false;
                        name = textBox1.Text;
                        break;
                    case 1:
                        bulling[2] = false;
                        surname = textBox1.Text;
                        break;
                    case 2:
                        bulling[3] = false;
                        otche = textBox1.Text;
                        break;
                    case 3:
                        bulling[4] = false;
                        department = textBox1.Text;
                        break;
                    case 4:
                        bulling[0] = false;
                        auditorium = textBox1.Text;
                        break;
                }
            }
            if ((textBox2.Text.Trim().Length) != 0)
            {
                switch (listBox2.SelectedIndex)
                {
                    case 0:
                        bulling[1] = false;
                        name = textBox2.Text;
                        break;
                    case 1:
                        bulling[2] = false;
                        surname = textBox2.Text;
                        break;
                    case 2:
                        bulling[3] = false;
                        otche = textBox2.Text;
                        break;
                    case 3:
                        bulling[4] = false;
                        department = textBox2.Text;
                        break;
                    case 4:
                        bulling[0] = false;
                        auditorium = textBox2.Text;
                        break;
                }
            }
            if (textBox3.Text.Trim().Length != 0)
            {
                switch (listBox3.SelectedIndex)
                {
                    case 0:
                        bulling[1] = false;
                        name = textBox3.Text;
                        break;
                    case 1:
                        bulling[2] = false;
                        surname = textBox3.Text;
                        break;
                    case 2:
                        bulling[3] = false;
                        otche = textBox3.Text;
                        break;
                    case 3:
                        bulling[4] = false;
                        department = textBox3.Text;
                        break;
                    case 4:
                        bulling[0] = false;
                        auditorium = textBox3.Text;
                        break;
                }
            }
            if (textBox4.Text.Trim().Length != 0)
            {
                switch (listBox4.SelectedIndex)
                {
                    case 0:
                        bulling[1] = false;
                        name = textBox4.Text;
                        break;
                    case 1:
                        bulling[2] = false;
                        surname = textBox4.Text;
                        break;
                    case 2:
                        bulling[3] = false;
                        otche = textBox4.Text;
                        break;
                    case 3:
                        bulling[4] = false;
                        department = textBox4.Text;
                        break;
                    case 4:
                        bulling[0] = false;
                        auditorium = textBox4.Text;
                        break;
                }
            }

            if (name == " " && surname == " " && department == " " && otche == " " && auditorium == " ")
            {
                return;
            }

            var linq = from lector in lectors
                       orderby lector.name
                       select lector;
            switch (listBox5.SelectedIndex)
            {
                case 0:                  
                    break;
                case 1:
                    {
                        linq = from lector in lectors orderby lector.surname select lector;
                        break;
                    }
                case 2:
                    {
                        linq = from lector in lectors orderby lector.otche select lector;
                    }
                    break;
                case 3:
                    {
                        linq = from lector in lectors orderby lector.department select lector;
                    }
                    break;
                case 4:
                    {
                        linq = from lector in lectors orderby lector.auditorium select lector;
                    }
                    break;
            }
            using (Stream fl = new FileStream("search.json", FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize(fl, linq);
            }

            foreach (Lector lector in linq)
            {
                if ((new Regex(@$"{auditorium}[-]*[0-4]*", RegexOptions.IgnoreCase).Matches(lector.auditorium + "-" + lector.corpus).Count > 0 || bulling[0])
                    && (new Regex(@$"{name[0]}[а-яё]*[a-z]*", RegexOptions.IgnoreCase).Matches(lector.name).Count > 0 || bulling[1])
                    && (new Regex(@$"{surname[0]}[а-яё]*[a-z]*", RegexOptions.IgnoreCase).Matches(lector.surname).Count > 0 || bulling[2])
                    && (new Regex(@$"{otche[0]}[а-яё]*[a-z]*", RegexOptions.IgnoreCase).Matches(lector.otche).Count > 0 || bulling[3])
                    && (new Regex(@$"{department[0]}[а-яё]+", RegexOptions.IgnoreCase).Matches(departments[lector.department]).Count > 0 || bulling[4])
                    && (new Regex(@$"{gender[0]}[а-яё]+", RegexOptions.IgnoreCase).Matches(lector.gender).Count > 0 || bulling[5]))
                {
                    Form form3 = new Form3(lector);
                    form3.Show();
                    form3.Hide();
                    form3.ShowDialog();
                }
            }
        }
    }
}

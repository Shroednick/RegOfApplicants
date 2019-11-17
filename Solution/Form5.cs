using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Oksana
{
    public partial class Form5 : Form
    {
        Form1 form;
        public Form5(Form1 f)
        {
            InitializeComponent();
            form = f;
        }
        public Form5()
        {
            InitializeComponent();
            
        }
        public void AddNewPerson() {
            
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "") {
                MessageBox.Show("Заполните все поля", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                StreamWriter write = new StreamWriter("C:\\Users\\shroe\\source\\repos\\Registration of immigrants\\ListOfApplicants", true,System.Text.Encoding.Default);
                try
                {
                    string one = Convert.ToString(textBox1.Text);
                    string two = Convert.ToString(textBox2.Text);
                    string three = Convert.ToString(textBox3.Text);
                    string four = Convert.ToString(textBox4.Text);
                    string five = Convert.ToString(textBox5.Text);
                    string six = Convert.ToString(textBox6.Text);
                    string seven = Convert.ToString(textBox7.Text);
                    string eight = Convert.ToString(textBox8.Text);
                    write.WriteLine(one + " " + two + " " + three + " " + " " + four + " " + five + " " + six + " " + seven + " " + eight + " ");

                    write.Close();

                    
                    
                }

                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
                finally {
                    Close();
                }
            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Проверьте изменения в таблице!");
                AddNewPerson(); 

        }
        private void Form5_Load(object sender, EventArgs e)
        {

        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            int zet = 0;
            textBox7.Text = Convert.ToString(zet);
        }


    }
        
    }


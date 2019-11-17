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
using MetroFramework.Components;
using MetroFramework.Forms;

namespace Oksana
{
    public partial class Form2 : Form
    {
        Form1 frm;
        
        
        public class OtherDifferences
        {
            public string Имя { get; set; }
            public string Фамилия { get; set; }
            public string Отчество { get; set; }
            public double Рейтинг { get; set; }
            public string Контракт { get; set; }
           

            public string Hidden = "";
            

            public OtherDifferences(string Name, string Sername, string patronymic, double rate, string contract)
            {
                this.Имя = Name;
                this.Фамилия = Sername;
                this.Отчество = patronymic;
                this.Рейтинг = rate;
                this.Контракт = contract;

            }
        }
        public Form2(Form1 f) {
            InitializeComponent();
            frm = f;
        }
        public Form2()
        {
            InitializeComponent();
        }

        
        private void Form2_Load(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(Form1.counter);
            label5.Text = Convert.ToString(Form1.Counter);
            label6.Text = Convert.ToString(Form1.BoundaryPoint);
            Form1.counter = Form1.Counter;

        }
     
        private void label3_TextChanged(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(Form1.counter);
            label5.Text = Convert.ToString(Form1.Counter);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("C:\\Users\\shroe\\Desktop\\Приказ на бюджет.txt", FileMode.Truncate);

            StreamWriter myWritet = new StreamWriter(file, Encoding.Default);
            try
            {

                myWritet.WriteLine("Приказ об зачислении на бюджет следующих абитуриентов: ");
                myWritet.WriteLine();
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {


                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        myWritet.Write(dataGridView1.Rows[i].Cells[j].Value.ToString() + " ");
                    }
                    myWritet.WriteLine();
                }
                myWritet.WriteLine();
                myWritet.Write("Дата формирования приказа: " + DateTime.Now);
                MessageBox.Show("Приказ сформирован");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                myWritet.Close();
            }
           
        }
    }
}
    


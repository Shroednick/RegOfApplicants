using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;
using System.IO;

namespace Oksana
{

    public partial class Form3 : Form
    {
        Form1 form;
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
        public Form3(Form1 f)
        {
            InitializeComponent();
            form = f;
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        
            }
        

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("C:\\Users\\shroe\\Desktop\\Приказ на контракт.txt", FileMode.Truncate);

            StreamWriter myWritet = new StreamWriter(file, Encoding.Default);
            try
                    {

                        myWritet.WriteLine("Приказ об зачислении на контракт следующих абитуриентов: ");
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


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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("C:\\Users\\shroe\\Desktop\\Приказ на собеседование.txt", FileMode.Truncate);

            StreamWriter myWritet = new StreamWriter(file, Encoding.Default);
            try
            {

                myWritet.WriteLine("Приказ на собеседование следующих абитуриентов: ");
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


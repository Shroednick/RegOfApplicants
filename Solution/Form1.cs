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
    public partial class Form1 : Form
    {

        BindingList<OtherDifferences> data;
        public BindingList<OtherDifferences> data1;
        static public int BoundaryPoint = 138;


        public Form1()
        {
            InitializeComponent();

        }
        public class General
        {
            public  List<OtherDifferences> numbers = new List<OtherDifferences>();

            public OtherDifferences LastEl()
            {
                return numbers[numbers.Count - 1];

            }
        }
        public class OtherDifferences
        {
            public string Имя { get; set; }
            public string Фамилия { get; set; }
            public string Отчество { get; set; }
            public int Математика { get; set; }
            public int Украинский { get; set; }
            public int Физика { get; set; }
            public int Балл { get; set; }
            public string Контракт { get; set; }

            public string Hidden = "";

            public OtherDifferences(string Name, string Sername, string patronymic, int Math, int Ukr, int Fiz, int Average, string contract)
            {
                this.Имя = Name;
                this.Фамилия = Sername;
                this.Отчество = patronymic;
                this.Математика = Math;
                this.Украинский = Ukr;
                this.Физика = Fiz;
                this.Балл = Average;
                this.Контракт = contract;

            }
        }

        public static int counter = 8;
        public static int Counter = counter;

        public void AddAbittoTable()
        {
            data = new BindingList<OtherDifferences>();
            dataGridView1.DataSource = data;

            General input = new General();
            //dataGridView1.Columns[0].AutoSizeMode = 400;
            StreamReader fileReader = new StreamReader("C:\\Users\\Nikita\\Desktop\\Registration of immigrants\\ListOfApplicants.txt", Encoding.Default);
            string onestr = "";
            while (onestr != null)
            {
                onestr = fileReader.ReadLine();
                if (onestr != null) // проверяем есть ли еще строки в файле
                {

                    string[] words = onestr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (Convert.ToInt32(words[3]) > 100 && Convert.ToInt32(words[4]) > 100 && Convert.ToInt32(words[5]) > 100)
                    {
                        //data.Add(new OtherDifferences(words[0], words[1], words[2], Convert.ToInt32(words[3]), Convert.ToInt32(words[4]),
                        //                      Convert.ToInt32(words[5]), Convert.ToInt32((Convert.ToInt32(words[3]) + Convert.ToInt32(words[4])
                        //                      + Convert.ToInt32(words[5])) / 3), words[7]));

                        input.numbers.Add(new OtherDifferences(words[0], words[1], words[2], Convert.ToInt32(words[3]), Convert.ToInt32(words[4]),
                                              Convert.ToInt32(words[5]), Convert.ToInt32((Convert.ToInt32(words[3]) + Convert.ToInt32(words[4])
                                              + Convert.ToInt32(words[5])) / 3), words[7]));
                        //data.Add(input.LastEl());
                    }
                    else if (Convert.ToInt32(words[3]) <= 100 && Convert.ToInt32(words[4]) <= 100 && Convert.ToInt32(words[5]) <= 100)
                    {
                        input.numbers.Add(new OtherDifferences(words[0], words[1], words[2], 100, 100,
                                              100, Convert.ToInt32((Convert.ToInt32(words[3]) + Convert.ToInt32(words[4])
                                              + Convert.ToInt32(words[5])) / 3), words[7]));
                    }
                    else if (Convert.ToInt32(words[3]) < 100)
                    {
                        input.numbers.Add(new OtherDifferences(words[0], words[1], words[2], 100, Convert.ToInt32(words[4]),
                                               Convert.ToInt32(words[5]), Convert.ToInt32((Convert.ToInt32(words[3]) + Convert.ToInt32(words[4])
                                               + Convert.ToInt32(words[5])) / 3), words[7]));
                    }
                    else if (Convert.ToInt32(words[4]) < 100)
                    {
                        input.numbers.Add(new OtherDifferences(words[0], words[1], words[2], Convert.ToInt32(words[3]), 100,
                                               Convert.ToInt32(words[5]), Convert.ToInt32((Convert.ToInt32(words[3]) + Convert.ToInt32(words[4])
                                               + Convert.ToInt32(words[5])) / 3), words[7]));
                    }
                    else if (Convert.ToInt32(words[5]) < 100)
                    {
                        input.numbers.Add(new OtherDifferences(words[0], words[1], words[2], Convert.ToInt32(words[3]), Convert.ToInt32(words[4]),
                                             100, Convert.ToInt32((Convert.ToInt32(words[3]) + Convert.ToInt32(words[4])
                                             + Convert.ToInt32(words[5])) / 3), words[7]));
                    }

                }
            }
            fileReader.Close();
            
            for(int i = 0; i < input.numbers.Count; i++)
            {
                for(int j = 0; j < input.numbers.Count - 1; j++)
                {
                    if(input.numbers[j].Балл < input.numbers[j+1].Балл)
                    {
                        var swap = input.numbers[j];
                        input.numbers[j] = input.numbers[j + 1];
                        input.numbers[j + 1] = swap;
                    }
                }
            }
            foreach(var s in input.numbers)
            {
                data.Add(s);
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddAbittoTable();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 add = new Form2();

            General listOfStud = new General();
            data1 = new BindingList<OtherDifferences>();
            add.dataGridView1.DataSource = data1;

            int count = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                string param1 = Convert.ToString(dataGridView1[0, i].Value);
                string param2 = Convert.ToString(dataGridView1[1, i].Value);
                string param3 = Convert.ToString(dataGridView1[2, i].Value);
                int param4 = Convert.ToInt32(dataGridView1[3, i].Value);
                int param5 = Convert.ToInt32(dataGridView1[4, i].Value);
                int param6 = Convert.ToInt32(dataGridView1[5, i].Value);
                int param7 = Convert.ToInt32(dataGridView1[6, i].Value);
                string param8 = Convert.ToString(dataGridView1[7, i].Value);
                count++;
                listOfStud.numbers.Add(new OtherDifferences(param1, param2, param3, param4, param5, param6, param7, param8));
                data1.Add(listOfStud.LastEl());

                if (count == Counter)
                {
                    break;
                }
                

            }
            BoundaryPoint = listOfStud.LastEl().Балл;
            
            counter -= count;
            add.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 add = new Form3();
            General input2 = new General();
            data1 = new BindingList<OtherDifferences>();
            add.dataGridView1.DataSource = data1;
            
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToInt32(dataGridView1[6, i].Value) < BoundaryPoint)
                {
                    string param1 = Convert.ToString(dataGridView1[0, i].Value);
                    string param2 = Convert.ToString(dataGridView1[1, i].Value);
                    string param3 = Convert.ToString(dataGridView1[2, i].Value);
                    int param4 = Convert.ToInt32(dataGridView1[3, i].Value);
                    int param5 = Convert.ToInt32(dataGridView1[4, i].Value);
                    int param6 = Convert.ToInt32(dataGridView1[5, i].Value);
                    int param7 = Convert.ToInt32(dataGridView1[6, i].Value);
                    string param8 = Convert.ToString(dataGridView1[7, i].Value);
                    input2.numbers.Add(new OtherDifferences(param1, param2, param3, param4, param5, param6, param7, param8));
                    data1.Add(input2.LastEl());

                }
            }
            add.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 add = new Form4();

            data1 = new BindingList<OtherDifferences>();
            add.dataGridView1.DataSource = data1;
            
            string NotReady = "не_готов";
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToInt32(dataGridView1[6, i].Value) == BoundaryPoint && Convert.ToString(dataGridView1[7, i].Value) == NotReady)
                {
                    string param1 = Convert.ToString(dataGridView1[0, i].Value);
                    string param2 = Convert.ToString(dataGridView1[1, i].Value);
                    string param3 = Convert.ToString(dataGridView1[2, i].Value);
                    int param4 = Convert.ToInt32(dataGridView1[3, i].Value);
                    int param5 = Convert.ToInt32(dataGridView1[4, i].Value);
                    int param6 = Convert.ToInt32(dataGridView1[5, i].Value);
                    int param7 = Convert.ToInt32(dataGridView1[6, i].Value);
                    string param8 = Convert.ToString(dataGridView1[7, i].Value);
                    data1.Add(new OtherDifferences(param1, param2, param3, param4, param5, param6, param7, param8));

                }
            }
            add.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

            private void button4_Click(object sender, EventArgs e)
            {
                Form5 add = new Form5();

                add.Show();

            }

            private void button5_Click(object sender, EventArgs e)
            {
                data.Add(new OtherDifferences("-", "-", "-", 0, 0, 0, 0, "-"));
            }

            private void button6_Click(object sender, EventArgs e)
            {
           
                {
                    Stream myStream;
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        if ((myStream = saveFileDialog1.OpenFile()) != null)
                        {
                            StreamWriter myWritet = new StreamWriter(myStream, Encoding.Default);
                            try
                            {
       
                                myWritet.WriteLine("Информация о абитуриенте: ");
                                myWritet.WriteLine();
                                for (int i = 0; i < dataGridView1.RowCount; i++)
                                {
                                    if (dataGridView1[0, dataGridView1.CurrentCell.RowIndex + i].Value.ToString() == textBox1.Text)
                                    {

                                        for (int j = 0; j < 9; j++)
                                            myWritet.WriteLine(dataGridView1.Columns[j].HeaderText + ": " + dataGridView1.Rows[i].Cells[j].Value.ToString() + " ");
                                        myWritet.WriteLine();
                                    }
                                 
                                }
                            

                            }
                            catch (Exception ex)
                            {
                                //MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                myWritet.Close();
                            }
                            myStream.Close();
                        }
                    }
                }


            }

    private void button7_Click(object sender, EventArgs e)
            {

                if (dataGridView1.ReadOnly == false)
                {
                    dataGridView1.ReadOnly = true;
                    button7.BackColor = Color.Red;
                }
                else
                {
                    dataGridView1.ReadOnly = false;
                    button7.BackColor = Color.Green;
                }
            }

            private void button8_Click(object sender, EventArgs e)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int index = dataGridView1.SelectedRows[0].Index;

                    dataGridView1.Rows.RemoveAt(index);
                    dataGridView1.Refresh();
                }

            }

        private void button9_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("C:\\Users\\Nikita\\Desktop\\Registration of immigrants\\ListOfApplicants.txt", FileMode.Truncate);

            StreamWriter myWritet = new StreamWriter(file, Encoding.Default);
            try
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {


                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        myWritet.Write(dataGridView1.Rows[i].Cells[j].Value.ToString() + " ");
                    }
                    myWritet.WriteLine();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                myWritet.Close();
            }

        
    }

        private void button10_Click(object sender, EventArgs e)
        {
            this.AddAbittoTable();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
    }

    }

    



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mean_and_Standard_Variation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mean

           string[]  nos = textBox1.Text.Split(new char[] {','});
            
            double[] popsi = Array.ConvertAll(nos, double.Parse);
           
            Console.WriteLine(String.Join(",", nos));        

            double summ = 0;

            foreach (int x in popsi)
            {
                summ += x;
            }

            double avera = summ / popsi.Length;

            textBox2.Text = avera.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //standard deviation

            

            string[] nos = textBox1.Text.Split(new char[] { ',' });

            double[] popsi = Array.ConvertAll(nos, double.Parse);

            Console.WriteLine(String.Join(",", nos));

            double summ = 0;

            double stdd = 0;

            foreach (int x in popsi)
            {
                summ += x;
            }
            
            double avera = summ / popsi.Length;

            for (int i = 0; i < popsi.Length; ++i)

                {
                    stdd += Math.Pow(popsi[i] - avera, 2);
                 double stanDad =   Math.Sqrt(stdd / popsi.Length);

                 textBox3.Text = stanDad.ToString();
                }

          



            {

            }

           

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_02_Chart
{
    public partial class School : Form
    {
        public School()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();

            int[] A_School_Class   = new int[4];
            int[] B_School_Class   = new int[4];
            int[] Deagu_School_Sum = new int[2];
            double[] Deagu_School_Average = new double[2];


            for (int i = 0; i < A_School_Class.Length; i++)
            {
                A_School_Class[i] = r.Next(50, 100);
                chart2.Series[0].Points.AddXY((i + 1) + " class", A_School_Class[i]);
                chart2.Series[0].Points[i].Label = A_School_Class[i].ToString();
                Deagu_School_Sum[0] += A_School_Class[i];
            }
            Deagu_School_Average[0] = (double)Deagu_School_Sum[0] / A_School_Class.Length;

            for (int i = 0; i < B_School_Class.Length; i++)
            {
                B_School_Class[i] = r.Next(50, 100);
                chart3.Series[0].Points.AddXY((i + 1) + " class", B_School_Class[i]);
                chart3.Series[0].Points[i].Label = B_School_Class[i].ToString();
                Deagu_School_Sum[1] += B_School_Class[i];
            }
            Deagu_School_Average[1] = (double)Deagu_School_Sum[1] / A_School_Class.Length;

            for (int i = 0; i < Deagu_School_Average.Length; i++)
            {
                chart1.Series[i].Points.AddXY("Average", Deagu_School_Average[i]);
                chart1.Series[i].Points[0].Label = Deagu_School_Average[i].ToString();
            }

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }
    }
}

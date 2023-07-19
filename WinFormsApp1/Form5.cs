using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            double[] xs = DataGen.Consecutive(51);
            double[] sin = DataGen.Sin(51);

            string filePath = "201701.bin";
            List<System.Single> percentages = ListConversion.LoadListFromSingleFile(filePath);
            Double[] pred = new Double[31];
            Double[] date = new Double[31];
            for (int i = 1; i <= 31; i++)
                date[i - 1] = i;
            Debug.WriteLine("test");
            pred = LSTM.RunPredict(percentages);


            formsPlot1.Plot.AddScatter(date, pred);
            formsPlot1.plt.XLabel("日付");
            formsPlot1.plt.YLabel("雲量の割合(%)");
            formsPlot1.plt.Legend();
            formsPlot1.Render();

        }
    }
}

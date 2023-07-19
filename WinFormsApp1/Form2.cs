using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private float select(ComboBox cb)
        {
            return 0F + (cb.SelectedIndex - 1F) * 25F;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WeatherPredict wp = new WeatherPredict();

            float sunshine_hours = 0F;



            //wp.weatherPredict(comboBox1.SelectedText, Int32.Parse(textBox1.Text), select(comboBox3), comboBox5.SelectedText, Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text), comboBox2.SelectedText, Int32.Parse(textBox6.Text), comboBox4.SelectedText);
        }
    }
}

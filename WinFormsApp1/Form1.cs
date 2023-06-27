using Microsoft.ML;
using Microsoft.ML.Data;
using KelpNet.CL;
using System.Diagnostics;
using KelpNet.Tools;
using KelpNet.CL.Common;



namespace WinFormsApp1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = openFileDialog1.FileName;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MLModel1.ModelOutput result = new MLModel1.ModelOutput();

            Thread thread = new Thread(new ThreadStart(() =>
            {
                result = this.check();
            }));
            thread.Start();
            label1.Text = "";
            label1.Text += "解析中なう\n";
            thread.Join();

            label1.Text = "";
            label1.Text += "その画像は。。。\n";

            DataViewSchema.Column? col = MLModel1.PredictEngine.Value.OutputSchema.GetColumnOrNull("Score");
            VBuffer<ReadOnlyMemory<char>> value = default;
            col.Value.Annotations.GetValue("TrainingLabelValues", ref value);

            label1.Text += (result.Score[0] * 100) + "％\nの確率であってるわ\n";

            if (result.Score[0] >= 0.5)
            {
                label1.Text += "多分あってるわ。";
            }
            else
            {
                label1.Text += "多分あってない";
            }

            //Load sample data
            /*MLModel1.ModelInput sampleData = new MLModel1.ModelInput()
            {
                ImageSource = textBox1.Text,
            };

            //Load model and predict output
            var result = MLModel1.Predict(sampleData);

            //label1.Text += String.Format("この画像は : {0} / スコア: {1:f} \r\n", result.PredictedLabel, result.Score.Max());

            DataViewSchema.Column? col = MLModel1.PredictEngine.Value.OutputSchema.GetColumnOrNull("Score");
            VBuffer<ReadOnlyMemory<char>> value = default;
            col.Value.Annotations.GetValue("TrainingLabelValues", ref value);


            label1.Text += "スコア\r\n";
            for (int i = 0; i < result.Score.Length; i++)
            {
                label1.Text += String.Format("Label : {0}  Score : {1:f}\r\n", value.GetItemOrDefault(i).ToString(), result.Score[i]);
            }*/

        }

        private MLModel1.ModelOutput check()
        {
            //Load sample data
            var sampleData = new MLModel1.ModelInput()
            {
                ImageSource = textBox1.Text,
            };
            //Load model and predict output
            return MLModel1.Predict(sampleData);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(() =>
            {
                Sample08.Run();
            }));
            thread.Start();
            label1.Text = "";
            label1.Text += "解析中なう\n";
            thread.Join();
            label1.Text = "";
            label1.Text += "解析終了";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap("201902020000.vis.01.fld.geoss.png");
            int x = 158;    // 左上隅のx座標
            int y = 84;    // 左上隅のy座標
            int width = 1759;    // 切り取る領域の幅
            int height = 1759;   // 切り取る領域の高さ

            double zeroPercentage = 0;

            Thread thread = new Thread(new ThreadStart(() =>
            {
                zeroPercentage = ImageProcessing.CalculateZeroPercentage(image, x, y, width, height);
            }));
            thread.Start();
            label1.Text = "";
            label1.Text += "解析中なう\n";
            thread.Join();
            label1.Text = "";
            label1.Text += "雲の割合は\n" + zeroPercentage + "%\nだったぜ";
        }
    }
}
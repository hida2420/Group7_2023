using Microsoft.ML;
using Microsoft.ML.Data;



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
            label1.Text += "��͒��Ȃ�\n";
            thread.Join();

            label1.Text = "";
            label1.Text += "���̉摜�́B�B�B\n";

            DataViewSchema.Column? col = MLModel1.PredictEngine.Value.OutputSchema.GetColumnOrNull("Score");
            VBuffer<ReadOnlyMemory<char>> value = default;
            col.Value.Annotations.GetValue("TrainingLabelValues", ref value);

            label1.Text += (result.Score[0] * 100) + "��\n�̊m���łЂ��ǂ肾�ˁB\n";
            
            if(result.Score[0] >= 0.5)
            {
                label1.Text += "��������Ђ��ǂ肾��B";
            }
            else 
            {
                label1.Text += "�����Ђ��ǂ肶��Ȃ�";
            }

            //Load sample data
            /*MLModel1.ModelInput sampleData = new MLModel1.ModelInput()
            {
                ImageSource = textBox1.Text,
            };

            //Load model and predict output
            var result = MLModel1.Predict(sampleData);

            //label1.Text += String.Format("���̉摜�� : {0} / �X�R�A: {1:f} \r\n", result.PredictedLabel, result.Score.Max());

            DataViewSchema.Column? col = MLModel1.PredictEngine.Value.OutputSchema.GetColumnOrNull("Score");
            VBuffer<ReadOnlyMemory<char>> value = default;
            col.Value.Annotations.GetValue("TrainingLabelValues", ref value);


            label1.Text += "�X�R�A\r\n";
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
    }
}
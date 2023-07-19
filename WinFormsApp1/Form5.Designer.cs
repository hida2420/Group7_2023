namespace WinFormsApp1
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            button2 = new Button();
            metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            label1 = new Label();
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            formsPlot1 = new ScottPlot.FormsPlot();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.DeepSkyBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(666, 364);
            button2.Name = "button2";
            button2.Size = new Size(106, 33);
            button2.TabIndex = 10;
            button2.Text = "雲量を予測";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // metroComboBox1
            // 
            metroComboBox1.FormattingEnabled = true;
            metroComboBox1.ItemHeight = 23;
            metroComboBox1.Items.AddRange(new object[] { "2017年1月", "2017年2月", "2017年3月", "2017年4月", "2017年5月", "2017年6月", "2017年7月", "2017年8月", "2017年9月", "2017年10月", "2017年11月", "2017年12月", "2018年1月", "2018年2月", "2018年3月", "2018年4月", "2018年5月", "2018年6月", "2018年7月", "2018年8月", "2018年9月", "2018年10月", "2018年11月", "2018年12月", "2019年1月", "2019年2月", "2019年3月", "2019年4月", "2019年5月", "2019年6月", "2019年7月", "2019年8月", "2019年9月", "2019年10月", "2019年11月", "2019年12月", "2020年1月", "2020年2月", "2020年3月", "2020年4月", "2020年5月", "2020年6月", "2020年7月", "2020年8月", "2020年9月", "2020年10月", "2020年11月", "2020年12月", "2021年1月", "2021年2月", "2021年3月", "2021年4月", "2021年5月", "2021年6月", "2021年7月", "2021年8月", "2021年9月", "2021年10月", "2021年11月", "2021年12月", "2022年1月", "2022年2月", "2022年3月", "2022年4月", "2022年5月", "2022年6月", "2022年7月", "2022年8月", "2022年9月", "2022年10月", "2022年11月", "2022年12月", "2023年1月", "2023年2月", "2023年3月", "2023年4月", "2023年5月", "2023年6月" });
            metroComboBox1.Location = new Point(516, 364);
            metroComboBox1.Margin = new Padding(2);
            metroComboBox1.Name = "metroComboBox1";
            metroComboBox1.Size = new Size(129, 29);
            metroComboBox1.TabIndex = 11;
            metroComboBox1.UseSelectable = true;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("HGP創英角ﾎﾟｯﾌﾟ体", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(77, 52);
            label1.Name = "label1";
            label1.Size = new Size(401, 58);
            label1.TabIndex = 14;
            label1.Text = "宇宙から日本周辺の雲量を予測するヨシ！右下から年月を選択してほしいヨシ";
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel1.Location = new Point(186, 226);
            metroLabel1.Margin = new Padding(2, 0, 2, 0);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(0, 0);
            metroLabel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(552, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 332);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.sky011;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(534, 139);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // formsPlot1
            // 
            formsPlot1.Location = new Point(31, 160);
            formsPlot1.Margin = new Padding(4, 3, 4, 3);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(447, 237);
            formsPlot1.TabIndex = 17;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(786, 420);
            Controls.Add(formsPlot1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(metroLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(metroComboBox1);
            Controls.Add(button2);
            Margin = new Padding(2);
            Name = "Form5";
            Text = "雲量予測";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ScottPlot.FormsPlot formsPlot1;
    }
}
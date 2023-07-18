using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class ImageProcessing
    {
        public static double CalculateCloudPercentage(Bitmap image, int x, int y, int width, int height)
        {
            //指定した範囲の画像を切り取る
            Bitmap croppedImage = image.Clone(new Rectangle(x, y, width, height), image.PixelFormat);
            croppedImage.Save("Input.png");

            //画像を二値化する
            Bitmap binaryImage = ToBinary(croppedImage);
            binaryImage.Save("bin.png");

            //0の割合を算出する
            double zeroPercentage = CalculateCloudPercentage(binaryImage);

            return zeroPercentage;
        }

        private static Bitmap ToBinary(Bitmap image)
        {
            Bitmap binaryImage = new Bitmap(image.Width, image.Height);

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    int averageColor = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    Color binaryColor = averageColor < 128 ? Color.Black : Color.White;
                    binaryImage.SetPixel(x, y, binaryColor);
                }
            }

            return binaryImage;
        }

        private static double CalculateCloudPercentage(Bitmap image)
        {
            int totalPixels = image.Width * image.Height;
            int zeroPixels = 0;

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);

                    if (pixelColor.R == 255 && pixelColor.G == 255 && pixelColor.B == 255)
                    {
                        zeroPixels++;
                    }
                }
            }

            double zeroPercentage = (double)zeroPixels / totalPixels * 100;
            return zeroPercentage;
        }

        public static List<Bitmap> LoadImagesFromDirectory(string directoryPath)
        {
            List<Bitmap> images = new List<Bitmap>();

            //指定されたディレクトリ内の画像ファイルを取得
            string[] imageFiles = Directory.GetFiles(directoryPath, "*.png");

            foreach (string imageFile in imageFiles)
            {
                try
                {
                    //画像ファイルを読み込む
                    Bitmap image = new Bitmap(imageFile);
                    images.Add(image);
                }
                catch (Exception ex)
                {
                    //画像ファイルの読み込みエラーの場合、エラーメッセージを表示
                    Debug.WriteLine($"画像ファイルの読み込みエラー: {ex.Message}");
                }
            }

            return images;
        }
    }
}
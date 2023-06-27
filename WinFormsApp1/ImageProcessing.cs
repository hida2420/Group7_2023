using System;
using System.Drawing;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class ImageProcessing
    {
        public static double CalculateZeroPercentage(Bitmap image, int x, int y, int width, int height)
        {
            //w’è‚µ‚½”ÍˆÍ‚Ì‰æ‘œ‚ğØ‚èæ‚é
            Bitmap croppedImage = image.Clone(new Rectangle(x, y, width, height), image.PixelFormat);
            croppedImage.Save("Input.png");

            //‰æ‘œ‚ğ“ñ’l‰»‚·‚é
            Bitmap binaryImage = ToBinary(croppedImage);
            binaryImage.Save("bin.png");

            //0‚ÌŠ„‡‚ğZo‚·‚é
            double zeroPercentage = CalculateZeroPercentage(binaryImage);

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

        private static double CalculateZeroPercentage(Bitmap image)
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
    }
}
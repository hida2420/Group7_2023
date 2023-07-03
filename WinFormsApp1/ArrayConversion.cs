using System;
using System.Collections.Generic;
using System.IO;

namespace WinFormsApp1
{
    public class ListConversion
    {
        public static void SaveDoubleListAsSingleFile(List<double> list, string filePath)
        {
            // Single 型のリストを作成し、要素を変換して格納
            List<float> singleList = new List<float>();
            foreach (double value in list)
            {
                singleList.Add((float)value);
            }

            // バイナリファイルに保存
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(stream))
            {
                writer.Write(singleList.Count);  // リストの要素数を書き込む
                foreach (float value in singleList)
                {
                    writer.Write(value);  // 各要素を書き込む
                }
            }

            Console.WriteLine("Double list saved as single file.");
        }

        public static List<System.Single> LoadListFromSingleFile(string filePath)
        {
            // バイナリファイルから読み込み
            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            using (BinaryReader reader = new BinaryReader(stream))
            {
                int count = reader.ReadInt32();  // リストの要素数を読み込む
                List<System.Single> singleList = new List<System.Single>();
                for (int i = 0; i < count; i++)
                {
                    singleList.Add(reader.ReadSingle());  // 各要素を読み込む
                }


                Console.WriteLine("Double list loaded from single file.");
                return singleList;
            }
        }
    }
}

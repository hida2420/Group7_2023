﻿
// This file was auto-generated by ML.NET Model Builder. 

using System;

namespace MLModel1_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            MLModel1.ModelInput sampleData = new MLModel1.ModelInput()
            {
                Col0 = @"6/27",
                Col1 = 20.3F,
                Col3 = @"Sunny then cloudy with occasional rain",
                Col4 = 20.3F,
                Col5 = 85F,
                Col6 = 1003.3F,
                Col7 = 1008.4F,
                Col8 = 1006.7F,
                Col9 = 68F,
                Col10 = 5.1F,
                Col11 = 18.95F,
                Col12 = 5.5F,
                Col13 = 3.5F,
                Col14 = 24.9F,
                Col15 = 16.8F,
                Col16 = 0F,
                Col17 = 0F,
                Col18 = 3.2F,
                Col19 = 6.9F,
                Col20 = @"northwest",
                Col21 = 9.2F,
                Col22 = @"West",
                Col23 = @"West",
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = MLModel1.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Col2 with predicted Col2 from sample data...\n\n");


            Console.WriteLine($"Col0: {@"6/27"}");
            Console.WriteLine($"Col1: {20.3F}");
            Console.WriteLine($"Col2: {@"Partly cloudy, then sunny"}");
            Console.WriteLine($"Col3: {@"Sunny then cloudy with occasional rain"}");
            Console.WriteLine($"Col4: {20.3F}");
            Console.WriteLine($"Col5: {85F}");
            Console.WriteLine($"Col6: {1003.3F}");
            Console.WriteLine($"Col7: {1008.4F}");
            Console.WriteLine($"Col8: {1006.7F}");
            Console.WriteLine($"Col9: {68F}");
            Console.WriteLine($"Col10: {5.1F}");
            Console.WriteLine($"Col11: {18.95F}");
            Console.WriteLine($"Col12: {5.5F}");
            Console.WriteLine($"Col13: {3.5F}");
            Console.WriteLine($"Col14: {24.9F}");
            Console.WriteLine($"Col15: {16.8F}");
            Console.WriteLine($"Col16: {0F}");
            Console.WriteLine($"Col17: {0F}");
            Console.WriteLine($"Col18: {3.2F}");
            Console.WriteLine($"Col19: {6.9F}");
            Console.WriteLine($"Col20: {@"northwest"}");
            Console.WriteLine($"Col21: {9.2F}");
            Console.WriteLine($"Col22: {@"West"}");
            Console.WriteLine($"Col23: {@"West"}");


            Console.WriteLine($"\n\nPredicted Col2: {predictionResult.Prediction}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}

﻿﻿// This file was auto-generated by ML.NET Model Builder. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers.LightGbm;
using Microsoft.ML.Trainers;
using Microsoft.ML;

namespace MLModel1_ConsoleApp1
{
    public partial class MLModel1
    {
        public static ITransformer RetrainPipeline(MLContext context, IDataView trainData)
        {
            var pipeline = BuildPipeline(context);
            var model = pipeline.Fit(trainData);

            return model;
        }

        /// <summary>
        /// build the pipeline that is used from model builder. Use this function to retrain model.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <returns></returns>
        public static IEstimator<ITransformer> BuildPipeline(MLContext mlContext)
        {
            // Data process configuration with pipeline data transformations
            var pipeline = mlContext.Transforms.ReplaceMissingValues(new []{new InputOutputColumnPair(@"col1", @"col1"),new InputOutputColumnPair(@"col4", @"col4"),new InputOutputColumnPair(@"col5", @"col5"),new InputOutputColumnPair(@"col6", @"col6"),new InputOutputColumnPair(@"col7", @"col7"),new InputOutputColumnPair(@"col8", @"col8"),new InputOutputColumnPair(@"col9", @"col9"),new InputOutputColumnPair(@"col10", @"col10"),new InputOutputColumnPair(@"col11", @"col11"),new InputOutputColumnPair(@"col12", @"col12"),new InputOutputColumnPair(@"col13", @"col13"),new InputOutputColumnPair(@"col14", @"col14"),new InputOutputColumnPair(@"col15", @"col15"),new InputOutputColumnPair(@"col16", @"col16"),new InputOutputColumnPair(@"col17", @"col17"),new InputOutputColumnPair(@"col18", @"col18"),new InputOutputColumnPair(@"col19", @"col19"),new InputOutputColumnPair(@"col21", @"col21")})      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(@"col0", @"col0"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(@"col3", @"col3"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(@"col20", @"col20"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(@"col22", @"col22"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(@"col23", @"col23"))      
                                    .Append(mlContext.Transforms.Concatenate(@"Features", new []{@"col1",@"col4",@"col5",@"col6",@"col7",@"col8",@"col9",@"col10",@"col11",@"col12",@"col13",@"col14",@"col15",@"col16",@"col17",@"col18",@"col19",@"col21",@"col0",@"col3",@"col20",@"col22",@"col23"}))      
                                    .Append(mlContext.Transforms.Conversion.MapValueToKey(@"col2", @"col2"))      
                                    .Append(mlContext.MulticlassClassification.Trainers.LightGbm(new LightGbmMulticlassTrainer.Options(){NumberOfLeaves=4,MinimumExampleCountPerLeaf=2,NumberOfIterations=74,MaximumBinCountPerFeature=64,LearningRate=1F,LabelColumnName=@"col2",FeatureColumnName=@"Features",Booster=new GradientBooster.Options(){SubsampleFraction=0.639610485576714F,FeatureFraction=0.713545621707654F,L1Regularization=9.98735359284971E-07F,L2Regularization=47.9434834714179F}}))      
                                    .Append(mlContext.Transforms.Conversion.MapKeyToValue(@"PredictedLabel", @"PredictedLabel"));

            return pipeline;
        }
    }
}

using System;
using GettingStarted_MachineLearning_NETML.Model;

namespace GettingStarted_MachineLearning_NET
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                foreach (string arg in args)
                {
                    AnalyzeText(arg);
                }
            }
            else
            {
                AnalyzeText("That is rude.");
            }
        }

        static void AnalyzeText(string text)
        {
            // Add input data
            var input = new ModelInput
            {
                SentimentText = text
            };

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            Console.WriteLine($"Text: {input.SentimentText}\nIs Toxic: {result.Prediction}\n\n");
        }
    }
}

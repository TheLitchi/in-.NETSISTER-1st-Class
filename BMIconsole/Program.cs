using BMIService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入身高 (公尺) :");
            string inputHeight = Console.ReadLine();
            Console.WriteLine("請輸入體重 (公斤) :");
            string inputWeight = Console.ReadLine();

            //double height = 0.0d;

            //if (!double.TryParse(inputHeight, out height ))
            //{

            

            double height = double.Parse(inputHeight);
            double weight = double.Parse(inputWeight);

            BMIService.IBodyMeasureIndex bmiService = null;
            bmiService = new BMIService.WomenBodyMeasureIndex();
            double bmi = 0.0d;
            MeasureResult result = bmiService.caculute(height, weight, out bmi);

            Console.WriteLine(bmi);

            //Console.WriteLine("結果是");
            
            switch(result)
            {
                case MeasureResult.Less :
                    Console.WriteLine("太瘦");
                    break;

                case MeasureResult.Normal:
                    Console.WriteLine("剛剛好");
                    break;

                case MeasureResult.More:
                    Console.WriteLine("太胖");
                    break;
            }

           
            Console.ReadLine();
        }
    }
}

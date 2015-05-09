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
            Console.WriteLine("你是公的嗎?(請輸入y/n)");
            String genderIdent = Console.ReadLine();

            BMIService.IBodyMeasureIndex bmiService = null;
            bmiService = new BMIService.WomenBodyMeasureIndex();
            double bmi = 0.0d;


            bool isMale = true;
            isMale = (genderIdent == "y");

            if (isMale)
                bmiService = new MenBodyMeasureIndex();
            else
                bmiService = new WomenBodyMeasureIndex();
            

            double height = double.Parse(inputHeight);
            double weight = double.Parse(inputWeight);

           
            MeasureResult result = bmiService.caculute(height, weight, out bmi);

            Console.WriteLine(bmi);

                      
            switch(result)
            {
                case MeasureResult.Less :
                    Console.WriteLine("太瘦");
                    break;

                case MeasureResult.Normal:
                    Console.WriteLine("剛剛好");
                    break;

                case MeasureResult.More:
                    Console.WriteLine("尼太胖！！！");
                    break;
            }

           
            Console.ReadLine();
        }
    }
}

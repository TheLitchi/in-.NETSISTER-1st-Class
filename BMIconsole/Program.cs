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

            //}

            double height = double.Parse(inputHeight);
            double weight = double.Parse(inputWeight);

            double bmi = weight / (height * height);
            Console.WriteLine(bmi);

            //Console.WriteLine("結果是");
            

            

            if (bmi < 18)
            {
                Console.WriteLine("太瘦");
            }
            else
            {
                if (bmi > 22)
                {
                    Console.WriteLine("太胖");
                }
                else
                {
                    Console.WriteLine("剛剛好");
                }
            }
            Console.ReadLine();
        }
    }
}

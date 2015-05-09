using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIService
{
    public class WomenBodyMeasureIndex : IBodyMeasureIndex
    {
        public MeasureResult caculute(double Height, double Weight, out double BMI)
        {

            //double height = double.Parse(inputHeight);
            //double weight = double.Parse(inputWeight);

            BMI = Weight / (Height * Height);
    
            if (BMI < 18)
            {
                return MeasureResult.Less;
            }
            else
            {
                if (BMI > 22)
                {
                   return MeasureResult.More;
                }
                else
                {
                    return MeasureResult.Normal;
                }
            }
        }
    }
}

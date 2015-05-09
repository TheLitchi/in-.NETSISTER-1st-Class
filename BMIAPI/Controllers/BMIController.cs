using BMIService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace BMIAPI.Controllers
{
    public class BMIController : ApiController
    {
        public async Task<string> Women()
        {
            var forms = await Request.Content.ReadAsFormDataAsync();

            double height = double.Parse(forms["height"]);
            double weight = double.Parse(forms["weight"]);

            BMIService.IBodyMeasureIndex bmiService = null;
            bmiService = new BMIService.WomenBodyMeasureIndex();
            double bmi = 0.0d;
            MeasureResult result = bmiService.caculute(height, weight, out bmi);

          
            switch (result)
            {
                case MeasureResult.Less:
                    return "太瘦";
                   
                case MeasureResult.Normal:
                    return "剛好";
                    
                case MeasureResult.More:
                    return "尼太胖!!!";
                default: 
                    return "";

            }
        }

        public async Task<string> Men()
        {
            var forms = await Request.Content.ReadAsFormDataAsync();

            double height = double.Parse(forms["height"]);
            double weight = double.Parse(forms["weight"]);

            BMIService.IBodyMeasureIndex bmiService = null;
            bmiService = new BMIService.MenBodyMeasureIndex();
            double bmi = 0.0d;
            MeasureResult result = bmiService.caculute(height, weight, out bmi);


            switch (result)
            {
                case MeasureResult.Less:
                    return "太瘦";

                case MeasureResult.Normal:
                    return "剛好";

                case MeasureResult.More:
                    return "尼太胖!!!";
                default:
                    return "";

            }
        }


    }
}

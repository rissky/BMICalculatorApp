using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculatorApp
{
    public class BMICalculator
    {
        public float Height { get; set; }
        public float Weight { get; set; }

        public float Bmi { get; set; }

        public BMICalculator()
        {

        }

        public BMICalculator(float height, float weight)
        {
            this.Height = height;
            this.Weight = weight;
        }

        public float CalculateBMI()
        {
            if (Weight != 0 && float.IsNaN(Weight))
            {
                throw new Exception("Weight not set correctly");
            }
            else if (Height != 0 && float.IsNaN(Height))
            {
                throw new Exception("Height not set correctly");
            }
            else
            {
               return Weight / (Height * Height);
            }
        }
        public BMIType GetCategory()
        {
            Bmi = CalculateBMI();           

            if (Bmi < 18.5)
            {
                return BMIType.Underweight;
            }
            else if (Bmi < 25)
            {
                return BMIType.Healthy;
            }
            else if (Bmi < 30)
            {
                return BMIType.OverWeight;
            }
            else
            {
                return BMIType.Obese;
            }
        }
    }
}

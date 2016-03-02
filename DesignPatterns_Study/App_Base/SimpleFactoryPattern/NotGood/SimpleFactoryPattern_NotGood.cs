using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Study.App_Base.SimpleFactoryPattern.NotGood
{
    public class SimpleFactoryPattern_NotGood
    {

        public static double GetResult(double numA,double numB,string operate)
        {
            double result = 0;
            switch (operate)
            {
                case "+":
                    result = numA + numB;
                    break;
                case "-":
                    result = numA - numB;
                    break;
            }
            return result;


        }
    }
}

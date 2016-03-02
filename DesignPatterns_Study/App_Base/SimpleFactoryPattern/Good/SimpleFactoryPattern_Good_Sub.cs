using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Study.App_Base.SimpleFactoryPattern.Good
{
    public class SimpleFactoryPattern_Good_Sub : SimpleFactoryPattern_Good
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumA - NumB;
            return result;
            //return base.GetResult();
        }
    }
}

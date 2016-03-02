using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Study.App_Base.SimpleFactoryPattern.Good
{
    public class SimpleFactoryPattern_Good
    {
        //由於繼承時會將變數一併繼承，所以當我們去其他class繼承此class時，也就存在了NumA及NumB了
        //但建構式無法被繼承，需要使用base來做呼叫動作，在override vitural的function後，如果在繼承那頁要用到底層的function也需要記得使用base才可以呼叫

        private double _NumA;

        public double NumA
        {
            get { return _NumA; }
            set { _NumA = value; }
        }

        private double _NumB;

        public double NumB
        {
            get { return _NumB; }
            set { _NumB = value; }
        }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Study.App_Base.SimpleFactoryPattern.Good
{
    //在前面的Add及Sub，現在將每一個運算都拆分成一個class，將來有問題時，就只要專注於那隻Class的邏輯即可，可以確保不會影響到其他程式邏輯
    //簡單工廠模式就是透過一個單獨類別去做判斷來new出指定的類別，前提時，這些需要new出的都是繼承於一個Class底下
    public class SimpleFactoryPattern_Good_Factory
    {
        public static SimpleFactoryPattern_Good CreateOperate(string operate)
        {
            SimpleFactoryPattern_Good _SimpleFactoryPattern = null;
            switch (operate)
            {
                case "+":
                    _SimpleFactoryPattern = new SimpleFactoryPattern_Good_Add();
                    break;
                case "-":
                    _SimpleFactoryPattern = new SimpleFactoryPattern_Good_Sub();
                    break;
            }
            return _SimpleFactoryPattern;



        }


    }
}

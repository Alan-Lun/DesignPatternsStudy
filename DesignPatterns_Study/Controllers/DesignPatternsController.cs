using DesignPatterns_Study.App_Base.SimpleFactoryPattern.Good;
using DesignPatterns_Study.App_Base.SimpleFactoryPattern.NotGood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DesignPatterns_Study.Controllers
{
    public class DesignPatternsController : Controller
    {
        // GET: DesignPatterns
        public ActionResult Index()
        {
            //物件導向目的
            /*
            第一，要改，只需要改要改的東西，代表可維護
            第二，可以後來重複使用，代表可複用
            第三，如果要加條件，只需要在另外增加就可以，代表可擴展
            第四，可透過條件改變一下，就可以滿足需求，此是靈活性好
            
            //物件導向好處
            過去寫的程式，每次都可能導致重頭來過，原因就是少於上述
            ，所以開始透過封裝、繼承、多型把程式耦和度降低

            */
            return View();
        }

        //試者讓業務邏輯與介面邏輯分開，使耦合度下降

        /// <summary>
        /// 01-簡單工廠模式
        /// </summary>
        /// <returns></returns>
        public ActionResult SimpleFactoryPattern()
        {
            #region 不好示範
            //這樣寫用到了封裝，但這樣寫法如果要再新增其他運算很有可能改到其他運算的邏輯
            ViewData["Number"] = SimpleFactoryPattern_NotGood.GetResult(2, 2, "+");

            #endregion

            #region 好示範
            //改成這樣子只要給予符號，由我們自己寫的工廠就可以自己去執行對應的運算
            SimpleFactoryPattern_Good _Good = SimpleFactoryPattern_Good_Factory.CreateOperate("-");
            _Good.NumA = 7;
            _Good.NumB = 3;
            ViewData["Number2"] = _Good.GetResult();
            #endregion


            return View();
        }

    }
}
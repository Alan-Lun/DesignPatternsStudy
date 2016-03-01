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

        /// <summary>
        /// 01-簡單工廠模式
        /// </summary>
        /// <returns></returns>
        public ActionResult SimpleFactoryPattern()
        {


            return View();
        }

    }
}
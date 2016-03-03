using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Study.App_Base.UML
{
    public class Bird:Animal
    {
        public string feather{ get; set; }

        public void layegg()
        {

        }

        private Wing wing,wing2;
        public Bird()
        {
            wing = new Wing();
            wing2 = new Wing();
        }

        public void GoHome(Climate climate)
        {

        }



    }
}

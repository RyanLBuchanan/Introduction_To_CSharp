using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_2_CSharp
{
    internal class Robot
    {
        // a field or variable
        private string robotType = "hover bot";

        // method
        public void Introduction()
        {
            Console.WriteLine("Beep, boop, beep.\nI'm a {0} type of robot.", robotType);
        }
    }
}

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
        public int speed;
        private string robotType = "hover bot";

        // method
        public void Introduction()
        {
            Console.WriteLine("Beep, boop, beep.\nI'm a {0} type of robot.", robotType);
        }

        // Provide controlled access to and validation for private "backing" fields
        // Written like methods
        public string RobotType
        {
            get { return robotType; }
            set { 
                if (value == null)
                {
                    robotType = "";
                }
                else
                {
                    robotType = value;
                }
            }
        }
    }
}

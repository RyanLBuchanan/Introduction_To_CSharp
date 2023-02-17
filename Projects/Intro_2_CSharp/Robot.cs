using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_2_CSharp
{
    abstract class Robot
    {
        // a field or variable
        public int maxSpeed;
        private string robotType;

        // Constructor
        public Robot(int maxSpeed)
        {
            this.maxSpeed = maxSpeed;
            this.robotType = robotType;
        }

        // Properties
        public int MaxSpeed
        {
            get { return maxSpeed; }
            set
            {
                if (value < 0)
                {
                    maxSpeed = 0;
                }
                else
                {
                    maxSpeed = value;
                }
            }
        }

        // Provide controlled access to and validation for private "backing" fields
        // Written like methods
        public string RobotType
        {
            get { return robotType; }
            set
            {
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

        // method
        public void Introduction()
        {
            Console.WriteLine("Beep, boop, beep.\nI'm a {0} type of robot.", robotType);
        }

        public abstract void Move();

        public void Identify()
        {
            Console.WriteLine($"I am a {robotType}");
        }
    }
}

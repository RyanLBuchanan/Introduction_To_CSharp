//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Intro_2_CSharp
//{
//    class HoverBot : Robot, IScanning 
//    {
//        public HoverBot(int maxSpeed)
//        {
//            this.RobotType = "hovering";
//            this.MaxSpeed = maxSpeed;
//        }

//        public override void Move()
//        {
//            Console.WriteLine($"The {RobotType} robot flies {MaxSpeed} miles per hour.");
//        }

//        public void Scan(string target)
//        {
//            Console.WriteLine($"The robot scans for {target}.");
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSolutionArchitectureOOP._1_Dars.LessonTask
{
    internal class Point
    {
        //. X va Y koordinatalarni ifodalovchi field'larga ega bo’lgan Point classini yozing.
        // Koordinatalarni “(45, 56)” shaklda chop etuvchi PrintXY() methodini yozing. (oson)

        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void PrintXY()
        {
            Console.WriteLine($"({X},{Y})");
        }

    }
}

global using static System.Math;
using System;

enum Color
{
    blue,
    green,
    white
}
namespace TestingNamespace
{

    public class jens_Testing
    {
        public int testingIntMin { get; set; }
        public string testingString { get; set; }
        public int testingIntMax { get; set; }

        public float GetMin(int min, int max)
        {
            // old way
            // return Math.Min(min, max);
            return Min(min, max);
        }
    }
    namespace TestingNamespace1
    {
        namespace TestingNamespace2
        {
            public class ProjectTest
            {
                public double SquareRoot(int _num1, int _num2)
                {
                    return Sqrt(_num1 + _num2 * _num2 + _num2);
                }

                // Less accessiable due to glabal using
                //public Color GetAColor()
                //{
                //    return green;
                //}
            }
        }
    }
}

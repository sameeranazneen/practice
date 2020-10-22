using System;

namespace Triangle1
{
    public static class TriangleSolver
    {
        public static string Analyze(int x, int y, int z)
        {
            string triangleFormed = "";

            if ((x + y > z || y + z > x || x + z > y) && (x > 0 && y > 0 && z > 0))
            {
                Console.WriteLine("The given sides form a triangle");
                if (x == y && y == z)
                {
                    triangleFormed = "forms Equilateral Triangle";
                }
                else if (x == y || x == z || y == z)
                {
                    triangleFormed = "forms Isosceles Triangle";
                }
                else
                {
                    triangleFormed = "forms Scalene Triangle";
                }

                return triangleFormed;
            }
            else
            {
                return "does not form a triangle";
            }
        }
    }
}
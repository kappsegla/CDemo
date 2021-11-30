using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TestProject1")]
namespace GitDemo
{
    internal class Triangle
    {

        public double[] sides;

        public Triangle(double a, double b, double c)
        {
            sides = new double[] { a, b, c };
        }

        public Triangle(double[] s)
        {
            sides = new double[s.Length];
            Array.Copy(s, 0, sides, 0, s.Length);
        }

        public Triangle(Point a, Point b, Point c)
        {
            sides = new double[3];
            sides[0] = Math.Sqrt(Math.Pow(b.x - a.x, 2.0) + Math.Pow(b.y - a.y, 2.0));
            sides[1] = Math.Sqrt(Math.Pow(b.x - c.x, 2.0) + Math.Pow(b.y - c.y, 2.0));
            sides[2] = Math.Sqrt(Math.Pow(c.x - a.x, 2.0) + Math.Pow(c.y - a.y, 2.0));
        }

        public Triangle(Point[] s)
        {
            sides = new double[s.Length];
            sides[0] = Math.Sqrt(Math.Pow(s[1].x - s[0].x, 2.0) + Math.Pow(s[1].y - s[0].y, 2.0));
            sides[1] = Math.Sqrt(Math.Pow(s[1].x - s[2].x, 2.0) + Math.Pow(s[1].x - s[2].x, 2.0));
            sides[2] = Math.Sqrt(Math.Pow(s[2].x - s[0].x, 2.0) + Math.Pow(s[2].x - s[0].x, 2.0));
        }

        private int UniqueSides()
        {

            int distinctIntegers = 0;

            for (int j = 0; j < sides.Length; j++)
            {
                double thisInt = sides[j];
                bool seenThisIntBefore = false;
                for (int i = 0; i < j; i++)
                {
                    if (thisInt == sides[i])
                    {
                        seenThisIntBefore = true;
                    }
                }
                if (!seenThisIntBefore)
                {
                    distinctIntegers++;
                }
            }
            return distinctIntegers;
        }

        public bool IsScalene()
        {
            return UniqueSides() == 3;
        }

        public bool isEquilateral()
        {
            if (UniqueSides() == 1)
            {
                return true;
            }
            return false;
        }

        public bool isIsosceles()
        {
            if (UniqueSides() == 2)
            {
                return true;
            }
            return false;
        }
    }
}

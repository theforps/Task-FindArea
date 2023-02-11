using SearchSquare.Interfaces;
using System.Diagnostics;

namespace SearchSquare
{
    public class Objects : IObjects
    {
        public double Aria(double r)
        {
            try
            {
                double S = Math.Pow(r, 2) * 3.14;
            }
            catch (Exception ex) 
            {
                Trace.WriteLine(ex);
            }

            return r;
        }

        public double Aria(double x, double y, double z)
        {
            double S = 0;

            try
            { 
                if (x + y > z && x + z > y && y + z > x)
                {
                    var sides = new List<double> { x, y, z };

                    var maxSide = sides.Max();
                    sides.Remove(maxSide);

                    if (Math.Pow(maxSide, 2) == (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2)))
                    {
                        Trace.WriteLine("IsRight = true");
                    }
                    else
                    {
                        Trace.WriteLine("IsRight = true");
                    }

                    double p = (x + y + z) / 2;
                    S = Math.Round(Math.Sqrt(p * (p - x) * (p - y) * (p - z)), 2);
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }

            return S;
        }
    }
}
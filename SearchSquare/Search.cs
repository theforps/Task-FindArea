using SearchSquare.Interfaces;

namespace SearchSquare
{
    public class Search : IObjects
    {
        public List<string> NamesOfFigure { 
            get { 
                return new List<string> { 
                    "triangle", 
                    "circle" 
                }; 
            } 
        }

        //площадь труегольника
        public string Triangle(double x, double y, double z)
        {
            if (x + y > z && x + z > y && y + z > x)
            {
                string message = "";
                var sides = new List<double> { x, y, z };
                var maxSide = sides.Max();
                sides.Remove(maxSide);

                if (Math.Pow(maxSide, 2) == (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2)))
                {
                    message += "The triangle is rectangular.\n";
                }

                double p = (x + y + z) / 2;
                double S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));

                message += $"The area of the triangle = {Math.Round(S, 2)}";

                return message;

            }
            else
                return "Еhere is no such triangle.";
        }

        //площадь круга
        public string Circle(double r)
        {
            double S = Math.Pow(r,2) * 3.14;

            return $"The area of the circle = {S}";
        }
    }
}
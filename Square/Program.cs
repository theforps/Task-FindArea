using SearchSquare;

namespace Square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Search ser = new Search();
            
            while(true)
            {
                Console.Write("Choose a figure, enter the figure name to the console " +
                    $"({ser.NamesOfFigure[0]}, {ser.NamesOfFigure[1]}): ");

                string nameOfTheFigure = Console.ReadLine();

                if (ser.NamesOfFigure.Contains(nameOfTheFigure.ToLower()))
                {
                    Console.Clear();
                    Answer(nameOfTheFigure);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Try again");
                }
            }
        }
        public static void Answer(string name)
        {
            Search ser = new Search();

            if (name.ToLower() == ser.NamesOfFigure[0])
            {
                var sides = new List<double>() { 0,0,0};
                for (int i = 0; i < sides.Count; i++)
                {
                    Console.Write($"Enter size of the {i+1} side: ");
                    sides[i] = double.Parse(Console.ReadLine());
                }
                Console.Clear() ;
                Console.WriteLine(ser.Triangle(sides[0], sides[1], sides[2]));
            }
            else if (name.ToLower() == ser.NamesOfFigure[1])
            {
                Console.Write("Enter size of the radius: ");
                double r = double.Parse(Console.ReadLine());

                Console.Clear();
                Console.WriteLine(ser.Circle(r));
            }
        }

    }
}
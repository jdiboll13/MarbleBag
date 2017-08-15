using System;

namespace MarbleBag
{
    class Program
    {
        public class MarbleBag
        {
            public int NumRedMarbles { get; set; }
            public int NumGreenMarbles { get; set; }
            public int NumBlueMarbles { get; set; }

            public MarbleBag(int red, int green, int blue)
            {
                NumRedMarbles = red;
                NumGreenMarbles = green;
                NumBlueMarbles = blue;
            }
            public int getTotalNumberOfMarbles() => NumRedMarbles + NumGreenMarbles + NumBlueMarbles;
            public int removeAllGreenMarbles() => NumGreenMarbles = 0;

        }
        static void Main(string[] args)
        {
            MarbleBag marbleBag = new MarbleBag(3, 1, 2);

            Console.WriteLine();

            marbleBag.NumBlueMarbles = 5;

            if (marbleBag.getTotalNumberOfMarbles() == 9)
            {
                Console.WriteLine("Total is 9, as expected");
            }
            else
            {
                Console.WriteLine("PANIC!!!");
            }

            marbleBag.removeAllGreenMarbles();

            if (marbleBag.getTotalNumberOfMarbles() == 8)
            {
                Console.WriteLine("Total is 8, as expected");
            }
            else
            {
                Console.WriteLine("Panic even more!!!");
            }
        }
    }
}

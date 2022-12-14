using System;
using CS_LABS.SUP_CLASSES;
using Math = CS_LABS.SUP_CLASSES.Math;
namespace CS_LABS.LABS
{ public class Quest1
    { private readonly Math _math = new Math();
        private readonly Labs _labs = new Labs();
        public void Main()
        { Console.WriteLine("Choose a work number: ");
            new Quest1().GetType().GetMethod($"Work_{_labs.Math.ToInt(Console.ReadLine())}")?.
                Invoke(new Quest1(), null); }
        public void Work_1()
        { Console.WriteLine("This work where u should type a value of variable X:");
                Console.WriteLine("X: ");
                var x = _math.ToDouble(Console.ReadLine());
            Console.WriteLine("Answer: ");
            Console.Write(2 * System.Math.Atan(3 * x) * (-System.Math.Sqrt(x)) -
                          (1 / 12.0 * System.Math.Pow(x, 2) + 7 * x - 5)); }
        public void Work_2()
        { var cords = new double[2, 2];
            Console.WriteLine("This work where u should type a values of coordinates dot X, Y and circle X, Y and his radius:");
            for (var i = 0; i < 2; i++)
            { Console.WriteLine(i == 0 ? "Type Dot coordinates:" : "Type Circle coordinates:");
                for (var j = 0; j < 2; j++)
                { cords[i, j] = _math.ToDouble(Console.ReadLine()); }
            }
            Console.WriteLine("Circle radius: ");
                double r = _math.ToInt(Console.ReadLine());
            Console.WriteLine(_math.CircleCheck(cords, r)); }
        public void Work_3()
        { Console.WriteLine("In this work u should type a year and he will be converted to old Japan format:");
                var year = _math.ToInt(Console.ReadLine());
                string[] yearNames =
                { "Rat", "Cow", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Ship", "Monkey", 
                    "Chicken", "Dog", "Pig" };
            if (year > 0) Console.WriteLine($"This year is called like {yearNames[year % 12]}."); }
        public void Work_4()
        { Console.WriteLine("Type scholarship: ");
            var scholarship = _math.ToDouble(Console.ReadLine());
            Console.WriteLine("Type start every month spending: ");
            var spending = _math.ToDouble(Console.ReadLine());
            double budgetDeficit = 0;
                if (scholarship > spending) {
                    Console.WriteLine("Scholarship is higher then spending!"); }
                else
                { for (var i = 0; i < 10; i++)
                    { spending += .03d * spending;
                            budgetDeficit += (spending - scholarship); }
                    Console.WriteLine(budgetDeficit + $" needs to be taken from parents with {spending} " +
                                      $"every month spending"); }
        }
    }
}
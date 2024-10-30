using System;

namespace _2_проба
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть 1 для виконання операцій з класу TCircle");
            Console.WriteLine("Введіть 2 для виконання операцій з класу TCone:");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    TCircle circle_1 = new TCircle();
                    circle_1.Input();

                    TCircle circle_2 = new TCircle(circle_1);
                    circle_2.Input();

                    circle_1.CircleMethods();
                    circle_2.CircleMethods();

                    Console.WriteLine(circle_1);
                    circle_1.Output();

                    Console.WriteLine(circle_2);
                    circle_2.Output();

                    Compare(circle_1, circle_2);

                    Console.WriteLine(circle_1);
                    circle_1.DisplayResRadii(circle_2);

                    Console.WriteLine();

                    Console.WriteLine(circle_2);
                    circle_2.DisplayResRadii(circle_1);

                    Delay();
                    break;
                case 2:
                    Console.Clear();
                    TCone cone_1 = new TCone();
                    cone_1.Input_();
                    Console.Clear();

                    TCone cone_2 = new TCone();
                    cone_2.Input_();
                    Console.Clear();

                    cone_1.CircleMethods();
                    cone_2.CircleMethods();

                    Console.WriteLine(cone_1);
                    cone_1.OutputRes();

                    Console.WriteLine(cone_2);
                    cone_2.OutputRes();

                    //  bool resCompare = cone_1.Equals(cone_2);
                    CompareCone(cone_1, cone_2);

                    Console.WriteLine(cone_1);
                    cone_1.DisplayOperatorResults(cone_2);

                    Console.WriteLine(cone_2);
                    cone_2.DisplayOperatorResults(cone_1);

                    Delay();
                    break;
                default:
                    Console.WriteLine("Choose other option");
                    Delay();
                    break;
            }
        }

        static void Delay()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        static void Compare(TCircle circle_1, TCircle circle_2)
        {
            if (circle_1.GetHashCode() == circle_2.GetHashCode())
            {
                Console.WriteLine("Кола рівні");
            }
            else
            {
                Console.WriteLine("Кола різні");
            }
            Console.WriteLine();
            Console.WriteLine("///////////////////////////////");
        }
        static void CompareCone(TCone cone_1, TCone cone_2)
        {
            Console.WriteLine();
            if (cone_1.GetHashCode() == cone_2.GetHashCode())
            {
                Console.WriteLine("Конуси рівні");
            }
            else
            {
                Console.WriteLine("Конуси різні");
            }
            Console.WriteLine();
            Console.WriteLine("///////////////////////////////");
        }





    }
}

using System;

namespace _2_проба
{
    public class TCircle 
    {
        double radius;
        double angle;

        public double circleArea { get; set; }
        public double sectorArea { get; set; }
        public double circumf { get; set; }

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Радіус має бути  більше ніж нуль");
                }

                else
                {
                    radius = value;
                }
            }

        }
        public double Angle
        {
            get
            {
                return angle;
            }
            set
            {
                if (value < 0 || value > 360)
                {
                    throw new ArgumentException("Кут має бути більше за нуль та менше 360");
                }
                else
                {
                    angle = value;
                }
            }
        }
        public TCircle()
        {
            Radius = 1;
            Angle = 1;

        }
        public TCircle(double radius, double angle)
        {
            Radius = radius;
            Angle = angle;
        }
        public TCircle(double radius)
        {
            Radius = radius;
        }
        public TCircle(TCircle otherCircle)
        {
            Radius = otherCircle.Radius;
            Angle = otherCircle.Angle;

        }

        public double CircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public double SectorArea(double radius, double angle)
        {
            return (Math.PI * Math.Pow(radius, 2) * angle) / 360;
        }
        public double Circumference(double radius)
        {
            return 2 * Math.PI * radius;
        }
       

       public  int Compare( TCircle circle_2)
        {
            if (Radius > circle_2.Radius)
            {
                return 1;
            }
            else if (Radius < circle_2.Radius)
            {
                return -1;
            }
            return 0;

        }
        public static TCircle operator +(TCircle circle_1, TCircle circle_2)
        {
            double sumRadius = circle_1.Radius + circle_2.Radius;
            TCircle res = new TCircle(sumRadius);


            return res;
        }
        public static TCircle operator -(TCircle circle_1, TCircle circle_2)
        {
            double diffRadius = circle_1.Radius - circle_2.Radius;
            return new TCircle(diffRadius);
        }
        public static TCircle operator *(TCircle circle, double num)
        {
            double multiply = circle.Radius * num;
            return new TCircle(multiply);

        }
        public static TCircle operator *(double num, TCircle circle)
        {
            double multiply = circle.Radius * num;
            return new TCircle(multiply);
        }
        public virtual void CircleMethods()
        {
            circleArea = CircleArea(Radius);
            sectorArea = SectorArea(Radius, Angle);
            circumf = Circumference(Radius);
        }
        public override string ToString()
        {
            return $"Коло з радіусом: {Radius} та кутом сектора: {Angle}";
        }
        public void Input()
        {
            double radius;
            Console.WriteLine("Введіть радіус кола:");
            while (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
            {
                Console.WriteLine("Невірний формат або радіус має бути більше нуля. Спробуйте ще раз.");
            }
            Radius = radius;

            double angle;
            Console.WriteLine("Введіть кут сектора:");
            while (!double.TryParse(Console.ReadLine(), out angle) || angle < 0 || angle > 360)
            {
                Console.WriteLine("Невірний формат або кут сектора має бути в межах від 0 до 360. Спробуйте ще раз.");
            }
            Angle = angle;
            Console.Clear();
        }
        public void Output()
        {

            Console.WriteLine($"Площа круга:{circleArea}");
            Console.WriteLine($"Площа сектора:{sectorArea}");
            Console.WriteLine($"Довжина кола:{circumf}");
            Console.WriteLine();

        }
        public void DisplayResRadii(TCircle circle)
        {
            Console.WriteLine($" {Radius} + {circle.Radius} = " + (Radius + circle.Radius));
            Console.WriteLine($" {Radius} - {circle.Radius} = " + Math.Abs(Radius - circle.Radius));

            Console.WriteLine("Введіть число на яке помножити радіус і навпаки:");
            double num = int.Parse(Console.ReadLine());
            Console.WriteLine($" {Radius} * {num} = " + (Radius * num));
            Console.WriteLine($" {num} * {Radius} = " + (num * Radius));
        }

    }
}

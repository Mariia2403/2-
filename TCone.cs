using System;

namespace _2_проба
{
    public class TCone : TCircle 
    {
        double height;

        public double res_1 { get; set; }
        public double res_2 { get; set; }

        public double volume { get; set; }

       

        public TCone()
        {
            height = 1;
        }
        public TCone(double answer_1, double answer_2)
        {
            res_1 = answer_1;
            res_2 = answer_2;
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Висота має бути більше нуля");
                }
                else
                if (value == 0)
                {
                    throw new ArgumentException("Висота відсутня");
                }
                {
                    height = value;
                }
            }

        }
        public double ConeVolume()
        {

            return (Math.PI * Radius * Radius * height) / 3;

        }
        public static TCone operator +(TCone cone_1, TCone cone_2)
        {
            double sumRadius = cone_1.Radius + cone_2.Radius;
            double sumHight = cone_1.height + cone_2.height;
            TCone res = new TCone(sumRadius, sumHight);

            return res;
        }
        public static TCone operator -(TCone cone_1, TCone cone_2)
        {
            double diffRadius = cone_1.Radius - cone_2.Radius;
            double diffHight = cone_1.height - cone_2.height;
            TCone res = new TCone(diffRadius, diffHight);
            return res;
        }

        public static TCone operator *(TCone cone_1, TCone cone_2)
        {
            double multiply_1 = cone_1.height * cone_2.Radius;
            double multiply_2 = cone_1.Radius * cone_2.height;

            TCone res = new TCone(multiply_1, multiply_2);
            return res;
        }

        public override void CircleMethods()
        {
            base.CircleMethods();
            volume = ConeVolume();
        }
        public void Input_()
        {
            double hight;
            base.Input();
            Console.WriteLine("Висоту:");
            while (!double.TryParse(Console.ReadLine(), out hight) || hight < 0)
            {
                Console.WriteLine("Невірний формат або висота має бути більше 0. Спробуйте ще раз.");
            }
            height = hight;
            Console.Clear();
        }
        public void OutputRes()
        {

            base.Output();
            Console.WriteLine($"Об'єм конуса: {volume}");
            Console.WriteLine();
            Console.WriteLine("//////////////////////////");
        }
        public void DisplayOperatorResults(TCone cone)
        {
            Console.WriteLine($" {Radius} + {cone.Radius} = " + (Radius + cone.Radius));
            Console.WriteLine($" {height} + {cone.height} = " + (height + cone.height));

            Console.WriteLine($" {Radius} - {cone.Radius} = " + Math.Abs(Radius - cone.Radius));
            Console.WriteLine($" {height} - {cone.height} = " + Math.Abs(height - cone.height));

            Console.WriteLine("Множення висоти конуса на радіус іншого конуса");
            Console.WriteLine($" {height} * {cone.Radius} = " + Math.Abs(height * cone.Radius));
            Console.WriteLine($" {cone.Radius} * {height} = " + Math.Abs(cone.Radius * height));
            Console.WriteLine();
        }
        public override string ToString()
        {
            return $"Конус, з висотою {height}, радіусом {Radius} та кутом сектора {Angle}, має такі результати: ";
        }

        public override int GetHashCode()
        {
            return volume.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;
            TCone c = (TCone)obj;

            return (volume == c.volume);
        }

    }
}

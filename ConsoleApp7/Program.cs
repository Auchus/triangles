using System;
using System.Globalization;


namespace ConsoleApp7
{
    class Program
    {

        static void Main(string[] args)
        {
            /*Console.WriteLine("написать стороны треугольника");
            Console.WriteLine("написать первую сторону треугольника");
            string a = Convert.ToString(Console.ReadLine());
            Console.WriteLine("написать вторую сторону треугольника");
            string b = Convert.ToString(Console.ReadLine());
            Console.WriteLine("написать третью сторону треугольника");
            string c = Convert.ToString(Console.ReadLine());
            try
            {
                int aa = Convert.ToInt32(a);
                int bb = Convert.ToInt32(b);
                int cc = Convert.ToInt32(c);
                

                if (aa > 0 && bb > 0 && cc > 0)
                {
                    if (aa + bb > cc || bb + cc > aa || aa + cc > bb)
                    {
                        if (aa == bb & bb == cc && cc == aa)
                        {
                            double S = (Math.Pow(aa, 2) * Math.Sqrt(3) / 4);
                            Console.WriteLine("стороны треугольника = " + aa + ", " + bb + ", " + cc);
                            Console.WriteLine("Площадь треугольника = " + Math.Round(S,2));
                            Console.WriteLine("Треугольник равносторонний"); 
                        }
                        if (aa == bb || bb == cc || cc == aa)
                        {
                            double p = (aa + bb + cc) / 2;
                            double s = Math.Sqrt(p * (p - aa) * (p - bb) * (p - cc));
                            Console.WriteLine("стороны треугольника = " + aa + ", " + bb + ", " + cc);
                            Console.WriteLine("Площадь треугольника = " + Math.Round(s, 2));
                            Console.WriteLine("Треугольник равнобедренный");
                        }
                        if (aa != bb && bb != cc && cc != aa)
                        {
                            double p = (aa + bb + cc) / 2;
                            double s = Math.Sqrt(p * (p - aa) * (p - bb) * (p - cc));
                            Console.WriteLine("стороны треугольника = " + aa + ", " + bb + ", " + cc);
                            Console.WriteLine("Площадь треугольника = " + Math.Round(s, 2));
                            Console.WriteLine("Треугольник разносторонний");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("непредвиденная ошибка. 0 нельзя использовать(");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("неверные данныею символы запрещенно использовать");
                Environment.Exit(0);
            }*/


            /*Задание 2*/



            Console.WriteLine("написать стороны треугольника");
            Console.WriteLine("написать первую сторону треугольника");
            string a = Convert.ToString(Console.ReadLine());
            Console.WriteLine("написать вторую сторону треугольника");
            string b = Convert.ToString(Console.ReadLine());
            Console.WriteLine("написать третью сторону треугольника");
            string c = Convert.ToString(Console.ReadLine());
            try
            {
                int aa = Convert.ToInt32(a);
                int bb = Convert.ToInt32(b);
                int cc = Convert.ToInt32(c);


                if (aa > 0 && bb > 0 && cc > 0)
                {
                    if (aa + bb > cc || bb + cc > aa || aa + cc > bb)
                    {
                        if ((Math.Pow(aa, 2) + Math.Pow(bb,2)) < Math.Pow(cc,2))
                        {
                            double p = (aa + bb + cc) / 2;
                            double s = Math.Sqrt(p * (p - aa) * (p - bb) * (p - cc));
                            Console.WriteLine("стороны треугольника = " + aa + ", " + bb + ", " + cc);
                            Console.WriteLine("Площадь треугольника = " + Math.Round(s, 2));
                            Console.WriteLine("Треугольник тупоугольный");
                        }
                        if ((Math.Pow(aa, 2) + Math.Pow(bb, 2)) > Math.Pow(cc, 2))
                        {
                            double p = (aa + bb + cc) / 2;
                            double s = Math.Sqrt(p * (p - aa) * (p - bb) * (p - cc));
                            Console.WriteLine("стороны треугольника = " + aa + ", " + bb + ", " + cc);
                            Console.WriteLine("Площадь треугольника = " + Math.Round(s, 2));
                            Console.WriteLine("Треугольник остроугольный");
                        }
                        if ((Math.Pow(aa, 2) + Math.Pow(bb, 2)) == Math.Pow(cc, 2))
                        {
                            double p = (aa + bb + cc) / 2;
                            double s = Math.Sqrt(p * (p - aa) * (p - bb) * (p - cc));
                            Console.WriteLine("стороны треугольника = " + aa + ", " + bb + ", " + cc);
                            Console.WriteLine("Площадь треугольника = " + Math.Round(s, 2));
                            Console.WriteLine("Треугольник прямоугольный");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("непредвиденная ошибка. 0 нельзя использовать(");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("неверные данные. символы запрещенно использовать");
                Environment.Exit(0);
            }

        }
    }
}


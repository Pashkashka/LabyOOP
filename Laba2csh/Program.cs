using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static System.Console;
namespace Laba2csh
{
    public abstract class Series
    {

        public virtual int GetElement(int i)
        {
            return 0;
        }
        
        public abstract int GetSum(int n);


    }
    //Linear A = new Series();
     public class Linear:   Series {
        private int a;
        private int d;

        public Linear(int a, int d)
        {
            this.a = a;
            this.d = d;
        }

        public override int GetElement(int i)
        {
            return a + (i - 1) * d;
        }

        public override int GetSum(int n)
        {
            return (2 * a + (n - 1) * d) * n / 2;
        }

        public void PrintElements(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(GetElement(i) + " ");
            }
            Console.WriteLine();
        }



    }
    public class Exponential: Series

    {
        private int a;
        private int q;

        public Exponential(int a, int q)
        {
            this.a = a;
            this.q = q;
        }

        public override int GetElement(int i)
        {
            return a *(int) Math.Pow(q, i - 1);
        }

        public override int GetSum(int n)
        {
            return a * ((int)Math.Pow(q, n) - 1) / (q - 1);
        }

        public void PrintElements(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(GetElement(i) + " ");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            WriteLine("1. Линейная прогрессия");
            WriteLine("2. Геометрическая прогрессия");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    WriteLine(" Введите a0");
                    int a = Convert.ToInt32(Console.ReadLine());
                   WriteLine(" Введите n ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    WriteLine("\nразность= ");
                     int d = Convert.ToInt32(Console.ReadLine());
                    Linear series =new Linear(a, d);
                    series.PrintElements(n);
                    Console.WriteLine("Сумма первых " + n + " элементов арифметической прогрессии: " + series.GetSum(n));

                    break;
                case 2:
                    WriteLine(" Введите b0");
                    int b = Convert.ToInt32(Console.ReadLine());
                    WriteLine(" Введите n ");
                     n = Convert.ToInt32(Console.ReadLine());
                    WriteLine("\nзнаменатель= ");
                    int q = Convert.ToInt32(Console.ReadLine());
                    Exponential series1 = new Exponential(b, q);
                    series1.PrintElements(n);

                    WriteLine("Сумма первых " + n + " элементов геометрической прогрессии: " + series1.GetSum(n));


                    break;
            }
            ReadLine(); 
        }
           



        
    }
}

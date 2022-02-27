using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1    
            AboutFriend();
            //Task 2
            Console.WriteLine("please entre the name...");
            string name = Console.ReadLine();
            AboutFriend(name);
            //Task 3
            Console.WriteLine("Please entre the first number...");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("please enttre second number...");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("the sum of numbers = " + Sum(a, b));

            //TAsk 4
            Console.WriteLine("Please entre the text");
            string d = Console.ReadLine();
            SpaceString(d);
            // Task5
            Console.WriteLine("Please entre the first number...");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("please enttre second number...");
            int l = int.Parse(Console.ReadLine());

            Console.WriteLine(SumArray(s, l));

            //TAsk 6
            Console.WriteLine("Please entre the first number...");
            int aaa = int.Parse(Console.ReadLine());
            Console.WriteLine("please enttre second number...");
            int bbb = int.Parse(Console.ReadLine());

            SwapNum(aaa, bbb);

            //Task 7
            Console.WriteLine("Please entre the first number...");
            int aaaa = int.Parse(Console.ReadLine());
            Console.WriteLine("please enttre second number...");
            int bbbb = int.Parse(Console.ReadLine());

            Console.WriteLine(PowNum(aaaa, bbbb));

            //Task 8
            Console.WriteLine("Please entre the  number...");
            int x = int.Parse(Console.ReadLine());
            FibonachiNum(x);

            //Task 9
            Console.WriteLine("Please entre the  number...");
            int y = int.Parse(Console.ReadLine());
            PrimeNum(y);

            //Task 10
            Console.WriteLine("Please entre the  number...");
            int f = int.Parse(Console.ReadLine());
            NumSum(f);


            //task 11
            Console.WriteLine("Please entre the  number...");
            int g = int.Parse(Console.ReadLine());
            MultSum(g);

            //Task 12
            Console.WriteLine("Please entre the  number...");
            int h = int.Parse(Console.ReadLine());
            Fibona(h);

            //Task FUncMeth

            Console.WriteLine(FuncMeth(8, 9));

            //TAsk muchFunc

            int[] arr = { ArrayFunc(10,9), ArrayFunc1(9,7), ArrayFunc2(4,5), ArrayFunc3(9,3) };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
        //Task 1
        public static void AboutFriend()
        {
            Console.WriteLine("Welcome Friends! Have a nice day!");
        }

        //Task 2
        public static void AboutFriend(string name)
        {
            Console.WriteLine("Welcome friend " + name + " !Have a nice day!");
        }
        //Task 3

        public static double Sum(double a, double b)
        {
            return a + b;
        }


        //Task 4
        public static void SpaceString(string a)
        {
            int b = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == ' ')
                {
                    b++;
                }
            }
            Console.WriteLine(a + ": contains " + b + " spaces");
        }

        //Task 5

        public static int SumArray(int a, int b)
        {
            int sum = 0;
            int[,] array = new int[a, b];
            for (int i = 0; i < b + 1; i++)
            {
                for (int j = 0; j < a + 1; j++)
                {
                    Console.WriteLine("please entre the numbers...");
                    array[i, j] = int.Parse(Console.ReadLine());
                    sum += array[i, j];
                }

            }
            return sum;
        }

        //Task 6

        public static void SwapNum(int a, int b)
        {
            Console.WriteLine("Now the 1st number is : " + b + " , and the 2nd number is :" + a);
        }

        //Task 7

        public static double PowNum(int a, int b)
        {
            return Math.Pow(a, b);
        }

        //TAsk 8

        public static void FibonachiNum(int a)
        {
            int sum = 0; int b = 1; int c = 1;
            Console.Write(sum + "," + b + "," + c + ",");
            while (sum < a)
            {
                sum = b + c;
                Console.Write(sum + ",");
                b = c;
                c = sum;

            }
            if (sum == a)
            {
                Console.WriteLine("number of Fibonachi");
            }
            else
            {
                Console.WriteLine(" number doesn't exist in Fibonachi");
                ;
            }
        }

        //Task 9

        public static void PrimeNum(int a)
        {
            bool numPrime = false;
            for (int i = 2; i < a / 2; i++)
            {
                if (a % i == 0)
                {
                    numPrime = true;
                }

            }
            if (!numPrime)
            {
                Console.WriteLine("prime num");
            }
            else
            {
                Console.WriteLine("not prime");
            }

        }

        //Task 10

        public static void NumSum(int a)
        {
            int sum = 0;
            while (a > 0)
            {

                int b = a % 10;
                sum = sum + b;
                a = a / 10;

            }
            Console.WriteLine(sum);
        }
        //Task 11
        public static void MultSum(int a)
        {
            int mult = 1;
            for (int i = a; i >= 1; i--)
            {
                mult = mult * i;
            }
            Console.WriteLine(mult);
        }

        //Task 12
        public static void Fibona(int a)
        {
            int sum = 0; int b = 1; int c = 1; int g = 3;
            Console.Write(sum + "," + b + "," + c + ",");
            while (sum < a)
            {
                sum = b + c;
                g++;
                Console.Write(sum + ",");
                b = c;
                c = sum;

            }
            if (sum == a)
            {
                Console.WriteLine("number of Fibonachi index = " + g);
            }
            else
            {
                Console.WriteLine(" number doesn't exist in Fibonachi");

            }

        }
        //last ex

        public static int Func()
        {
            int a = 8;
            return a;
        }

        //public static string Func() // compile error
        //{
        //    return "Hello";
        //}

        public static int FuncMeth(int a, int b)
        {  
               int YesimInch(int c, int x)
            {
               
                int sub = c - x;
                return sub;
            }
            return a + b + (YesimInch(a, b));
        }

        public static int ArrayFunc(int a, int b)
        {
           return a + b;
         
        }

        public static int ArrayFunc1(int a, int b)
        {
           return a - b;
            
        }
        public static int ArrayFunc2(int a, int b)
        {
            return  a * b;
           
        }
        public static int ArrayFunc3(int a, int b)
        {
            return  a / b;
            
        }

    }
}

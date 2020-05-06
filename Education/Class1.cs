using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Education
{
    class Class1
    {
        static void Main()
        {
            // Class1 test = new Class1();
            // test.Noknod();
            //Print(GetSquare(418));

            
            chislonaoborot(123);
        }

       public static void chislonaoborot(int chislo)
        {
        //    string str = chislo.ToString();
        //    int i = str.Length-1;
        //    string vozvrat = null;
        //    while (i >= 0)
        //    {
        //        vozvrat += str[i];
        //        i--;
        //    }
        //    return vozvrat;
        string sss = chislo.ToString();
            Console.WriteLine(sss);
            char[] ch = sss.ToCharArray();
            Array.Reverse(ch);
            Console.WriteLine(new string(ch));
        }
        void Noknod()
        {
            Console.WriteLine("Введите первое число");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int second = Convert.ToInt32(Console.ReadLine());
            int max = first > second ? first : second;
            int min = first < second ? first : second;
            int nod;
            nod = max;
            int nok = min;
            bool k = true;
            bool d = true;
            Console.WriteLine("в max находиться - " + max);
            Console.WriteLine("в min находиться - " + min);
            for (int i = 2, a = min;
                (i <= min) & (a >= 2);
                i++, a--) //(nok = 1; nok != max & (nod == 1); nok++, nod--) 
            {
                if (min % i == 0 && max % i == 0 && k)
                {
                    Console.WriteLine("NOK = " + i);
                    k = false;
                }
                else Console.WriteLine("Нет наименьшего обшего кратного");

                if (max % a == 0 && min % a == 0 && d)
                {
                    Console.WriteLine("Nod = " + a);
                    d = false;
                }
                else Console.WriteLine("Нет наибольшего общего делителя");
            }

            Console.Write("smth wrong");
            Console.ReadKey();
        }

        static void Print(string arg)
        {
            Console.WriteLine(arg);
        }

        static string GetSquare(int a)
        {
            return Math.Sqrt((double) a).ToString();
        }
    }
}
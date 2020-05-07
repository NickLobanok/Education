using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Education
{
    class Class1
    {
        static void Main()
        {
            // Class1 test = new Class1();
            // test.Noknod();
            //Print(GetSquare(418));

            
           // chislonaoborot(123);
           // Console.WriteLine(chasuGradusi());
           //JaggedArray();
           otrezok(96);
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
            string c = new string(ch);
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
        public static int chasuGradusi()
        {
            string chas = null;
            int prov = 0;
            int result = 0;
            int v1Chasu = 30;
            Console.WriteLine("введите часы");
             chas = Console.ReadLine();
            try
            {
                prov = int.Parse(chas);
            }
            catch (FormatException E)
            {
                Console.WriteLine("not number");
            }

            if (prov > 0 | prov < 24)
            {
                if (prov > 12)
                {
                    prov = prov - 12;
                    result = v1Chasu * prov;
                }
                else
                {
                    result = v1Chasu * prov;
                }
            }
            else
            {
                Console.WriteLine("Ввели неверное число");
            }

            return result;
        }

        public static void JaggedArray()//создание заполнение отображение ступенчатого массива
        {
            int[][] arr = new int[4][];
            arr[0] = new int[5];
            arr[1] = new int[6];
            arr[2] = new int[7];
            arr[3] = new int[3];
            Console.WriteLine(arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"заполняем уровень : {i}");
                Console.WriteLine();
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = j;
                }
            }
            Console.WriteLine("Отобразим всю созданную прелесть");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]+" ");
                }
                Console.WriteLine();
            }

            int[,] arr2 = { {1, 2, 3},{2,1,3}};

            string str = String.Join(",", arr2);
            Console.WriteLine(str);
        }

        public static void otrezok(int a)
        {
            int doPriamoia = 0;
            int tochka = a;
            int nachalo = 8;
            int konec = 32;
            if (nachalo - tochka < 0 & konec < tochka)
            {
                doPriamoia = tochka - konec;
                Console.WriteLine(doPriamoia);
            }
           else if (nachalo - tochka > 0)
            {
                doPriamoia = nachalo - tochka;
                Console.WriteLine(doPriamoia);
            }
            else Console.WriteLine("the point on the line");
        }
    }
    
}
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
            
            Console.ReadKey();
        }

        public static void OddInTime()
        {
            // Мой логичный способ
            int iter = 0;
            string str = null;
            int[] arr = { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };
            HashSet<int> newa = new HashSet<int>(arr);
            foreach (int a in newa)
            {
                iter = 0;
                Console.WriteLine($"Следующее число на проверке {a}");
                for (int i = 0; i < arr.Length; i++)
                {
                    if (a == arr[i])
                    {
                        iter++;
                    }
                }
                Console.WriteLine($"{a} повторяется {iter} раз(а)");
                if ((iter % 2 != 0) & iter > 1)
                {
                    str = iter.ToString();
                    Console.WriteLine($"!!!!! Искомое знаечение {str}\n");
                }

            }
            // second Method
            int iter2 = 0;
            Console.WriteLine("Исполнение через исключающее или XOR");
            int[] arr2 = { 2, 3, 8, 2, 3 };
            for (int i = 0; i < arr.Length; i++)
            {
                //подразрядный исключающий или 
                iter2 ^= arr[i];
                //Third Method
                // return seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key; самый умный способ - пока мне не понятен
            }
            Console.WriteLine(iter2);
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

        public static void JaggedArray() //создание заполнение отображение ступенчатого массива
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
                    Console.Write(arr[i][j] + " ");
                }

                Console.WriteLine();
            }

            int[,] arr2 = {{1, 2, 3}, {2, 1, 3}};

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

        private static string GetMinX(int a, int b, int c, out double first, out double second)
        {
            double x1 = 0.0;
            double x2 = 0.0;
            double rezult = 0.0;
            double d = 0.0;
            first = x1;
            second = x2;
            if (a < 0) return "Impossible";
            else
            {
                d = b * b - 4 * a * c;
                if (d == 0)
                {
                    rezult = -b / 2 * a;
                    x1 = rezult;
                    Console.WriteLine("есть тоько одно решение");
                }
                else if (d < 0)
                {
                    return "Impossible";
                }
                else
                {
                    x1 = (-b - (System.Math.Sqrt(d))) / 2 * a;
                    x2 = (-b + (System.Math.Sqrt(d))) / 2 * a;
                    if (x1 < x2)
                    {
                        rezult = x1;
                    }
                    else rezult = x2;
                }

            }

            first = x1;
            second = x2;
            return rezult.ToString();
            // так можно вернуть строковое представление числа
        }

        /// <summary>
        /// Перегруженыый метод ShowBit показывает числа в двоичном представлении
        /// </summary>
        /// <param name="num"></param>
        static void ShowBit(int num, int positive)
        {
            String res = null;
            String resP = null;
            for (int i = 128; i > 0; i = i / 2)
            {
                if ((num & i) == 0)
                {
                    res += "0";
                }
                else
                {
                    res += "1";
                }

                if ((positive & i) == 0)
                {
                    resP += "0";
                }
                else
                {
                    resP += "1";
                }

            }

            Console.WriteLine($"Подразрядное значени введенного числа {num} при типе данных int = " + res);
            Console.WriteLine("Средствами C# " + Convert.ToString(num, 2));
            Console.WriteLine($"Подразрядное значени введенного числа {positive} при типе данных int = " + resP);
            Console.WriteLine("Средствами C# " + Convert.ToString(positive, 2));
        }

        // метод перегружен и при введение числа типа short примениться этот метод
        static void ShowBit(short num)
        {

        }
        static void FromStrtoBit(String str)
        {
            double result = 0;
            double ex = 0;
            for (int i = str.Length; i > 0; i--)
            {
                if (str[i-1] == '1')
                    result += Math.Pow(2, ex);
                ex++;
            }
            Console.WriteLine(result);
        }

        static bool IsIsogram(string str)
        {
            return str.ToLower().Distinct().Count() == str.Length;
        }
    }

    class Stuck
        {
            private int size;
            private int numm;
            private int[] arr;

            public Stuck(int size)
            {
                this.size = size;
                arr = new int[size];
                numm = 0;
            }

            public void put(int i)
            {
                if (numm == arr.Length)
                {
                    Console.WriteLine("stack is full");
                    return;
                }

                arr[numm] = i;
                Console.WriteLine("in the stack now " + arr[i]);
                numm++;
            }

            public void pop()
            {
                if (numm == 0)
                {
                    Console.WriteLine("Stack is empty");
                    return;
                }

                //Console.WriteLine(string.Join(",",arr));
                Console.WriteLine(arr[numm - 1]);
                numm--;
            }

            public void capacity()
            {
                Console.WriteLine(numm);
            }
        }
    
}
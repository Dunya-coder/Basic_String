using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pa = "";
            string text1 = Console.ReadLine();
            Char [] p = text1.ToArray();
            int length1 = p.Length;
           
            for (int i = 0; i <= (p.Length - 2) / 2; i++)
            {

                if (p[p.Length - i - 1] == p[i])
                {
                    pa = "palindrom";
                }
                else
                {
                    pa = "palindrom emas";
                }

            }
            Console.WriteLine(pa);
            //2
            Console.WriteLine("Temperatura");
            int temperator;
            double kelvin, selsiyus, fahrenheit;
            temperator = Convert.ToInt32(Console.ReadLine());
            kelvin = temperator + 273.15;
            fahrenheit = (9  * temperator/5) + 32;
            Console.WriteLine($"{temperator}-selsiyus \n {kelvin}-kelvin \n {fahrenheit}-farangeyt");

            //3
           /* Console.Write("n:");
            int c=0,n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];
            for(int j=0;j<n;j++)
            {
                a[j] = Convert.ToInt32(Console.ReadLine());
            }
            string tartib;
            Console.WriteLine("tanlang:tartiblangan,teskari tartib:");
            tartib = Console.ReadLine();
            
            switch(tartib)
            {
                case "teskari tartib":
                    for (int j = 0; j < n ; j++)
                    {
                        for (int i = j + 1; i <n; i++)
                            if (a[j] < a[i])
                            {
                                c = a[j];
                                a[j] = a[i];
                                a[i] = c;
                            }
                    }
                    for (int j = 0; j < n; j++)
                    {
                        Console.WriteLine(a[j]);
                    }
                    break;
                case "tartiblangan":
                    for(int j = 0; j < n; j++)
                    {
                        for(int i=j+1;i<n;i++)
                        if (a[j] > a[i])
                        {
                            c = a[j];
                            a[j] = a[i];
                            a[i] = c;
                        }
                    }
                    for(int j=0;j<n;j++)
                    {
                        Console.WriteLine(a[j]);
                    }
                    break;
            }*/
            //4
           
          


                Console.Write("Matnni kiriting: ");
                string text = Console.ReadLine();

                // Simvollarning hisoblagichi
                Dictionary<char, int> charCount = new Dictionary<char, int>();

                // Har bir simvolni sanash
                foreach (char c4 in text)
                {
                    if (charCount.ContainsKey(c4))
                    {
                        charCount[c4]++;
                    }
                    else
                    {
                        charCount[c4] = 1;
                    }
                }

                // Natijalarni chiqarish
                foreach (var kvp in charCount)
                {
                    Console.WriteLine($"'{kvp.Key}': {kvp.Value} martta");
                }
           //2-usul
                // Foydalanuvchidan matnni olish
                Console.Write("Matnni kiriting: ");
                string text2 = Console.ReadLine();

                // Simvollarning hisoblagichini yaratish uchun massiv
                char[] characters = text2.ToCharArray();
                int length = characters.Length;

                // Simvollarning hisoblagichini saqlash uchun massiv
                bool[] counted = new bool[length];

                // Simvollarning hisobini chiqarish
                for (int i = 0; i < length; i++)
                {
                    // Agar bu simvol allaqachon hisoblangan bo'lsa, davom etamiz
                    if (counted[i])
                        continue;

                    // Har bir simvolni hisoblash
                    char currentChar = characters[i];
                    int count = 1;

                    for (int j = i + 1; j < length; j++)
                    {
                        if (characters[j] == currentChar)
                        {
                            count++;
                            counted[j] = true;
                        }
                    }

                    // Natijalarni chiqarish
                    Console.WriteLine($"'{currentChar}': {count} martta");
                }
            
        

        Console.ReadKey();
            }
        }



    }



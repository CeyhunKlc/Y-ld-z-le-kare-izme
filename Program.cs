using System;

namespace Kare_Cizme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Kenar Sayısına Eşit yıldız sayısı giriniz:");
            int yildiz;
            yildiz = Convert.ToInt16(Console.ReadLine());
             for (int a = 1; a <= yildiz; a++)
            {

                for (int b = 1; b <= yildiz; b++)
                {
                    if (a == 1 || a == yildiz)
                    {
                        Console.Write("* ");
                    }
                    else if (b == 1 || b == yildiz)
                    {
                        Console.Write("* ");
                    }

                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
           
            }        
            
        }
    }
}

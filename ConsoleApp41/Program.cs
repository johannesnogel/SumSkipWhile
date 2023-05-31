using LINQ;
using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali meetod:");
            Console.WriteLine("1. Sum");
            Console.WriteLine("2. SkipWhile");;

            int valik = Convert.ToInt32(Console.ReadLine()); ;

            switch (valik)
            {
                case 1:
                    Sum();
                    break;

                case 2:
                    SkipWhile();
                    break;

                case 3:
                    IfAndElse();
                    break;

                default:
                    Console.WriteLine("Sa ei valinud");
                    break;
            }
        }
        private static void Sum()
        {
            int j, sum = 0;

            Console.Write("\n\n");
            Console.Write("Find the sum of first 10 natural numbers:\n");
            Console.Write("-------------------------------------------");
            Console.Write("\n\n");

            Console.Write("The first 10 natural numbers are: \n");
            for (j = 1; j <= 10; j++)
            {
                sum = sum + j;
                Console.Write("{0} ", j);
            }
            Console.Write("\nThe Sum is: {0}\n", sum);
        }
        private static void SkipWhile()
        {
            Console.WriteLine("----------SkipWhile--------------");
            //näitab kõiki, kellel on neli või vähem tähemärki 
            var skipWhile = PeopleList.peoples.SkipWhile(s => s.Name.Length > 4);

            foreach (var item in skipWhile)
            {
                Console.WriteLine(item.Name);   
            }
        }

        private static void IfAndElse()
        {
            Console.WriteLine("Kui url on vale, siis annab" +
                "veateate. Kui on õige, siis ütleb, " +
                "et kõik on korras");
            Console.WriteLine("Kui on ]ige, siis loob faili " +
                "koos sinu sisestatud tekstiga");
            //kasutada if ja else

            string wrongPath = "V:/Users/Ingvar/Desktop/FileToDesktop.txt";
            string wrightPath = "C:/Users/Ingvar/Desktop/FileToDesktop.txt";

            Console.WriteLine("Tee valik numbriga:");
            Console.WriteLine("1 on vale url");
            Console.WriteLine("2 on õige url");
            string choose = Console.ReadLine();

            if (choose == "1")
            {
                try
                {
                    string inputText = Console.ReadLine();
                    File.WriteAllText(wrongPath, inputText);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ei salevstanud desktopile file kuna " +
                        "seda urli ei ole");
                    Console.WriteLine(ex.Message);
                }
            }
            if (choose == "2")
            {
                string inputText = Console.ReadLine();
                File.WriteAllText(wrightPath, inputText);

                Console.WriteLine("Salvestas edukalt desktopile");
            }
        }
        private static void ForLoop()
        {
            int i, j, rows;

            Console.WriteLine("Numbri püramiid");

            Console.WriteLine("Sisesta ridade arv");

            rows = Convert.ToInt32(Console.ReadLine());


            for (i = 0; i <= rows; i++)
            {
                for (j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    //Console.Write("{0} ", t++);
                    Console.Write("*"); //kui paned selle, siis saad püramiidi
                }
                Console.Write("\n");
            }

            for (i = rows - 1; i >= 1; i--)
            {
                for (j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}

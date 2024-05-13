using System;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace Domaća.zadaća
{ 
    internal class Program
    
    {
        static void Main(string[] args)
        {
            Console.Write("Želite li ispis abecede?");
            string abeceda = Console.ReadLine();

            if (abeceda == " da")
            {
                Console.WriteLine("Evo abeceda - abcčćddžđefghijklmnnjoprsštuvzž");
            }

            if (abeceda == " ne")
            { Console.WriteLine("Za Vas nema abecede!");
            }

            Console.WriteLine("Upišite samoglasnik");
                char ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            { case 'a':
                    Console.WriteLine("Samoglasnik");
                    break;

                case 'e':
                    Console.WriteLine("Samoglasnik");
                    break;

                case 'i':
                    Console.WriteLine("Samoglasnik");
                    break;
                case 'o':
                    Console.WriteLine("Samoglasnik");
                    break;
                case 'u':
                    Console.WriteLine("Samoglasnik");
                    break;
                    default:
                    Console.WriteLine("Nije samoglasnik");
                    break;
                         }

            Console.WriteLine("Sada kada znamo koji su samoglasnici ;-) možemo ih izbaciti. Može?");
            string samoglasnik = Console.ReadLine();
           
            if (samoglasnik == " da")
            { Console.WriteLine("Nastavljamo dalje");
            }
            if (samoglasnik == " ne")
            { Console.WriteLine("Hvala na sudjelovanju.Pozz");
                Console.ReadLine();
            }

            Console.WriteLine("Napišite bilo što...");
                string bilo_što = Console.ReadLine();
            string bez_samoglasnika = " ";
            string str = Regex.Replace(bez_samoglasnika, "[aeiouAEIOU]", " ");
            if (bilo_što == "bilo što")
            { Console.WriteLine("Molim, uozbiljite se!");
            }
            if (bilo_što == " ")
            { Console.WriteLine(str);
            }

            Console.ReadLine();                       
                
                
                }

        }
            
            
            }
       

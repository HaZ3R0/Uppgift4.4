using System;
namespace Uppgift4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string val = "";

                while(val != "3")
                {
                    Console.WriteLine("Välj ett alternativ");
                    Console.WriteLine("1. subtrahera 2 tal");
                    Console.WriteLine("2. dividera 2 tal");
                    Console.WriteLine("3. avsluta programet");
                    val = Console.ReadLine();
                    switch (val)
                    {

                        case "1":
                            Console.WriteLine("Skriv in ett tal");
                            string tal1text = Console.ReadLine();
                            int tal1 = int.Parse(tal1text);
                            Console.WriteLine("Skriv in ett tal till");
                            string tal2text = Console.ReadLine();
                            int tal2 = int.Parse(tal2text);
                            Console.WriteLine("Dina tal subtaherade blir " + (tal1 - tal2));
                            break;

                        case "2":
                            Console.WriteLine("Skriv in ett tal");
                            string tal3text = Console.ReadLine();
                            int tal3 = int.Parse(tal3text);
                            Console.WriteLine("Skriv in ett tal till");
                            string tal4text = Console.ReadLine();
                            int tal4 = int.Parse(tal4text);
                            Console.WriteLine("Dina tal dividerade blir " + (tal3 / tal4));
                            break;

                        case "3":
                            break;

                        default:
                            Console.WriteLine("Du valde inget alternativ");
                            break;
                    }
                }

        }
    }
}
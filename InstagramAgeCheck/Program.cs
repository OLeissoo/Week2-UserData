using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja vanust
            
            Console.WriteLine("Palun sisestage oma vanus");
            int UserAge = Convert.ToInt32(Console.ReadLine());

            //Programm kontrollib, kas kasutaja on vanem kui 13 või 13 aastat vana
            //Kui kasutaja on 13=+, siis ta võib instagrami kasutada
            //Kui kasutaja on <13, siis ta on liiga noor

            if (UserAge > 13)
            {
                Console.WriteLine("Oled piisavalt vana, et Instagrami kontot luua.");
            }
            else if(UserAge < 13)
            {
                Console.WriteLine("Oled liiga noor, et Instagrami kontot luua.");
            }
            else 
            {
                Console.WriteLine("Oledki 13, ehk piisavalt vana, et Instagrami kontot luua.");
            }
            Console.WriteLine("Kena päeva!");

            



        }
    }
}

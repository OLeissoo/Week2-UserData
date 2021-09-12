using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {   //Programm küsib kasutaja vanust
            Console.WriteLine("Palun sisestage oma vanus");

            int UserAge = Convert.ToInt32(Console.ReadLine());

            //Programm arvutab kasutaja sünniaasta
            int DateOfBirth = 2021 - UserAge;

            //Programm annab kasutajale vastuseks ta sünniaasta konsoolis
            Console.WriteLine($"Teie sünniaasta on {DateOfBirth}.");

        
        

        }
    }
}

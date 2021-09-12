using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat;
            //programm arvutab kasutaja vanuse;
            //programm kuvab kasutaja vanuse konsoolis;
            Console.WriteLine("Palun sisestage oma sünniaasta numbritega");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());

            int UserAge = 2021 - YearOfBirth;
            //Console.WriteLine("Oled " + UserAge + " aastat vana.");

            //string interpolation, $

            Console.WriteLine($"Oled {UserAge} aastat vana.");


        }
    }
}

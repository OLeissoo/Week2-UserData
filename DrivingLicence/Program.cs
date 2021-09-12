using System;

namespace DrivingLicence
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja sünniaastat

            Console.WriteLine("Palun sisestage oma sünniaasta numbritega");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());

            //Arvutab kasutaja vanuse   

            int UserAge = 2021 - YearOfBirth;

            //<18, kuva konsoolis "Oled piisavalt vana, et juhilube saada"

            if (UserAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube saada.");
            }
            //>18, kuva konsoolis "Oled liiga noor, et juhilube saada"

            else if (UserAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhilube saada.");
            }

            //=18, kuva konsoolis "Palju õnne! Nüüd saad juhilube taotleda"

            else
            {
                Console.WriteLine("Palju õnne! Nüüd saad juhilube taotleda.");
            }

            Console.WriteLine("Kena päeva!");


        }
    }
}

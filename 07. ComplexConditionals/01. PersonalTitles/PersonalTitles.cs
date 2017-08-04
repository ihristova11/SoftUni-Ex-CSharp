using System;

class PersonalTitles
{
    static void Main()
    {
        double age = double.Parse(Console.ReadLine());
        string gender = Console.ReadLine();
        if (age < 16)
        {
            switch(gender)
            {
                case "m": Console.WriteLine("Master");
                    break;
                case "f": Console.WriteLine("Miss");
                    break;
            }
        }
        else
        {
            switch (gender)
            {
                case "m":
                    Console.WriteLine("Mr.");
                    break;
                case "f":
                    Console.WriteLine("Ms.");
                    break;
            }
        }
    }
}


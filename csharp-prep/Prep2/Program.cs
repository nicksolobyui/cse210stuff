using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string userGrade = Console.ReadLine();

        int number = int.Parse(userGrade);

        if (number >= 90)
        {
            Console.WriteLine("The grade is A");
        }

        else if (number >= 80)
        {
            Console.WriteLine("The grade is B");
        }

        else if (number >= 70)
        {
            Console.WriteLine("The grade is C");
        }

        else if (number >= 60)
        {
            Console.WriteLine("The grade is D");
        }

        else
        {
            Console.WriteLine("The grade is F");
        }

    }
}
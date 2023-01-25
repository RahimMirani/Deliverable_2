//Abdul Rahim Mirani
//Deliverable 2
//1/24/2023


namespace Deliverable_2
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What grade do you expect in ISM 4300: ");

            try
            {
                decimal grade = decimal.Parse(Console.ReadLine());

                string letter;

                if (grade >= 90)
                {
                    letter = "A";
                    Console.WriteLine("Your letter grade is: " + letter);
                }
                else if (grade >= 80)
                {
                    letter = "B";
                    Console.WriteLine("Your letter grade is: " + letter);
                }
                else if (grade >= 70)
                {
                    letter = "C";
                    Console.WriteLine("Your letter grade is: " + letter);

                }
                else if (grade >= 60)
                {
                    letter = "D";
                    Console.WriteLine("Your letter grade is: " + letter);
                }
                else 
                {
                    letter = "F";
                    Console.WriteLine("Your letter grade is: " + letter);
                }
            }
            catch
            {
                Console.WriteLine("Please enter a numeric value");
            }
        }
    }
}
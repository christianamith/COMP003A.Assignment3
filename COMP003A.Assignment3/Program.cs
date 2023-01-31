/*
 * Author:      Christian Amith 
 * Course:      COMP-003A
 * Purpose:     Code for 3rd week assignment
 */

namespace COMP003A.Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numeric to letter grade using an if-else statement");
            Console.Write("Enter a numeric grade (0-100): ");
            string numGradeText = Console.ReadLine();
            int numericGrade = Convert.ToInt32(numGradeText);

            if (numericGrade >= 0 && numericGrade <= 100) // Nested if / else statement
            {
                if (numericGrade >= 90)
                    Console.WriteLine("Letter Grade: A+");
                else if (numericGrade >= 80)
                    Console.WriteLine("Letter Grade: B");
                else if (numericGrade >= 70)
                    Console.WriteLine("Letter Grade: C");
                else if (numericGrade >= 60)
                    Console.WriteLine("Letter Grade: D");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
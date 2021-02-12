using System;

namespace ACA_Homework_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any integer:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("--for computing sum enter 1");
            Console.WriteLine("--for computing multiplication enter 2");
            int x = int.Parse(Console.ReadLine());
            int sum = 0;
            int multiplication = 1;

            if (x != 1 && x != 2)
            {
                Console.WriteLine("Worning! Your number is incorect");
            }
            else if (x == 1)
            {
                for (int i = 1; i <= number; i++)
                {
                    sum += i;
                }
                Console.WriteLine("The sum result is " + sum);
            }
            else if (x == 2)
            {
                for (int i = 1; i <= number; i++)
                {
                    multiplication *= i;
                }
                Console.WriteLine("The multiplication result is " + multiplication);
            }
        }
    }
}

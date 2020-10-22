using System;

namespace Triangle1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1) Enter Triangle Dimensions");
                Console.WriteLine("2) Exit");
                Console.WriteLine("Enter your choice: (1/2): ");
                int choice = 0;
                string choiceString = Console.ReadLine();
                Console.ReadLine();

                if (!int.TryParse(choiceString, out choice))
                {
                    Console.WriteLine("Enter either 1 or 2, program doesn't allow any characters");
                }
                else
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter first side x");

                            if ((!int.TryParse(Console.ReadLine(), out int x)))
                            {
                                Console.WriteLine("program doesn't allow any characters");
                                break;
                            }

                            Console.WriteLine("Enter first side y");

                            if ((!int.TryParse(Console.ReadLine(), out int y)))
                            {
                                Console.WriteLine("program doesn't allow any characters");
                                break;
                            }
                            Console.WriteLine("Enter first side z");
                            if ((!int.TryParse(Console.ReadLine(), out int z)))
                            {
                                Console.WriteLine("program doesn't allow any characters");
                                break;
                            }
                            string result = TriangleSolver.Analyze(x, y, z);

                            Console.WriteLine("Given Points " + result);

                            break;
                        case 2:
                            exit = true;
                            Console.WriteLine("Exiting the application");
                            break;
                        default:
                            Console.WriteLine("Only 1 or 2 are allowed");
                            break;
                    }
                }
            }
            Console.WriteLine("Application closed");
        }
    }
}


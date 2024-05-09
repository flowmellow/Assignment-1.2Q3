// Q.3 Write a menu driven application to perform calculation functions like addition,
// subtraction, multiplication, and division.
// Call them appropriately when user selects the option. Give the user the option to continue or exit the program.

namespace Assignment_1._2Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string readResult;
            do
            {

                Console.WriteLine("Please enter your choice from the menu");
                Console.WriteLine("Enter A for Add");
                Console.WriteLine("Enter S for Subtract");
                Console.WriteLine("Enter M for Multiply");
                Console.WriteLine("Enter D for Divide");
                Console.WriteLine("Enter X to exit program");

                readResult = Console.ReadLine();

                switch (readResult)
                {
                    case "A":
                    case "a":
                        AddMethod();
                        break;
                    case "S":
                    case "s":
                        SubtractMethod();
                        break;
                    case "M":
                    case "m":
                        MultiplyMethod();
                        break;
                    case "D":
                    case "d":
                        DivideMethod();
                        break;
                    case "X":
                    case "x":
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
            while (readResult != "x" && readResult != "X");
        }

        static void AddMethod()
        {
            Console.WriteLine("Please enter two integers");
            Console.WriteLine("Enter integer 1: ");
            int readResult1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter integer 2: ");
            int readResult2 = Convert.ToInt32(Console.ReadLine());
            int sum = readResult1 + readResult2;
            Console.WriteLine();
            Console.WriteLine("The answer is: " + sum);
        }

        static void SubtractMethod()
        {
            Console.WriteLine("Please enter two integers the expression will be int1 - int2");
            Console.WriteLine("Enter integer 1: ");
            int readResult1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter integer 2: ");
            int readResult2 = Convert.ToInt32(Console.ReadLine());
            int minus = readResult1 - readResult2;
            Console.WriteLine();
            Console.WriteLine("The answer is: " + minus);
        }
        static void MultiplyMethod()
        {
            Console.WriteLine("Please enter two integers");
            Console.WriteLine("Enter integer 1: ");
            int readResult1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter integer 2: ");
            int readResult2 = Convert.ToInt32(Console.ReadLine());
            int product = readResult1 * readResult2;
            Console.WriteLine();
            Console.WriteLine("The answer is: " + product);
        }

        static void DivideMethod()
        {
            Console.WriteLine("Please enter two integers the expression will be int1 / int2");
            Console.WriteLine("Enter integer 1: ");
            double readResult1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter integer 2: ");
            double readResult2 = Convert.ToDouble(Console.ReadLine());
            double division = readResult1 / readResult2;
            Console.WriteLine();
            Console.WriteLine("The answer is: " + division);
        }
    }
    
}

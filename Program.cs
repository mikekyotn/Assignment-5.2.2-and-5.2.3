namespace Assignment_5._2._2_and_5._2._3
{
    //Write a program in C# Sharp to print the first n natural number using recursion.
    //Write a program in C# Sharp to print numbers from n to 1 using recursion.
    //Status: Complete
    internal class Program
    {
        static void Main(string[] args)
        {
            uint n = GetNumberToPrint();

            Console.WriteLine($"Print first {n} natural numbers with recursion:");
            PrintFirstNaturalNumbers(n);
            Console.WriteLine();
            
            Console.WriteLine($"Print number from {n} to 1 with recursion:");
            PrintNumbersDescending(n);  
            Console.WriteLine();
            Console.ReadKey();

        }

        static void PrintFirstNaturalNumbers(uint n)
        {
            if (n == 1)
            { 
                Console.Write(n + " "); 
            }
            if (n > 1)
            {
                PrintFirstNaturalNumbers(n - 1);
                Console.Write(n + " ");
            }
        }

        static void PrintNumbersDescending(uint n)
        {
            if (n == 1)
            {
                Console.Write(n + " ");
            }
            if (n >1)
            {
                Console.Write(n + " ");
                PrintNumbersDescending(n - 1);
            }
        }

        static uint GetNumberToPrint()
        {
            Console.Write("How many numbers to print: ");
            uint input = 0;
            while (!UInt32.TryParse(Console.ReadLine(), out input))
            {
                Console.Write("Error.  Please enter a positive integer: ");
            }
            return input;
        }
    }
}

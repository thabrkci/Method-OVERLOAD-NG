using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_--_-_-_Out Parameters_-__-_");

            string inputString = "999";
            bool parsingSuccessful = int.TryParse(inputString, out int parsedValue);
            
            if (parsingSuccessful)
            {
                Console.WriteLine("Winner");
                Console.WriteLine(parsedValue);
            }
            else
            {
                Console.WriteLine("Don't Winner");
            }

            // Method Overloading
            MethodList jungle = new MethodList();
            jungle.Plus(4, 5, out int plusResult);
            Console.WriteLine("Result of Plus method: " + plusResult);

            int intValue = 999;
            jungle.WriteForScreen(Convert.ToString(intValue));
            jungle.WriteForScreen(intValue);
            jungle.WriteForScreen("Taha", "BÖREKCİ");
        }
    }

    class MethodList
    {
        // Method with out parameter
        public void Plus(int a, int b, out int result)
        {
            result = a + b;
        }

        // Method to write a string to the console
        public void WriteForScreen(string output)
        {
            Console.WriteLine(output);
        }

        // Method to write an integer to the console
        public void WriteForScreen(int output)
        {
            Console.WriteLine(output);
        }

        // Method to concatenate and write two strings to the console
        public void WriteForScreen(string str1, string str2)
        {
            Console.WriteLine(str1 + str2);
        }
    }
}

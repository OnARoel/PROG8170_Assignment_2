using Assignment02;
using System;

namespace Assignment2 {
    class Program {
        static void Main(string[] args) {

            int userChoice = 0;
            while (userChoice != 7) {
                PrintMenu();
                userChoice = Int32.Parse(Console.ReadLine());
                Conversion c;

                int tempInput;
                switch (userChoice) {
                    case 1:
                        Console.WriteLine("You have chosen to convert Celsius to Fahrenheit");
                        Console.WriteLine("Please enter your Celsius value");
                        tempInput = Int32.Parse(Console.ReadLine());
                        tempInput = CheckTemp(tempInput);
                        
                        c = new Conversion(tempInput);
                        Console.WriteLine("\nYou have converted " + tempInput + " from Celsius to Fahrenheit");
                        Console.WriteLine(tempInput + "C = " + c.ConvertCelciusToFahrenheit() + "F");
                        Console.WriteLine("\n");

                        break;
                    case 2:
                        Console.WriteLine("You have chosen to convert Celsius to Kelvin");
                        Console.WriteLine("Please enter your Celsius value");
                        tempInput = Int32.Parse(Console.ReadLine());
                        tempInput = CheckTemp(tempInput);
                        c = new Conversion(tempInput);

                        Console.WriteLine("\nYou have converted " + tempInput + " from Celsius to Kelvin");
                        Console.WriteLine(tempInput + "C = " + c.ConvertCelciusToKelvin() + "K");
                        Console.WriteLine("\n");

                        break;
                    case 3:
                        Console.WriteLine("You have chosen to convert Fahrenheit to Celsius");
                        Console.WriteLine("Please enter your Fahrenheit value");
                        tempInput = Int32.Parse(Console.ReadLine());
                        tempInput = CheckTemp(tempInput);
                        c = new Conversion(tempInput);

                        Console.WriteLine("\nYou have converted " + tempInput + " from Fahrenheit to Celsius");
                        Console.WriteLine(tempInput + "F = " + c.ConvertFahrenheitToCelsius() + "C");
                        Console.WriteLine("\n");

                        break;
                    case 4:
                        Console.WriteLine("You have chosen to convert Fahrenheit to Kelvin");
                        Console.WriteLine("Please enter your Fahrenheit value");
                        tempInput = Int32.Parse(Console.ReadLine());
                        tempInput = CheckTemp(tempInput);
                        c = new Conversion(tempInput);

                        Console.WriteLine("\nYou have converted " + tempInput + " from Fahrenheit to Kelvin");
                        Console.WriteLine(tempInput + "F = " + c.ConvertFahrenheitToKelvin() + "K");
                        Console.WriteLine("\n");

                        break;
                    case 5:
                        Console.WriteLine("You have chosen to convert Kelvin to Celsius");
                        Console.WriteLine("Please enter your Kelvin value");
                        tempInput = Int32.Parse(Console.ReadLine());
                        tempInput = CheckTemp(tempInput);
                        c = new Conversion(tempInput);

                        Console.WriteLine("\nYou have converted " + tempInput + " from Kelvin to Celsius");
                        Console.WriteLine(tempInput + "K = " + c.ConvertKelvinToCelsius() + "C");
                        Console.WriteLine("\n");

                        break;
                    case 6:
                        Console.WriteLine("You have chosen to convert Kelvin to Fahrenheit");
                        Console.WriteLine("Please enter your Kelvin value");
                        tempInput = Int32.Parse(Console.ReadLine());
                        tempInput = CheckTemp(tempInput);
                        c = new Conversion(tempInput);

                        Console.WriteLine("\nYou have converted " + tempInput + " from Kelvin to Fahrenheit");
                        Console.WriteLine(tempInput + "K = " + c.ConvertKelvinToFahrenheit() + "F");
                        Console.WriteLine("\n");
                        break;
                    case 7:
                        Console.WriteLine("You have chosen to exit!\nGoodbye.");
                        System.Threading.Thread.Sleep(500);
                        break;
                    default:
                        if (userChoice < 0) Console.WriteLine("\n\nPlease enter a number greater than 0!\n\n");
                        else Console.WriteLine("\n\nPlease enter a valid value between 1 and 7!\n\n");
                        break;
                }

            }

        }

        public static void PrintMenu() {
            Console.WriteLine("Welcome to the temperature conversion program!\nPlease note, all answers will be rounded!\n\n");
            Console.WriteLine("1. Convert Celsius to Fahrenheit");
            Console.WriteLine("2. Convert Celsius to Kelvin");
            Console.WriteLine("3. Convert Fahrenheit to Celsius");
            Console.WriteLine("4. Convert Fahrenheit to Kelvin");
            Console.WriteLine("5. Convert Kelvin to Celsius");
            Console.WriteLine("6. Convert Kelvin to Fahrenheit");
            Console.WriteLine("7. Exit");
        }

        public static int CheckTemp(int tempInput) {
            while (tempInput <= 0) {
                Console.WriteLine("Please enter a valid Temperature value above 0");
                tempInput = Int32.Parse(Console.ReadLine());
            }
            return tempInput;
        }
    }
}
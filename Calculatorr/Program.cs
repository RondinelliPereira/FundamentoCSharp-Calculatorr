//using System;

//namespace Calculatorr
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }
//    }
//}



using System;

/*
    Primeiro projeto do curso Fundamentos do C# no Balta.io
    Mão na massa: Criando uma calculadora
*/

namespace Calculatorr
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("What the operation do you want to execute?");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Division");
            Console.WriteLine("4 - Multiplication");
            Console.WriteLine("5 - Exit");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Select one option: ");
            short choose = short.Parse(Console.ReadLine());

            switch (choose)
            {
                case 1: Sum(); break;
                case 2: Subtraction(); break;
                case 3: Division(); break;
                case 4: Multiplication(); break;
                case 5: ExitCalculator(); break;
                default: Menu(); break;
            }

        }


        #region Method
        static void Sum()
        {
            Console.Clear();
            Console.WriteLine("Sum operation selected!");
            Console.WriteLine("First value: ");
            float value1 = float.Parse(Console.ReadLine()); //Recebe primeiro valor do usuario
            Console.WriteLine("Second value: ");
            float value2 = float.Parse(Console.ReadLine()); //Recebe segundo valor do usuario

            Console.WriteLine("");

            float result = (value1 + value2);
            Console.WriteLine($"The result of sum is: {result}"); //Interpolacao de string para mostrar resultado
            //Console.WriteLine($"The result of sum is: " + result); //Concatenando
            //Console.WriteLine($"The result of sum is: {value1 + value2}");
            //Console.WriteLine($"The result of sum is: " + (value1 + value2));
            Console.ReadKey();
            Menu();
        }

        static void Subtraction()
        {
            Console.Clear();
            Console.WriteLine("Subtraction operation selected!");
            Console.WriteLine("First Value: ");
            float value1 = float.Parse(Console.ReadLine()); //Recebe primeiro valor do usuario
            Console.WriteLine("Second Value: ");
            float value2 = float.Parse(Console.ReadLine()); //Recebe segundo valor do usuario

            Console.WriteLine("");

            float result = (value1 - value2);
            Console.WriteLine($"The result of Subtraction is: {result}"); //Interpolacao de string para mostrar resultado
            Console.ReadKey();
            Menu();
        }

        static void Division()
        {
            Console.Clear();
            Console.WriteLine("Division operation selected!");
            Console.WriteLine("First Value: ");
            float value1 = float.Parse(Console.ReadLine()); //Recebe primeiro valor do usuario
            Console.WriteLine("Second Value: ");
            float value2 = float.Parse(Console.ReadLine()); //Recebe segundo valor do usuario

            Console.WriteLine("");

            float result = (value1 / value2);
            Console.WriteLine($"The result of Division is: {result}"); //Interpolacao de string para mostrar resultado
            Console.ReadKey();
            Menu();
        }

        static void Multiplication()
        {
            Console.Clear();
            Console.WriteLine("Multiplication operation selected!");
            Console.WriteLine("First Value: ");
            float value1 = float.Parse(Console.ReadLine()); //Recebe primeiro valor do usuario
            Console.WriteLine("Second Value: ");
            float value2 = float.Parse(Console.ReadLine()); //Recebe segundo valor do usuario

            Console.WriteLine("");

            float result = (value1 * value2);
            Console.WriteLine($"The result of Multiplication is: {result}"); //Interpolacao de string para mostrar resultado
            Console.ReadKey();
            Menu();
        }

        static void ExitCalculator()
        {
            Console.WriteLine("Thanks for using our calculator!");
            //Console.ReadKey();
            System.Environment.Exit(0);

        }

        #endregion

    }
}


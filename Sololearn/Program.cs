using System;

namespace Sololearn
{
    class Program
    {
        static void Main(string[] args)
        {
            InputTypesSolo();
        }

        static void DataTypesSolo()
        {
            int number = 7;
            string name = "Joseph";
            bool disappointing = true;
            char grades = 'B';
            float alttitude = 90.265141f;
            double bank = -4000000;
            decimal pie = 3.14159265359M;

            Console.WriteLine($"int = {number}.");
            Console.WriteLine($"string = {name}.");
            Console.WriteLine($"bool = {disappointing}.");
            Console.WriteLine($"char = {grades}.");
            Console.WriteLine($"float = {alttitude}.");
            Console.WriteLine($"double = {bank}.");
            Console.WriteLine($"decimal = {pie}.");
        }


        static void InputTypesSolo()
        {
            //DataTypes();
            Console.WriteLine("Enter Number One");
            //string myName = Console.ReadLine();
            decimal numberOne = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine($"You entered: {numberOne}");

            Console.WriteLine("Enter Number Two");
            decimal numberTwo = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"You entered {numberOne} & {numberTwo}");

            //Addition
            Console.WriteLine($"Addition: {numberOne} + {numberTwo} = {numberOne + numberTwo}");
            //Subtraction
            Console.WriteLine($"Subtraction: {numberOne} - {numberTwo} = {numberOne - numberTwo}");
            //Multiplication
            Console.WriteLine($"Multiplication: {numberOne} * {numberTwo} = {numberOne * numberTwo}");
            //Division
            Console.WriteLine($"Division: {numberOne} / {numberTwo} = {numberOne / numberTwo}");
            //Remainder (Modulus)
            Console.WriteLine($"Modulus: {numberOne} % {numberTwo} = {numberOne % numberTwo}");

            //Increment
            Console.WriteLine($"Increment: The increment of {numberOne++} is {numberOne}");
            Console.WriteLine($"Increment: The increment of {++numberOne} is {numberOne}");
            Console.WriteLine($"numberOne++ is the same as numberOne = numberOne + 1. See here: {numberOne} is {numberOne = numberOne + 1} ");
            //Decrement
            Console.WriteLine($"Decrement: The deccrement of {numberTwo--} is {numberTwo}");
            Console.WriteLine($"Decrement: The deccrement of {--numberTwo} is {numberTwo}");

            decimal centeredPolygonal = ((((numberOne * numberTwo) / 2) * (numberTwo - 1)) + 1);

            Console.WriteLine($"The centered polygonal \nof {numberOne} & {numberTwo} is: {centeredPolygonal}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace FunctionProgramming
{
    class Program
    {
        private static List<double> Numbers = new List<double> { 5,8,9,4,6,7};
        static void Main(string[] args)
        {
            //Pure Functions Concept------------------
            //(Mean Function Has Input and Return Output and not read or write outside it so , its testable)
            //Numbers.Select(AddOne)
            //       .Select(Square)
            //       .ToList()
            //       .ForEach(Print);


            //Higher Order Functions Concept -------------------
            //(Mean Function Take Functions as Arguments or Return Functions)
            //Console.WriteLine(AddThree(AddTwo,5));
            //Console.WriteLine(DelegateAddThree(DelegateAddTwo, 5));
            //Console.WriteLine(WelcomeMessage()("kalid"));
            Console.WriteLine(WelcomeMessage("Welcome").Invoke("Mohammed"));










            Console.ReadKey();
        }

        #region Pure Functions Concept

        private static double AddOne(double n)
        {
            return n + 1;
        }

        private static double Square(double n)
        {
            return Math.Pow(n, 2);
        }

        private static double SubtractTen(double n)
        {
            return n - 10;
        }

        private static void Print(double number)
        {
            Console.WriteLine(number.ToString(CultureInfo.InvariantCulture));
        }

        #endregion

        #region Higher Order Functions Concept

        //Delegates Mean Function Pointers -----------
        private static readonly Func<double, double> DelegateAddTwo = AddTwo;
        private static readonly Func<Func<double, double>, double,double> DelegateAddThree = AddThree;
        

        private static double AddFour(Func<double, double> f, double value)
        {
            var functionResult = f(value);
            return functionResult + 4;
        }

        private static double AddThree(Func<double,double> f,double value)
        {
            var functionResult = f(value);
            return functionResult + 3;
        }

        private static double AddTwo(double n)
        {
            return n + 2;
        }

        private static Func<string, string> WelcomeMessage(string header)
        {
            return message => $"{header}:{message}";
        }

        #endregion
    }
}

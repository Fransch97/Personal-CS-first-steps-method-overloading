using System;

namespace MethodsOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("working");
            //con il overloading possiamo prevedere diversi paramentri possibili
            //C# userà la funziona giusta capendo i tipi di dati passati

            Console.WriteLine(Sum(1, 2.4));
            Console.WriteLine(Sum(2.3, 2.4));
            Console.WriteLine(Sum(2.3, 2.4, 3));
            Console.WriteLine(Sum(1, 2));
            Console.WriteLine(Sum(1, 2));
        }

        //normal function
        static int Sum(int num1, int num2) { return num1 + num2; }

        //overload
        static double Sum(double num1, int num2) { return num2 + num1; }
        static double Sum(double num1, double num2) { return num2 + num1; }
        static double Sum(double num1, double num2, int num3) { return num2 + num1 + num3; }
    
    }
}

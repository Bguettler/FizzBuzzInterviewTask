namespace FizzBuzzConsoleApp
{
    using FizzBuzzLib;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzer = new FizzBuzz();
            string value = fizzBuzzer.DemoMethod();
            Console.WriteLine(value);

            //string value = fizzBuzzer.FizzBuzzifyAnInt(5); //used to test
            //Console.WriteLine(value);

            foreach (var x in fizzBuzzer.FizzBuzzValuesForRange(1, 100)) //used to iterate through the list printing the FizzBuzz values
            {
                Console.WriteLine(x);
            }
        }
    }
}

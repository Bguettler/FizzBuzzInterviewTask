using System.Collections.Generic;

namespace FizzBuzzLib
{
    public class FizzBuzz : IFizzBuzz, IFizzBuzzRange //implements the IFizzBuzz interface
    {
        public string FizzBuzzifyAnInt(int input)
        {
            string output = "";
            if (input % 3 == 0 && input % 5 == 0) //check to see if the input given is a multiple of 3 and 5
            {
                output = "FizzBuzz";
            }
            else if (input % 3 == 0) //check to see if the input given is a multiple of 3
            {
                output = "Fizz";
            }
            else if (input % 5 == 0) //check to see if the input given is a multiple of 5
            {
                output = "Buzz";
            }
            else //if it is none of the above it will default a string of the int input 
            {
                output = input.ToString();
            }
            return output; //returns the string output
        }

        IEnumerable<string> FizzBuzzValuesForRange(int start, int end)
        {
            List<string> strings = new List<string>(); //declaring an empty list of strings

            for (int i = start; i <= end; i++) //for loop populating the strings list with its appropriate FizzyBuzzy translation
            {
                strings.Add(FizzBuzzifyAnInt(i)); //passing the integer to the FizzBuzzifyAnInt method to decide if it is a multiple of 3, 5, or both
            }

            return strings; //returning the list of strings that are now populated
        }

        public string DemoMethod() //I added this back to remove error
        {
            return ("Hello World");
        }
    }
}

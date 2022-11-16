using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wantsome.DotNet7
{
    class Recap
    {
        public void Go()
        {
            Console.WriteLine("----------------------- RECAP -----------------------");

            //1
            //Read two integer numbers from the user and display the comparison relationship between them.
            //Try to make the experience as user friendly as possible (use clear instructions and descriptions)

            Console.WriteLine("Ex1");
            Console.WriteLine("First number: ");
            int x = int.Parse(Console.ReadLine()); // alternative way to do a conversion, equivalent to the line below
            //int x = Convert.ToInt32(Console.ReadLine())); 

            Console.WriteLine("Second number: ");
            int y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine(x + " is greater than " + y);
            }
            else if (x < y)
            {
                Console.WriteLine(x + " is smaller than " + y);
            }
            else
            {
                Console.WriteLine(x + " is equal to " + y);
            }

            //2
            //Read two letters / words from the user and display the comparison relationship between them.
            //Try to make the experience as user friendly as possible (use clear instructions and descriptions)
            //Tip: search for String.Compare

            Console.WriteLine();
            Console.WriteLine("Ex2");
            Console.WriteLine("First letter / word: ");
            string a = Console.ReadLine();

            Console.WriteLine("Second letter / word: ");
            string b = Console.ReadLine();

            if (String.Compare(a, b) > 0)
            {
                Console.WriteLine(a + " is greater than " + b);
            }
            else if (String.Compare(a, b) < 0)
            {
                Console.WriteLine(a + " is smaller than " + b);
            }
            else
            {
                Console.WriteLine(a + " is equal to " + b);
            }

            //3
            //Read an integer number from the user. If the number is positive set the value of x as "positive number".
            //If the value is negative set the value of x as "negative number". Display x.


            Console.WriteLine();
            Console.WriteLine("Ex3 a)");
            Console.WriteLine("Number: ");
            int number = int.Parse(Console.ReadLine());
            string x1;

            if (number >= 0)
            {
                x1 = "positive number";
            }
            else
            {
                x1 = "negative number";
            }
            Console.WriteLine(x1);

            //Another way of doing the same thing using the ternary operator
            //Ternary operator syntax: condition ? consequent : alternative

            Console.WriteLine();
            Console.WriteLine("Ex3 b)");
            Console.WriteLine("Number: ");
            int number1 = int.Parse(Console.ReadLine());
            string x2;
            x2 = number >= 0 ? "positive number" : "negative number";
            Console.WriteLine(x2);

            //line 83 translates to:
            //condition -> number >= 0
            //consequent -> x1 = "positive number"
            //alternative -> x1 = "negative number
        }
    }
}

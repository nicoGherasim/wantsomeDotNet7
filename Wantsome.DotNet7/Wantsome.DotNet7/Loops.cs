namespace Wantsome.DotNet7
{
    internal class Loops
    {
        public void Go()
        {
            Console.WriteLine("------------------------ FOR ----------------");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            int j = 1;
            for (; j <= 5; j++)
            {
                Console.WriteLine(j);
            }

            Console.WriteLine();
            for (int i = 1; ; i++)
            {
                if (i > 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine();
            for (int i = 1; i <= 5;)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine();
            int z = 1;
            for (; ; )
            {
                if (z > 5)
                {
                    break;
                }
                Console.WriteLine(z);
                z++;
            }

            Console.WriteLine();
            List<int> l = new List<int>();
            for (int i = 123; i <= 456; i++)
            {
                l.Add(i);
            }

            Console.WriteLine(l[5]);


            Console.WriteLine();
            List<int> l1 = new List<int>();
            for (int i = 123; i <= 456; i += 3) // i = i + 3
            {
                l1.Add(i);
            }

            Console.WriteLine(l1[5]);

            //1 Print all even numbers from 1 to 15

            Console.WriteLine();
            for (int i = 1; i <= 15; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            //1 done differently
            for (int i = 2; i <= 14; i += 2) // -> i = i + 2
            {
                Console.WriteLine(i);
            }

            //2
            //Print all even numbers from 15 to 1
            Console.WriteLine();
            for (int i = 15; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            //done differently
            for (int i = 14; i >= 2; i -= 2) // -> i = i - 2
            {
                Console.WriteLine(i);
            }

            //3
            //Create a list of numbers that contains all the numbers that divide by 7 starting - 100 to 100. Display the elements of the list.
            Console.WriteLine();
            List<int> list2 = new List<int>();
            for (int i = -100; i <= 100; i++)
            {
                if (i % 7 == 0)
                {
                    list2.Add(i);
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("------------------------ FOREACH ----------------");
            int[] array = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();
            List<int> l2 = new List<int>() { 34, 56, 78, 90 };
            foreach (int elem in l2)
            {
                Console.WriteLine(elem * elem); // ^2
            }

            Console.WriteLine();
            List<string> l3 = new List<string>() { "Ana", "Bogdan", "Crina" };
            foreach (string elem in l3)
            {
                Console.WriteLine("Numele este " + elem);
            }

            // 1
            //Read 5 numbers from the user using a for loop and store them in a collection.
            //Display the elements of the collection multiplied by 12.75 using a foreach loop.

            Console.WriteLine();
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Number: ");
                int number1 = int.Parse(Console.ReadLine());
                list.Add(number1);
            }

            foreach (int element in list)
            {
                Console.WriteLine(element * 12.75);
            }

            //2
            //Read two numbers, a and b, from the user and create a collection with all the numbers between a and b.
            //Be sure to have the collection in ascending order (a to b if a < b, b to a if b < a)
            //Print all numbers that divide by 3 starting from a to b.

            Console.WriteLine();
            Console.WriteLine("Start ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("End ");
            int end = int.Parse(Console.ReadLine());

            List<int> startToEnd = new List<int>();

            if (start < end)
            {
                for (int i = start; i <= end; i++)
                {
                    startToEnd.Add(i);
                }
            }
            else
            {
                for (int i = end; i <= start; i++)
                {
                    startToEnd.Add(i);
                }
            }

            Console.WriteLine();
            foreach (int element in startToEnd)
            {
                if (element % 3 == 0)
                {
                    Console.WriteLine(element);
                }
            }

            Console.WriteLine("------------------------ FOR & FOREACH RECAP----------------");

            //1 FOR
            //For all numbers from 123 to 234, print the following:
            //  - If number is divisible by 3, print the number and Fizz
            //  - If number is divisible by 5, print the number and Buzz
            //  - If number is divisible by 3 and 5, print the number and FizzBuzz
            //  - Otherwise, print the number

            for (int i = 123; i <= 234; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + " FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " Fizz");
                }
                else if (i % 5 == 0)
                {

                    Console.WriteLine(i + " Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            //2 FOREACH
            //Add all numbers from 123 to 234 to a list (use FOR).
            //For each element of the list print the following (use FOREACH):
            //  - If element is divisible by 3, print the element and Fizz
            //  - If element is divisible by 5, print the element and Buzz
            //  - If element is divisible by 3 and 5, print the element and FizzBuzz
            //  - Otherwise, print the element

            Console.WriteLine();
            List<int> fizzBuzzList = new List<int>();
            for (int i = 123; i <= 234; i++)
            {
                fizzBuzzList.Add(i);
            }

            foreach (int i in fizzBuzzList)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + " FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " Fizz");
                }
                else if (i % 5 == 0)
                {

                    Console.WriteLine(i + " Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("------------------------ WHILE ----------------");
            int n = 1;
            while (n < 6) // n <= 5
            {
                Console.WriteLine("Current value of n is " + n);
                //Console.WriteLine($"Current value of n is {n}");
                //Console.WriteLine("Current value of n is {3}, {2}, {1}, {0}", n, 234, 567, 890);
                n++;
            }

            Console.WriteLine();
            n = 567;
            while (n > 550) // n >= 551
            {
                Console.WriteLine(n);
                n--;
            }

            //1 
            //Create a list of numbers that contains all the numbers that divide by 7 starting -100 to 100.
            //Display the elements of the list. Use while loop.

            Console.WriteLine();
            int n2 = -100;
            List<int> l10 = new List<int>();
            while (n2 <= 100) // n < 101
            {
                if (n2 % 7 == 0)
                {
                    l10.Add(n2);
                    Console.WriteLine(n2);
                }
                n2++;
            }
            // equivalent with
            Console.WriteLine();
            List<int> list3 = new List<int>();
            for (int i = -100; i <= 100; i++)
            {
                if (i % 7 == 0)
                {
                    list3.Add(i);
                    Console.WriteLine(i);
                }
            }

            //2
            //Create a list that contains 10 names.
            //Using while print the first 6 names of the list.
            // a, b, c, d, e, f, g, h, i, j -> a, b, c, d, e, f

            Console.WriteLine();
            List<string> names = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };

            int n3 = 0;
            while (n3 <= 5)
            {
                Console.WriteLine(names[n3]);
                n3++;
            }

            //3
            //Using while print the last three names of the list in reverse order
            //Tip: remember about List<T>.Count property
            // a, b, c, d, e, f, g, h, i, j -> j, i, h


            // 0  1  2  3  4  5  6  7  8  9 -> index
            // a  b  c  d  e  f  g  h  i  j -> value
            // count -> 10
            // l[count] <-> l[10]
            // l[count - 1] <-> l[9]
            // l[count - 4] <-> l[6]
            // l[count - 3] <-> l[7]

            names = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };

            Console.WriteLine();
            int x = names.Count - 1;
            while (x >= names.Count - 3)
            {
                Console.WriteLine(names[x]);
                x--;
            }

            Console.WriteLine("------------------------ DO WHILE ----------------");

            x = 0;
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x < 5);

            Console.WriteLine();
            x = 120;
            do
            {
                Console.WriteLine(x);
                x--;
            } while (x > 115);

            Console.WriteLine();
            x = 120000000;
            do
            {
                Console.WriteLine(x);
                x--;
                Console.WriteLine(x);
            } while (x < 115);
            Console.WriteLine("after while " + x);

            //1
            //Print all the numbers between 56 and 987 that divide by 24. Use a do while loop.

            Console.WriteLine();
            int n7 = 56;
            do
            {
                if (n7 % 24 == 0)
                {
                    Console.WriteLine(n7);
                }
                n7++;
            } while (n7 <= 987);

            //2
            //Read numbers from the user until the input is 0. Use a do while loop.

            Console.WriteLine();
            int n8;
            do
            {
                Console.WriteLine("Number ");
                n8 = int.Parse(Console.ReadLine());
            } while (n8 != 0);

            Console.WriteLine("------------------------ CONTINUE ----------------");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("before: " + i);
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine("after: " + i);
            }

            //1
            //Print all the numbers starting 0 to 100 that do not divide by 2 or 5. Use while and continue.

            Console.WriteLine();
            int n9 = 0;
            while (n9 <= 100)
            {
                if (n9 % 2 == 0 || n9 % 5 == 0)
                {
                    n9++;
                    continue;
                }
                Console.WriteLine(n9);
                n9++;
            }

            Console.WriteLine("------------------------ BREAK ----------------");

            for (int i = 1; i <= 100; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            // 1 
            // Iterate from -1 to -123 and print all the numbers.
            // Break the iteration when you find the first number that divides to 21.
            // Use do while and break.

            Console.WriteLine();
            int n10 = -1;
            do
            {
                if (n10 % 21 == 0)
                {
                    break;
                }
                Console.WriteLine(n10);
                n10--;
            } while (n10 >= -100);
        }
    }
}

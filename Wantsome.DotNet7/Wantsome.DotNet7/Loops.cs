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

            //1            
            // Print all even numbers from 1 to 15

            Console.WriteLine();
            for (int i = 1; i <= 15; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            //done differently
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
        }
    }
}

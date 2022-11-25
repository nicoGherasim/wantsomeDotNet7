namespace Wantsome.DotNet7
{
    internal class Algorithms
    {
        public void Go()
        {
            Console.WriteLine("before");
            for (int i = 0; i <= 5; i++)
            {
                int number = i * 5 + 34 - 2;
                Console.WriteLine(number);
            }
            Console.WriteLine("after");

            Step1();

            // debug - means removing bugs from your code

            // bugs - refers to an error, fault, or flaw in any computer program or a hardware system

            // most bugs occur due to errors and mistakes made by developers when constructing the source code

            // debugging - run your code step by step in order to remove bugs

            // debugger - means that there is one tool actively monitors everything that’s happening as the program runs.
            // It also allows you to pause the app at any point to examine its state and then step through your code
            // line by line to watch every detail as it happens.

            // breakpoint 
            // F9
            // added on the line of code you want to examinate in detail
            // indicates where Visual Studio should suspend your running code so you can take a closer look

            // F11
            // step into
            // execute the next line of code and if the next line is a function call,
            // Step Into will stop at the first line of the function

            // F10
            // step over
            // execute the next line of code and if the next line is a function call,
            // Step Over will execute the function, and will stop at the next line of code after the function

            // F11 + shift
            // step out
            // this will return to the line where the current function was called

            // F5 continue
            // will begin executing the code, until the next breakpoint

            // MATRIX
            // 2 6
            // 9 3
            // 7 5

            Console.WriteLine();
            //myArray[0,0]=2;
            int[,] myArray = new int[3, 2]
            {
                {2, 6},
                {9, 3},
                {7, 5}
            };

            Console.WriteLine(myArray[0, 0]);
            Console.WriteLine(myArray[2, 0]);

            var rows = myArray.GetLength(0);
            var cols = myArray.GetLength(1);

            Console.WriteLine("rows = " + rows + " cols = " + cols);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(myArray[i, j] + " ");
                }
                Console.WriteLine();
            }

            // 1
            // Write an algorithm that iterates two different lists (declared in advance with different number of elements)
            // and print the sum of each element of the first list with each element of the second list.
            // Use ony foreach loops.

            // l1: 4, 8, 5, 3
            // l2: 40, 80, 50, 30, 100
            // result: 44, 84, 54, 34, 104, 48, 88, 58, 38, 108, 45, 85, 55, 35, 105, 43, 83, 53, 33, 103 

            Console.WriteLine();
            List<int> l1 = new List<int> { 4, 8, 5, 3 };
            List<int> l2 = new List<int> { 40, 80, 50, 30, 100 };

            foreach (int i in l1)
            {
                foreach (int j in l2)
                {
                    Console.WriteLine(i + j);
                }
            }

            // MIN MAX
            // Print the minimum value and the maximum value of an array.
            // Do not use array.Min() or array.Max().

            Console.WriteLine();
            int[] myArray1 = new int[] { -1, 2, 3, 8, -12, 56 };

            Console.WriteLine(myArray1.Min());
            Console.WriteLine(myArray1.Max());
            Console.WriteLine();

            int min = myArray1[0];
            int max = myArray1[0];

            foreach (int i in myArray1)
            {
                if (i < min)
                {
                    min = i;
                }
                if (i > max)
                {
                    max = i;
                }
            }
            Console.WriteLine("min = " + min + " max = " + max);

            // PRIME NUMBER
            // Write an algorithm to check if a number is prime or not (it only divides by 1 and itself).
            // Print "the number is prime" is so or "the number is not prime" otherwise.
            // Prime numbers: 13, 23
            // Not prime numbers: 12, 24, 15

            Console.WriteLine();
            int numberToBeChecked = 12;
            bool isPrime = true;

            for (int i = 2; i < numberToBeChecked; i++)
            {
                if (numberToBeChecked % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("the number is prime");
            }
            else
            {
                Console.WriteLine("the number is not prime");
            }

            // SEARCH
            // Given an unsorted array which might have a number in the majority (a number appears more than 50 % in the array),
            // find and print the first majority number if it exists.

            Console.WriteLine();
            myArray1 = new int[] { 1, 2, 1, 1, 1, 2, 2, 2 };

            for (int i = 0; i < myArray1.Length; i++)
            {
                int count = 1;

                for (int j = i + 1; j < myArray1.Length; j++)
                {
                    if (myArray1[i] == myArray1[j])
                    {
                        count++;
                    }
                }

                if (count >= myArray1.Length / 2)
                {
                    Console.WriteLine("number = " + myArray1[i] + " count = " + count);
                }
            }

            // BUBBLE SORT
            // Given an unsorted array use the bubble sort algorithm to have is sorted in the end.

            Console.WriteLine();
            int[] array = new int[] { 1, 6, 4, 5, 2, 0, -1 }; //  -1, 0, 1, 2, 4, 5, 6

            // 1 - 6
            // 1 - 4
            // 1 - 5
            // 1 - 2 
            // 1 - 0 
            // swap 1 and 0 => 0, 6, 4, 5, 2, 1, -1

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }
                }
            }

            Console.WriteLine("sorted array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            // swap variables
            Console.WriteLine();
            int a = 3;
            int b = 5;
            // output should be a = 5, b = 3
            int y = a;
            a = b;
            b = y;

            Console.WriteLine("a=" + a + ", b=" + b);

            // PALINDROME
            // Write an algorithm to check if a number is a palindrome or not (it is the same read from both ends).
            // Print "the number is palindrome" if so or "the number is not palindrome" otherwise.
            // 2002, 1993, 121, 909, 22

            Console.WriteLine();
            int nr = 1215;
            int rest, reverse = 0;
            int temporary = nr;

            while (temporary > 0)
            {
                rest = temporary % 10; // store the last digit of the number
                temporary /= 10; // temporary = temporary / 10; get rid og the last digit of the number
                reverse = (reverse * 10) + rest;  // build the number by reversing the order of the digits
            }

            if (nr == reverse)
            {
                Console.WriteLine("the number is palindrome");
            }
            else
            {
                Console.WriteLine("the number is not palindrome");
            }

            // 134
            // 1
            //rest 4, temp 13, reverse 4
            // 2
            // rest 3, tempo 1, reverse 43
            //3
            // rest 1, temp 0, reverse 431
        }

        public void Step1()
        {
            Console.WriteLine("go to step2");
            Step2();
        }
        public void Step2()
        {
            Console.WriteLine("go to step3");
            Step3();
        }

        public void Step3()
        {
            Console.WriteLine("stop");
        }
    }
}

namespace Wantsome.DotNet7.Homeworks
{
    public class HomeworkLoops
    {
        public void Go()
        {
            //1.Given an array of integer numbers, print the total of all the values that are even numbers.
            //[1, 2, 3, 4, 5] -> total = 6
            Console.WriteLine("--- Ex 1 ---");
            int[] numbers = new int[] { 123, 222, 335, 468, 580 };
            int sum = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }
            Console.WriteLine($"The total of the even numbers is {sum}");

            //2.Find if an array of integer numbers contains duplicates and display them if so.
            //[1, 2, 3, 3, 4] -> 3

            Console.WriteLine("--- Ex 2 ---");
            numbers = new int[] { 1, 2, 3, 3, 4, 4, 5, 6, 6};
            List<int> duplicates = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        duplicates.Add(numbers[i]);
                    }
                }
            }
            Console.Write("The numbers that have duplicates are: ");
            foreach (int duplicate in duplicates)
            {
                Console.Write($"{duplicate} ");
            }

            //3.Check if there are duplicates in a list of strings. If yes, remove the them.
            //{ "a", "b", "b", "c", "c", "d"} -> { "a", "b", "c", "d"}
            
            Console.WriteLine();
            Console.WriteLine("--- Ex 3 ---");
            List<string> strings = new List<string> { "a", "bbb", "b", "bbb", "cc", "cc", "c", "d", "c", "bb", "bbb"};
            for (int i = 0; i < strings.Count; i++)
            {
                for (int j = i + 1; j < strings.Count; j++)
                {
                    if (strings[i] == strings[j])
                    {
                        strings.RemoveAt(j);
                    }
                }
            }
            Console.Write("The array without duplicates is: ");
            foreach (string elem in strings)
            {
                Console.Write($"{elem} ");
            }

            //4.Write a program to count the frequency of each element in an array.
            //[1, 4, 5, 2, 1, 4, 3, 1, 2] -> 1 - 3 times, 4 - 2 times, 5 - one time, 2 - 2 times, 3 - one time

            Console.WriteLine();
            Console.WriteLine("--- Ex 4 ---");

            numbers = new int[] { 1, 2, 3, 3, 4, 4, 5, 6, 6, 7, 7, 7 };
            Dictionary<int, int> numbersFrequency = new Dictionary<int, int>();

            foreach (int number in numbers)
            {            
                if (numbersFrequency.ContainsKey(number))
                { 
                    numbersFrequency[number] += 1;
                }
                else
                { 
                    numbersFrequency.Add(number, 1);                     
                }
            }

            foreach ( var numberFrequency in numbersFrequency)
            {
                Console.WriteLine($"Number {numberFrequency.Key} - {numberFrequency.Value} times");
            }

            //5.Read an array from the console and separate odd and even values into 2 arrays.
            //[3, 4, 5, 6, 7, 8] -> Odd array: [3, 5, 7], Even array: [4, 6, 8]

            Console.WriteLine("--- Ex 5 ---");

            Console.WriteLine("Provide the number of elements in the array: ");
            int numberOfElements = Convert.ToInt32(Console.ReadLine());

            numbers = new int[numberOfElements];
            // using two lists instead of two array as the lists can have dynamic size
            // if we were using arrays from the start the size of them should be specified and we don't know the size in advance
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();

            Console.WriteLine("Provide, one by one, the elements of your array: ");
            for (int i = 0; i < numberOfElements; i++)
            {
                Console.WriteLine($"Provide the element on index {i}:");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < numberOfElements; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers.Add(numbers[i]);
                }
                else
                {
                    oddNumbers.Add(numbers[i]);
                }
            }

            // converting the lists into array as the requirement is to have two arrays in the end
            int[] evenNumbersArray = evenNumbers.ToArray();
            int[] oddNumbersArray = oddNumbers.ToArray();

            // using the arrays above just as any array
            Console.WriteLine("The even numbers array: ");
            for (int i = 0; i < evenNumbersArray.Length; i++)
            {
                Console.Write($"{evenNumbersArray[i]} ");

            }

            Console.WriteLine();

            Console.WriteLine("The odd numbers array: ");
            for (int i = 0; i < oddNumbersArray.Length; i++)
            {
                Console.Write($"{oddNumbersArray[i]} ");
            }
        }
    }
}

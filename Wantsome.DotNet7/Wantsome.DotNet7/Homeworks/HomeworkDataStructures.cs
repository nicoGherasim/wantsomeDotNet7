
namespace Wantsome.DotNet7.Homeworks
{
    internal class HomeworkDataStructures
    {
        public void Go()
        {
            //2.Declare a bi-dimensional array that would look like the following
            //123 345 567
            //12  56  -12
            //34 - 98 65
            //765 543 321
            //Print the two elements in the center of the matrix using position indexes (56, -98).

            int[,] matrix = new int[4, 3]
            {
                {123, 345, 567},
                {12, 56, -12},
                {34, -98, 65},
                {765, 543, 321},
            };
            Console.WriteLine(matrix[1, 1]);
            Console.WriteLine(matrix[2, 1]);

            //3.Create a list of names. Check if that list has "Ana"(or any other name read from the user) as an element,
            //if not add it to the list and print it.

            Console.WriteLine();
            List<string> names = new List<string>() { "Diana", "Crina", "Daniela" };

            Console.WriteLine("Insert name: ");
            string name = Console.ReadLine();

            if (names.Contains(name))
            {
                Console.WriteLine($"The name {name} is already part of the list.");
            }
            else
            {
                names.Add(name);
                Console.WriteLine($"The name {name} is not part of the list. Adding it.");
            }

            //4.Create a stack that has two integer elements which are read from the user one by one.
            //Check the two given integers, and print "true" if one of them is 30 or if their sum is 30.
            //Otherwise print "false".

            Console.WriteLine();
            Stack<int> stackNumbers = new Stack<int>();

            Console.WriteLine("Insert first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            stackNumbers.Push(firstNumber);
            stackNumbers.Push(secondNumber);

            if (stackNumbers.ElementAt(0) == 30 || stackNumbers.ElementAt(1) == 30 
                || (stackNumbers.ElementAt(0) + stackNumbers.ElementAt(1) == 30))
            {
                Console.WriteLine("true"); 
            }
            else
            {
                Console.WriteLine("false");
            }

            //5.Using a queue which has 5 elements (read from the user and added to the queue one by one)
            //check if the top of the queue is a positive number and a multiple of 3 or a multiple of 7.
            //If not remove the top of the queue and print the new top of the queue.

            Console.WriteLine();
            Queue<int> queueNumbers = new Queue<int>();

            Console.WriteLine("Insert number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            queueNumbers.Enqueue(number);

            Console.WriteLine("Insert number: ");
            number = Convert.ToInt32(Console.ReadLine());
            queueNumbers.Enqueue(number);

            Console.WriteLine("Insert number: ");
            number = Convert.ToInt32(Console.ReadLine());
            queueNumbers.Enqueue(number);

            Console.WriteLine("Insert number: ");
            number = Convert.ToInt32(Console.ReadLine());
            queueNumbers.Enqueue(number);

            Console.WriteLine("Insert number: ");
            number = Convert.ToInt32(Console.ReadLine());
            queueNumbers.Enqueue(number);

            int peek = queueNumbers.Peek();
            if (peek > 0 && peek % 3 == 0 || peek % 7 == 0)
            {
                Console.WriteLine("The top of the queue is a positive number and a multiple of 3 or a multiple of 7.");
            }
            else
            {
                queueNumbers.Dequeue();                
                Console.WriteLine("The top of the queue is not a positive number and a multiple of 3 or a multiple of 7. " +
                    "The new top of the queue is {0}.", queueNumbers.Peek());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wantsome.DotNet7
{
    internal class DataStructures
    {
        public void Go()
        {
            // ARRAY
            Console.WriteLine();
            Console.WriteLine("----------------------- ARRAY -----------------------");
            int[] myArray = new int[] {1, 2, 3, 4, 5};

            int[] myArray2 = new int[5];
            myArray2[0] = 12;
            myArray2[1] = 15;

            Console.WriteLine("myArray2[1]: "+ myArray2[1]);
            Console.WriteLine("myArray2[2]: " + myArray2[2]);

            int[] myArray3 = new int[5] {1, 2, 3, 4, 5};

            int sum = myArray3[2] + myArray3[3] + myArray2[1] + myArray[4];
            Console.WriteLine("sum: " + sum);

            Console.WriteLine("average: " + myArray3.Average());
            Console.WriteLine("first element: " + myArray3.First());

            //1 2 3
            //4 5 6
            int[,] matrix = new int[2,3];
            matrix[0,0] = 1;
            matrix[0,1] = 2;
            matrix[0,2] = 3;
            matrix[1,0] = 4;
            matrix[1,1] = 5;
            matrix[1,2] = 6;

            Console.WriteLine(matrix[0,2]);
            matrix[0,2] = 3456789;
            Console.WriteLine(matrix[0, 2]);

            //1
            //Declare an array that will have 5 integer elements (12, 14, 34, 567, 34).
            //Add those 5 elements into the array one by one. Print the value of the second element in the array.
            
            Console.WriteLine();
            Console.WriteLine("Ex1");
            int[] n1 = new int[5];
            n1[0] = 12;
            n1[1] = 14;
            n1[2] = 34;
            n1[3] = 567;
            n1[4] = 34;
            Console.WriteLine(n1[1]);

            //2
            //Store and print the sum of the first three elements of the array and the product the last two elements in the array.
            //Print the sum of the two results above (sum + product).
            // sum = 60, prod = 19278
            // sum2 = 19338

            Console.WriteLine();
            Console.WriteLine("Ex2");
            int suma = n1[0] + n1[1] + n1[2];
            int prod = n1[3] * n1[4];
            Console.WriteLine("sum=" + suma + " prod=" + prod);
            int suma2 = sum + prod;
            Console.WriteLine("sum=" + suma2);

            // LIST
            Console.WriteLine();
            Console.WriteLine("----------------------- LIST -----------------------");
            List<int> l1 = new List<int>();
            List<int> l2 = new List<int> { 1, 2, 3, 4, 5};
            List<int> l3 = new List<int>(5) { 1, 2, 3, 4, 5 };

            l2[0] = 2;
            l1.Add(45); // -> l1[1] = 45;
            l1.Add(456);

            Console.WriteLine(l1[0] + ", " + l1[1]);

            Console.WriteLine("contains: " + l2.Contains(789));
            Console.WriteLine("last: " + l2.Last());

            //1
            //Declare a list that will have 5 integer elements (12, 14, 34, 567, 34).
            //Add those 5 elements into the list one by one. Print the value of the second element in the list.

            Console.WriteLine();
            Console.WriteLine("Ex1");
            List<int> l4 = new List<int>();
            l4.Add(12);
            l4.Add(14);
            l4.Add(34);
            l4.Add(567);
            l4.Add(34);
            Console.WriteLine(l4[1]);

            //2
            //Declare a list that will contain 3 names (Ana, Victor, Luca).
            //Print all the three names comma separated on the same line and then on different lines.
            // Ana, Victor, Luca
            // Ana
            // Victor
            // Luca

            Console.WriteLine();
            Console.WriteLine("Ex2"); List<string> l5 = new List<string> { "Ana", "Victor", "Luca" };
            Console.WriteLine(l5[0] + ", " + l5[1] + ", " + l5[2]);
            //the line below is equivalent to the line above - it does the same thing using string interpolation (that $)
            Console.WriteLine($"{l5[0]}, {l5[1]}, {l5[2]}");
            Console.WriteLine(l5.ElementAt(0));
            Console.WriteLine(l5.ElementAt(1));
            Console.WriteLine(l5.ElementAt(2));

            // QUEUE
            Console.WriteLine();
            Console.WriteLine("----------------------- QUEUE -----------------------");
            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);   
            q.Enqueue(3);

            Console.WriteLine(q.ElementAt(0));

            int elem = q.Dequeue();
            Console.WriteLine("elem: " + elem);
            Console.WriteLine(q.ElementAt(0));
            Console.WriteLine("peek: "+ q.Peek());
            Console.WriteLine(q.ElementAt(0));

            Console.WriteLine("contains: " + q.Contains(456));

            //1
            //Declare a queue that will have 5 integer elements (12, 14, 34, 567, 34).
            //Add those 5 elements into the queue one by one. Print the value of the second element in the queue.

            Console.WriteLine();
            Console.WriteLine("Ex1");
            Queue<int> q1 = new Queue<int>();
            q1.Enqueue(12);
            q1.Enqueue(14);
            q1.Enqueue(34);
            q1.Enqueue(567);
            q1.Enqueue(34);
            Console.WriteLine(q1.ElementAt(1));

            // STACK
            Console.WriteLine();
            Console.WriteLine("----------------------- STACK -----------------------");
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.ElementAt(0));

            int element = stack.Pop();
            Console.WriteLine("element: " + element);
            Console.WriteLine("peek: " + stack.Peek());

            Console.WriteLine("count: " + stack.Count());

            //1
            //Declare a stack that will have 5 integer elements (12, 14, 34, 567, 34).
            //Add those 5 elements into the stack one by one.Print the value of the second element in the stack.

            Console.WriteLine();
            Console.WriteLine("Ex1");
            Stack<int> s1 = new Stack<int>();
            s1.Push(12);
            s1.Push(14);
            s1.Push(34);
            s1.Push(567);
            s1.Push(34);
            Console.WriteLine(s1.ElementAt(1));
        }
    }
}

namespace Wantsome.DotNet7
{
    internal class Parameters
    {

        public void Go()
        {
            int x1 = 10;
            MethodIn(in x1);
            MethodIn(x1);

            Sample s = new Sample();
            MethodIn1(in s);

            MethodOut(out int x2);

            int x3 = 123;
            Console.WriteLine(x3);
            MethodOut(out x3);
            Console.WriteLine(x3);

            MethodOut1(out Sample s1);

            MethodOut2(out int y1, out int y2, out int y3);

            int w3 = 4;
            MethodOut3(out y1, out int w2, w3);

            int x30;
            int.TryParse("3", out x30);
            Console.WriteLine(x30);

            bool canParse = int.TryParse("3", out int x31);
            Console.WriteLine(x31);
            Console.WriteLine(canParse);

            int x40 = 10;
            MethodRef(ref x40);
            Console.WriteLine(x40);

            int x = 50;
            MethodNoRef(x);
            Console.WriteLine(x);

            // Ex
            // Declare and call a method that receives two double parameters. 
            // Do some operations with each of those two doubles.
            // Make sure that one of the two parameters is changed after the method gets executed.

            // 1st double: 2, 2nd double: 10
            // method call
            // 1st double:2, 2nd double: 25

            double nr1 = 2;
            double nr2 = 10;
            MethodOneRef(nr1, ref nr2);
            Console.WriteLine($"{nr1}, {nr2}");
        }

        void MethodIn(in int x)
        {
            //x = 12; //does not work
            int y = 10;
            y += x;
            Console.WriteLine(y);
        }

        void MethodIn1(in Sample s)
        {
            //s = new Sample(); // does not work
            s.id = 45;
            Console.WriteLine(s.id);
        }

        void MethodOut(out int x)
        {
            int y = 10;
            x = y * 2;
        }

        void MethodOut1(out Sample s)
        {
            s = new Sample();
            s.id = 678;
            Console.WriteLine(s.id);
        }

        void MethodOut2(out int x1, out int x2, out int x3)
        {
            x1 = 4;
            x2 = 5;
            x3 = 6;
            Console.WriteLine($"{x1}, {x2}, {x3}");
        }

        void MethodOut3(out int x1, out int x2, int x3)
        {
            x1 = 4;
            x2 = 5;
            x3 = 6;
            Console.WriteLine($"{x1}, {x2}, {x3}");
        }

        void MethodRef(ref int x)
        {
            x = 23;
        }

        void MethodNoRef(int x)
        {
            x = 23;
        }

        void MethodOneRef(double number1, ref double number2)
        {
            number1 = 25;
            number2 = 25;
        }

    }
}

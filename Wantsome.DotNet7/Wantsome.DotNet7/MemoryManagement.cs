using System.Text;

namespace Wantsome.DotNet7
{
    internal class MemoryManagement
    {
        public void Go()
        {
            //GC.Collect();

            Console.WriteLine("--- value and reference types ---");
            int x = 10;
            int y = x;
            Console.WriteLine($"{x}, {y}");
            y = 20;
            Console.WriteLine($"{x}, {y}");

            Sample s1 = new Sample();
            s1.id = 23;
            Sample s2 = s1;
            s2.id = 45;
            Console.WriteLine($"{s1.id}, {s2.id}");

            Sample s3 = new Sample
            {
                id = s1.id
            };
            s3.id = 67;
            Console.WriteLine($"{s1.id}, {s3.id}");

            Sample s4 = (Sample)s1.Clone();
            s4.id = 809;
            Console.WriteLine($"{s1.id}, {s4.id}");

            string name = "ana";
            name += " maria";
            Console.WriteLine(name);

            StringBuilder str1 = new StringBuilder();
            StringBuilder str2 = new StringBuilder("ana");
            str2.Append(" maria");
            Console.WriteLine(str2);

            Console.WriteLine("--- boxing & unboxing ---");
            int i = 123;
            object o = i;
            object o2 = (object)i;
            Console.WriteLine(o);

            object o1 = 123;
            int i1 = (int)o1;
            Console.WriteLine(i1);
        }
    }

    public class Sample : ICloneable
    {
        public int id;

        public object Clone()
        {
            return new Sample
            {
                id = this.id
            };
        }
    }
}

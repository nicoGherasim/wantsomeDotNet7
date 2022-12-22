namespace Wantsome.DotNet7
{
    public class Structures
    {
        public void Go()
        {
            Console.WriteLine("--- class ---");
            var studentClass = new StudentClass();
            studentClass.id = 10;
            studentClass.GetId();


            Console.WriteLine("--- struct ---");
            var studentStruct = new StudentStruct();
            studentStruct.id = 20;
            studentStruct.GetId();

            StudentStruct ss1 = studentStruct;
            ss1.id = 789;

            Console.WriteLine(studentStruct.id + " " + ss1.id);

            StudentStruct ss2;
            ss2.id = 678;

            StudentClass sc1 = new StudentClass();
            sc1.id = 908;

            // Ex1
            // Create and use a struct that has something to do with your current work domain.
            // Minimum req: at least two properties and at least one method.

            Developer dev = new Developer
            {
                Technology = ".NET",
                SeniorityLevel = "junior"
            };
            dev.Display();
        }

    }

    public class StudentClass
    {
        public int id;

        public int Age { get; set; }

        public void GetId()
        {
            Console.WriteLine("id: " + id);
        }

        public StudentClass()
        {
            id = 23;
        }

        public StudentClass(int id)
        {
            this.id = id;
        }
    }

    public struct StudentStruct
    {
        public int id;

        public int Age { get; set; }

        public void GetId()
        {
            Console.WriteLine("id: " + id);
        }
        public StudentStruct()
        {
            id = 56;
            Age = 4;
        }
    }

    public struct Developer
    {
        public string Technology { get; set; }
        public string SeniorityLevel { get; set; }
        public void Display()
        {
            Console.WriteLine($"technology: {Technology}, seniority level: {SeniorityLevel}");
        }
    }
}

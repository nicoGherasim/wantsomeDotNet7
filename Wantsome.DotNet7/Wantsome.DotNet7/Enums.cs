namespace Wantsome.DotNet7
{
    internal class Enums
    {
        public void Go()
        {
            Console.WriteLine("--- enums ---");
            Console.WriteLine(Status.InReview);
            Console.WriteLine((int)Status.InReview);
            Console.WriteLine("get name: " + Enum.GetName(typeof(Status), 2));

            // Ex1
            // Declare an enum that holds the months of the year and display the seventh month (it should be July).

            Console.WriteLine("7th month: " + Enum.GetName(typeof(Month), 7));

            // Ex2
            // Declare a Calendar class which should have an Month property of type enum (the one build earlier)
            // Add at least two more proerties to the calendar
            // Create an call a method that diplays a messsage using all three properties

            Calendar cal = new Calendar
            {
                Day = 1,
                Event = "holiday",
                MonthOfTheYear = Month.January
            };
            cal.Display();
        }


        public enum Status
        {
            InReview = 35,
            Approved,
            InProgress = 89,
            Done
        }

        public enum Month
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        public class Calendar
        {
            public int Day { get; set; }
            public string Event { get; set; }
            public Month MonthOfTheYear { get; set; }
            public void Display()
            {
                Console.WriteLine($"day: {Day}, event: {Event}, month: {MonthOfTheYear}");
            }
        }
    }
}

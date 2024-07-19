using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("27 Dew Street", "Pane", "Delta", "Nigeria");
        LectureEvent event1 = new LectureEvent("Google Upcoming Lecture", "Google Free Web Development Course Lecture", "17-03-2024", "1:00pm", address1, "John Derick", 5000);

        Console.WriteLine(event1.GetStandardDetails());       
        Console.WriteLine();
        Console.WriteLine(event1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(event1.GetShortDescription());

        Console.WriteLine("\n-------------------------------------------------\n");

        Address address2 = new Address("No. 21 Odogun Street", "Eku", "Delta", "Nigeria");
        ReceptionEvent event2 = new ReceptionEvent("Birthday Party", "Ogheneserome's Birthday Party", "12-07-2024", "12:00pm", address2, "weconnect@connection.com");

        Console.WriteLine(event2.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(event2.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(event2.GetShortDescription());

        Console.WriteLine("\n-------------------------------------------------\n");

        Address address3 = new Address("139 Palace Street", "Tin", "Delta", "Nigeria");
        OutdoorGatheringEvent event3 = new OutdoorGatheringEvent("Microsoft Meetup", "Microsoft Tech Conference Meetup", "15-09-2024", "12:00pm", address3, "Showers in the morning; otherwise, cloudy and breezy");

        Console.WriteLine(event3.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(event3.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(event3.GetShortDescription());
    }
}
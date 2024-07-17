using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Jumping over a tall brigde", "John", (1000 * 20));
        video1.AddComment("David", "This is awful");
        video1.AddComment("Lexus", "Good!!!");
        video1.AddComment("James", "Wow!");

        Video video2 = new Video("Car Vs Lava", "John", (1000 * 30));
        video2.AddComment("James", "Nooooooo");
        video2.AddComment("SaXX", "Nothing great here");
        video2.AddComment("UUid", "Na wa o");

        Video video3 = new Video("Learn JavaScript in 30 minutes", "Kelvin", (1000 * 30));
        video3.AddComment("Me", "You can tell am running of ideas here");
        video3.AddComment("Youu", "I did that on purpose.");
        video3.AddComment("NuLa", "Now this is starting to be exciting");

        Video video4 = new Video("Learn CSS in 15 minutes", "John", (1000 * 15));
        video4.AddComment("Muna", "I don't know what is going on here");
        video4.AddComment("Nono", "okay great");
        video4.AddComment("Left", "of course we done");

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine(video._title);
            Console.WriteLine(video._author);
            Console.WriteLine(video._length);
            Console.WriteLine(video.NumberOfComments());

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"commenter's name: {comment._name}; text: {comment._text} ");
            }

            Console.WriteLine();
        }
    }
}
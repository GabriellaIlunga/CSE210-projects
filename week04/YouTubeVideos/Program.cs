using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        Video v1 = new Video("Easy Homemade Bread", "Baking with Beth", 450);
        v1._comments.Add(new Comment("Sarah", "I tried this and it worked perfectly!"));
        v1._comments.Add(new Comment("John", "Can I use whole wheat flour instead?"));
        v1._comments.Add(new Comment("Mark", "Best bread recipe on YouTube."));
        videoList.Add(v1);

        Video v2 = new Video("C# Classes and Objects", "Tech Tutorials", 900);
        v2._comments.Add(new Comment("Gabriella", "This helped me with my week 4 assignment."));
        v2._comments.Add(new Comment("Luke", "I'm still a bit confused about abstraction."));
        v2._comments.Add(new Comment("Anna", "Great explanation for beginners."));
        videoList.Add(v2);

        Video v3 = new Video("Liverpool vs Arsenal Highlights", "Sports World", 600);
        v3._comments.Add(new Comment("Mo", "What a match!"));
        v3._comments.Add(new Comment("Trent", "The defense was solid today."));
        v3._comments.Add(new Comment("Virgil", "Clean sheet! Let's go!"));
        videoList.Add(v3);

        foreach (Video v in videoList)
        {
            v.Display();
        }
    }
}
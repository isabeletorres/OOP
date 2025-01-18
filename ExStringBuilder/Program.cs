using System;
using ExStringBuilder.Entities;
namespace ExStringBuilder 
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome");

            Post p1 = new Post(
                DateTime.Parse("21/06/2022 13:05:44"),
                "Travelling to New Zeland",
                "I 'm going to visit wonderful country!",
                12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good Night");
            Comment c4 = new Comment("May the Force be with you");

            Post p2 = new Post(
                DateTime.Parse("28/07/2022 23:15:44"),
                "Good nigth guys",
                "see you tomorrow",
                12);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.ReadKey();
        }
    }
}

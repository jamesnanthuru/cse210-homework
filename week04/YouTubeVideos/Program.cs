using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        Video video1 = new Video("C# Tutorial for Beginners", "CodeAcademy", 720);
        video1.AddComment(new Comment("Alice", "This was so helpful!"));
        video1.AddComment(new Comment("Bob", "Finally understand classes."));
        video1.AddComment(new Comment("Charlie", "Can you do one on interfaces next?"));
        videoList.Add(video1);

        Video video2 = new Video("Top 10 Malawian Dishes", "Travel Malawi", 450);
        video2.AddComment(new Comment("Dave", "Nsima is the best!"));
        video2.AddComment(new Comment("Eve", "I need to try all of these."));
        video2.AddComment(new Comment("Frank", "Great videography."));
        video2.AddComment(new Comment("Grace", "Makes me miss home."));
        videoList.Add(video2);

        Video video3 = new Video("How to Play Guitar", "MusicMaster", 1200);
        video3.AddComment(new Comment("Heidi", "My fingers hurt, but it's worth it."));
        video3.AddComment(new Comment("Ivan", "Clear instructions, thanks!"));
        video3.AddComment(new Comment("Judy", "What guitar do you recommend for beginners?"));
        videoList.Add(video3);

        Video video4 = new Video("Space Documentary", "Cosmos", 3600);
        video4.AddComment(new Comment("Mallory", "The universe is mind-blowing."));
        video4.AddComment(new Comment("Niaj", "Great visuals."));
        video4.AddComment(new Comment("Olivia", "Watched this twice already."));
        videoList.Add(video4);

        foreach (Video v in videoList)
        {
            v.DisplayVideoInfo();
        }
    }
}
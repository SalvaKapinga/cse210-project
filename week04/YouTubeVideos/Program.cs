using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create video list
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("How to Cook Jollof Rice", "Chef Kwame", 420);
        video1.AddComment(new Comment("Maya", "This looks so delicious!"));
        video1.AddComment(new Comment("Daniel", "My mom cooks it just like this."));
        video1.AddComment(new Comment("Ali", "Thanks for the tips!"));

        // Video 2
        Video video2 = new Video("Python for Beginners", "CodeMaster", 900);
        video2.AddComment(new Comment("Jane", "Very clear explanation."));
        video2.AddComment(new Comment("Henry", "Helped me pass my class!"));
        video2.AddComment(new Comment("Sophia", "Subscribed!"));

        // Video 3
        Video video3 = new Video("Morning Workout Routine", "FitLife", 600);
        video3.AddComment(new Comment("Zack", "That stretch at the end was killer."));
        video3.AddComment(new Comment("Linda", "Doing this every day now!"));
        video3.AddComment(new Comment("Nia", "Loved the energy!"));

        // Video 4
        Video video4 = new Video("Exploring Malawi", "TravelWithUs", 750);
        video4.AddComment(new Comment("Peter", "I miss Lake Malawi!"));
        video4.AddComment(new Comment("Chipo", "Wow, so beautiful."));
        video4.AddComment(new Comment("Emily", "Adding this to my bucket list."));

        // Add videos to list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // Display all video details
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}

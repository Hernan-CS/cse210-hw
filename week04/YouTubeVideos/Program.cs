using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        /* List where I'll store the videos*/
        List<Video> videos = new List<Video>();

        /* Constructors passing the arguments in the following order title, author, length of seconds, the same way it's within the Video class. 
           By the way, this videos are real and are from my YouTube feed, I wanted to show a little about my content consumption. Moreover, 
           I considered taking comments from each video, but people comments weird things on Internet, so let's better go with mine. */


        /* VIDEO 01 - COMMENTS */
        Video video1 = new Video("37 INSANE Linux Commands you NEED to Know in 2025", "NetworkChuck", 675); /* I'd love to learn how to use Linux software*/
        video1.AddComment(new Comment("George@2", "I prefer Windows to Linux!"));
        video1.AddComment(new Comment("CharlesGames", "Is Linux in PlayStore? I want it."));
        video1.AddComment(new Comment("Henry67", "Great video, very interesting!"));

        /* VIDEO 02 - COMMENTS */
        Video video2 = new Video("Mit Kokosnussschalen Plastik ersetzen | DW News", "DW News", 124); /* I also watch german videos, not always but every so often. */
        video2.AddComment(new Comment("Isaac Hernandez", "The use of plastic should be banned."));
        video2.AddComment(new Comment("Patrick58", "How did I ended up here? I don't even speak German."));
        video2.AddComment(new Comment("Spencer_Harrinson", "Very informative, what a wonderful idea!"));

        /* VIDEO 03 - COMMENTS */
        Video video3 = new Video("I created the WORST Brawlhalla Legend", "Sideflip", 664); /* It's a videogame I play a lot called "Brawlhalla". */
        video3.AddComment(new Comment("SouthMan98", "Lol, it's super broken!"));
        video3.AddComment(new Comment("Sully","I want to play the game right now but my laptop is under repair."));
        video3.AddComment(new Comment("Day_Dreamer", "DUDE! This video is so epic"));
       
        /* VIDEO 04 - COMMENTS */
        Video video4 = new Video("Gerunds & Infinitives - English Grammar Lessons", "Ellii (formerly ESL Library)", 450); /* I'm an English Teacher, so I watch a lot of related videos. */
        video4.AddComment(new Comment("Sam-..-", "Thanks for the explanation, you helped me a lot!"));
        video4.AddComment(new Comment("MrRama", "I'm going to share this video with my students, thanks."));
        video4.AddComment(new Comment("SergeyBochko", "I want to know the differences beetwen the 1st conditional and the 2nd conditional."));

        /* I store very comment as a new object and pass it as an argument using the method .AddComment() within the Video class. */

        /* Once everything is well set up, I added them to the previous list. */
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        /* Loop to iterate through the videos list and display them with the following format. */
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            /* I think it looks better showing the time in minutes and seconds. */
            int minutes = video.LengthSeconds / 60;
            int seconds = video.LengthSeconds % 60;
            Console.WriteLine($"Length: {minutes} min {seconds} sec");
            Console.WriteLine($"Number of Comments: {video.GetCommentAmount()}"); /* Method found in the Video class. */
            Console.WriteLine("Comments:");

            /* Iterate through every variable of the list got by using the method .GetComments() within the Video class. */
            foreach (Comment comment in video.GetComments())
            {
                /* And finally, print them. */
                Console.WriteLine($"{comment.CommenterName}: {comment.CommentText}");
            }

            /* I found that a shorter way to write hyphens without the necessity of writing too many. */
            Console.WriteLine(new String('-', 40));
        }
    }
}
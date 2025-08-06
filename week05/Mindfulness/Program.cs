using System;
using System.Collections.Generic;
using System.Threading;

abstract class Activity
{
    protected string Name;
    protected string Description;
    protected int Duration;

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void SetDuration()
    {
        Console.Write("Enter duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());
    }

    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"--- {Name} ---");
        Console.WriteLine(Description);
        SetDuration();
        Console.WriteLine("Get ready...");
        DisplaySpinner(3);
    }

    public void EndMessage()
    {
        Console.WriteLine("\nWell done!");
        Console.WriteLine($"You have completed the {Name} for {Duration} seconds.");
        DisplaySpinner(3);
    }

    protected void DisplaySpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    public abstract void Run(); // Must be implemented in derived classes
}

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public override void Run()
    {
        StartMessage();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            DisplaySpinner(4); // 4-second inhale
            Console.WriteLine("Breathe out...");
            DisplaySpinner(6); // 6-second exhale
        }
        EndMessage();
    }
}

class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private Random rand = new Random();

    public ReflectionActivity() : base("Reflection Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience.") { }

    public override void Run()
    {
        StartMessage();
        Console.WriteLine(prompts[rand.Next(prompts.Count)]);
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(questions[rand.Next(questions.Count)]);
            DisplaySpinner(5);
        }
        EndMessage();
    }
}

class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private Random rand = new Random();

    public ListingActivity() : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by listing as many things as you can in a certain area.") { }

    public override void Run()
    {
        StartMessage();
        string prompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine(prompt);
        Console.WriteLine("Start listing your items. Press Enter after each item:");
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        int count = 0;
        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                Console.ReadLine();
                count++;
            }
        }
        Console.WriteLine($"\nYou listed {count} items.");
        EndMessage();
    }
}

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness App");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an activity: ");

            string choice = Console.ReadLine();
            Activity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectionActivity(),
                "3" => new ListingActivity(),
                "4" => null,
                _ => null
            };

            if (activity != null) activity.Run();
            else if (choice == "4") break;
            else Console.WriteLine("Invalid choice. Press Enter to continue...");
            Console.ReadLine();
        }
    }
}


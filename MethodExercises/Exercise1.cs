using System;

namespace MethodExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I have a story to tell!");
            Console.WriteLine("But first I need your help, could you tell me a little bit about yourself?");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("Just one more question, I promise! What is your favorite band?");
            string band = Console.ReadLine();
            Console.WriteLine("Okay, here we go!");
            Console.WriteLine($"When {name} was a young child they would put on their favorite {color} shirt and take their pet {animal} for a walk while listening to {band} on their Walkman Cd Player!");
        }
    }
}

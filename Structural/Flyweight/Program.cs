﻿using DesignPatterns.Structural.Flyweight.Turtles;

namespace DesignPatterns.Structural.Flyweight
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var flyweight = new Flyweight();
            KoopaTroopa turtle;

            while (true)
            {
                Console.Write("Write a color: ");
                var color = Console.ReadLine();

                turtle = flyweight.GetTurtle(color);
                if (turtle == null)
                {
                    Console.WriteLine($"Turtle with color \"{color}\" not found");
                    return;
                }

                turtle.Show(color);
                Console.WriteLine();
            }
        }
    }
}

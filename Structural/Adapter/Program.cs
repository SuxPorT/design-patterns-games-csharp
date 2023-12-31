﻿using DesignPatterns.Structural.Adapter.Actions;

namespace DesignPatterns.Structural.Adapter;

public class Program
{
    public static void Main()
    {
        var character = new Character();
        var battlePlane = new Plane();
        var adapter = new PlaneAdapter(battlePlane);

        Console.WriteLine("Character without adapter:");
        character.Walk("Bob");
        character.Shoot();

        Console.WriteLine("\nCharacter with adapter:");
        adapter.Walk("Bob");
        adapter.Shoot();
    }
}

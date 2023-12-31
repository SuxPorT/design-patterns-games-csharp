﻿using DesignPatterns.Creational.FactoryMethod.Factories;

namespace DesignPatterns.Creational.FactoryMethod;

public class Program
{
    public static void Main()
    {
        var factoryMethod = new CharacterFactory();
        Console.WriteLine("Liu Kang | SubZero | Scorpion\n");
        Console.Write("Choose your character: ");

        var choose = Console.ReadLine();
        var character = factoryMethod.ChooseCharacter(choose!);

        Console.Write("\nYou will play with ");

        if (character == null)
        {
            Console.WriteLine("Unknow character");
            return;
        }

        character!.Chosen();
    }
}

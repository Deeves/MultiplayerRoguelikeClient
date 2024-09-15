using Godot;
using System;


public static class Utility
/*
    * This is a partial class that contains generic utility functions that don't fit  in any paricular component.
    * 
    * This class has a namespace, so it should be accessed through the Utility.(method).
*/

{

    /*
     A collection of Dice Roll and radomization Functions
     =================================================
    */
    public static int Roll20()
    {
        Random random = new Random();
        return random.Next(1, 21);
    }

    public static int Roll100()
    {
        Random random = new Random();
        return random.Next(1, 101);
    }

    public static int Roll6()
    {
        Random random = new Random();
        return random.Next(1, 7);
    }

    public static int Roll8()
    {
        Random random = new Random();
        return random.Next(1, 9);
    }

    public static int Roll10()
    {
        Random random = new Random();
        return random.Next(1, 11);
    }

    public static int Roll12()
    {
        Random random = new Random();
        return random.Next(1, 13);
    }

    public static int Roll4()
    {
        Random random = new Random();
        return random.Next(1, 5);
    }

    public static int Roll3d6()
    {
        Random random = new Random();
        return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
    }

    public static int RollCustom(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max + 1);
    }

    public static Color RollRandomColor()
    {
        float r = GD.Randf(); //random.Next(0, 256);
        float g = GD.Randf(); //random.Next(0, 256);
        float b = GD.Randf(); //random.Next(0, 256);
        return new Color(r, g, b);
    }
    // ==============================================
}

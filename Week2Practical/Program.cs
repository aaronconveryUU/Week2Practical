
//Week 2 Practical
//Info: Methods Demo
//Version 1
//Author: Aaron Convery
//Date: 06/10/25

using Microsoft.VisualBasic.FileIO;
using System;

Main();

static void Main()
{
    int moption = -1;
    while (moption != 0)
    {
        Console.WriteLine("Main Menu\nSelect an option:\n1 - encrypt text\n2 - decrypt text\n3 - print menu\n4 - count words\n5 - circle area\n0 - End");
        moption = Convert.ToInt32(Console.ReadLine());

        switch (moption)
        {
            case 1:
                Encrypt();

                break;
            case 2:
                Decrypt();


                break;
            case 3:
                int option = -1;
                while (option != 0)
                {
                    PrintMenu();
                    option = InputOption();
                    Console.WriteLine(GetMessage(option));
                }
                break;
            case 4:
                CountWords();

                break;
            case 5:
                int coption = -1;
                while (coption != 0)
                {
                    Console.WriteLine("Please enter the radius of the circle you want to find the area of (Enter 0 to Exit):");
                    string input = Console.ReadLine();
                    coption = Convert.ToInt32(input);
                    double rad = double.Parse(input);
                    Console.WriteLine($"The area of the circle with a radius of {rad} is {CircleArea(rad)}");
                }
                break;   
            case 0:

                break;
            default:


                break;

        }


        

        
        
        
    }
}


static void PrintMenu()
{
    Console.WriteLine("Please enter a valid option from below:\n1. Hello in French?\n2. Hello in Spanish?\n3. Hello in German?\n4. Hello in Portugeuse?\n0. Exit Application");
}

static int InputOption()
{
    return Convert.ToInt32(Console.ReadLine());
}


static string GetMessage(int option)
{
    switch (option)
    {
        case 1:
            return "Bonjour";
        case 2:
            return "Hola";
        case 3:
            return "Hallo";
        case 4:
            return "Ciao";
        case 0:
            return "Goodbye";
        default:
            return "Please enter a valid option";

    }
}
static void CountWords()
{
    Console.WriteLine("Enter a String");
    string str = Console.ReadLine();

    int count = 0;

    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] >= 'A' && str[i] <= 'Z')
        {
            count++;
        }
    }

    Console.WriteLine($"The sentence you inputted is: {str}\nNumber of words = {count}");
}

static void Encrypt()
{
    Console.WriteLine("Enter a String");
    string str = Console.ReadLine();
    Console.WriteLine("Enter the number of rotations:");
    int rot = Convert.ToInt32(Console.ReadLine());

    string result = "";

    rot = rot % 26; // Ensure rotation stays within alphabet bounds

    foreach (char ch in str)
    {
        if (ch >= 'A' && ch <= 'Z')
        {
            result += (char)((ch - 'A' + rot) % 26 + 'A');
        }
        else if (ch >= 'a' && ch <= 'z')
        {
            result += (char)((ch - 'a' + rot) % 26 + 'a');
        }
        else
        {
            result += ch; // Non-alphabetic characters remain unchanged
        }
    }

    Console.WriteLine($"The sentence you inputted is: {str}\nThe encrypted sentence is: {result}");
}

static void Decrypt()
{
    Console.WriteLine("Enter a String");
    string str = Console.ReadLine();
    Console.WriteLine("Enter the number of rotations:");
    int rot = Convert.ToInt32(Console.ReadLine());

    string result = "";

    rot = rot % 26; // Ensure rotation stays within alphabet bounds

    foreach (char ch in str)
    {
        if (ch >= 'A' && ch <= 'Z')
        {
            result += (char)((ch - 'A' - rot) % 26 + 'A');
        }
        else if (ch >= 'a' && ch <= 'z')
        {
            result += (char)((ch - 'a' - rot) % 26 + 'a');
        }
        else
        {
            result += ch; // Non-alphabetic characters remain unchanged
        }
    }

    Console.WriteLine($"The sentence you inputted is: {str}\nThe decrypted sentence is: {result}");
}

static double CircleArea(double radius)
{
    const double pi = 3.14;
    return pi * Math.Pow(radius, 2);
}






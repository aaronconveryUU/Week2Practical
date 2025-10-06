
//Week 2 Practical
//Info: Methods Demo
//Version 1
//Author: Aaron Convery
//Date: 06/10/25

using System;

Main();

static void Main()
{
    int option = -1;
    while (option != 0)
    {
        PrintMenu();
        option = InputOption();
        Console.WriteLine(GetMessage(option));
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

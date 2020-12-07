using System;

class Riddles
{
  static void Main()
  {
    Console.WriteLine("I am not alive, but I grow; I don't have lungs, but I need air; I don't have a mouth, but water kills me. What am I?");
    string answer = Console.ReadLine();

    bool correct = answer == "fire";

    if (correct)
    {
      Console.WriteLine("You are correct, you get to live mortal");
    }
    else
    {
      Console.WriteLine("You got eaten by the Sphinx, sorry");
    }
  }
}
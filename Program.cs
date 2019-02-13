using System;

class Program
{
  public static void CheckNumber(int input)
  {
    for (int i=1; i<=input; i++)
    {
      if(i % 5 == 0 && i % 3 == 0)
      {
        Console.WriteLine("ping-pong");
      }
      else if(i%3==0)
      {
        Console.WriteLine("ping");
      }
      else if(i%5==0)
      {
        Console.WriteLine("pong");
      }
      else
      {
        Console.WriteLine(i);
      }
    }
  }
  public static void Main()
  {
    Console.WriteLine("Ping-Pong");
    Console.WriteLine("Enter a word number: ");
    int userInput = int.Parse(Console.ReadLine());
    CheckNumber(userInput);
  }
}

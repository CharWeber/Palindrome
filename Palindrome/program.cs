using System;
using Palindrome;

namespace Program
{
  public class WordPlay
  {
    static void Main()
    {
      Console.WriteLine("Enter a word or phrase to see if it is a palindrome");
      string userInput = Console.ReadLine();
      Phrase userPhrase = new Phrase();
      if (userPhrase.IsPalindrome(userInput))
      {
        Console.WriteLine("It's a palindrome!");
      }
      else
      {
        Console.WriteLine("Nope. Sorry.");
      }
    }
  }
}
using System;


namespace Palindrome
{
  public class Phrase
  {
    public bool IsPalindrome(string word)
    {
      string wordTrimmed = word.Replace(" ", "");
      
      string wordLower = new string(wordTrimmed.ToLower());
      char[] charArray = wordLower.ToCharArray();
      Array.Reverse(charArray);
      string reverseWord = new string(charArray);
      if (wordLower == reverseWord)
      {
        return true;
      }
      return false;
    }
  }
}
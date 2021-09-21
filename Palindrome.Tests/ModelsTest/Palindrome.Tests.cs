using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.Tests
{
  [TestClass]
  public class PhraseTests
  {
    [TestMethod]
    public void IsPalindrome_SameStrForwardsAndBack_True()
    {
      Phrase testPhrase = new Phrase();
      Assert.AreEqual(true, testPhrase.IsPalindrome("racecar"));
    }
    [TestMethod]
    public void IsPalindrome_ConvertsAllCharToLowercase_True()
    {
      Phrase testPhrase = new Phrase();
      Assert.AreEqual(true, testPhrase.IsPalindrome("RaceCar"));
    }
    [TestMethod]
    public void IsPalindrome_RemoveSpaces_True()
    {
      Phrase testPhrase = new Phrase();
      Assert.AreEqual(true, testPhrase.IsPalindrome("taco cat taco cat"));
    }
  }
}

//specs:
// IsPlaindrome() return true false
// just strings(?)
// add int(?)
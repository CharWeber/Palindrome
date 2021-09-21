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
  }
}

//specs:
// IsPlaindrome() return true false
// just strings(?)
// add int(?)
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak;

namespace LeetSpeak.Tests
{
  [TestClass]
  public class LeetSpeakTest
  {   

    [TestMethod]
    public void IsEthere_true()
    {
      Translate testTranslate = new Translate();
      Assert.AreEqual("H3llo", testTranslate.IsEthere("Hello"));
    }
    
    [TestMethod]
    public void IsOthere_true()
    {
      Translate testTranslate = new Translate();
      Assert.AreEqual("Hell0", testTranslate.IsOthere("Hello"));
    }

    [TestMethod]
    public void IsIThere_true()
    {
      Translate testTranslate = new Translate();
      Assert.AreEqual("1sland", testTranslate.IsIThere("Island"));
    }

    [TestMethod]
    public void IsTThere_true()
    {
      Translate testTranslate = new Translate();
      Assert.AreEqual("7es7 7es7 s7ra7", testTranslate.IsTThere("test test strat"));
    }

    [TestMethod]
    public void IsStartsWithS_true()
    {
      Translate testTranslate = new Translate();
      Assert.AreEqual("sazha start", testTranslate.IsStartsWithS("sasha start"));
    }
  }
}
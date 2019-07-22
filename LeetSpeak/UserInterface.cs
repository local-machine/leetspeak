using System;
using Leetspeak.Models;

namespace Leetspeak
{
    public class Translate
    {
        public static void Main()
        {
          Console.WriteLine("Enter your Sentance");
          string userInput= Console.ReadLine();
          LeetspeakTranslator Leetspeak = new LeetspeakTranslator();
          string eThere=LeetSpeak.IsEthere(userInput);
          string oThere= LeetSpeak.IsOthere(eThere);
          string iThere= LeetSpeak.IsIThere(oThere);
          string tThere=LeetSpeak.IsTThere(iThere);
          string sThere= LeetSpeak.IsStartsWithS(tThere);
          Console.WriteLine("output: " + sThere);
        }
    }
}
            
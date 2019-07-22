using System;

namespace LeetSpeak.Models
{
  public class LeetspeakTranslator
  {
    public string IsEthere(string word)
    {
      word.Replace('E','e');
      return word.Replace('e','3');
    } 

    public string IsOthere(string word)
    {
      word.Replace('O','o');
      return word.Replace('o','0');
    } 

    public string IsIThere(string word)
    {
      word.Replace('I','i');
      return word.Replace('i','1');

    } 

    public string IsTThere(string word)
    {
      word.Replace('t','T');
      return word.Replace('T','7');

    } 

    public string IsStartsWithS(string phase)
    {
      string[] wordArry= phase.Split(' ');
      for (int i=0; i<wordArry.Length; i++)
      {
        char[] charArray = wordArry[i].ToCharArray();
        for (int j=1; j<charArray.Length; j++)
        {
          if (charArray[j] == 's' || charArray[j] == 'S')
        {
          charArray[j]= 'z';
        }
        wordArry[i] = string.Join("", charArray);
        }
      }
      string result = string.Join(" ", wordArry);
      return result;
    } 
  }
}

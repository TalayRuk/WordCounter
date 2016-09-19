using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Objects
{
  public class RepeatCounter
  { //variable
    private string _userWord;
    private string _compareString;
    // //constructor
    public RepeatCounter(string userWord, string compareString)
    {
      _userWord = userWord;
      _compareString = compareString;
    }

    public string GetUserWord()
    {
      return _userWord;
    }
    public void SetUserWord(string newUserWord)
    {
      _userWord = newUserWord;
    }
    public string GetCompareString()
    {
      return _compareString;
    }
    public void SetCompareString(string newCompareString)
    {
      _compareString = newCompareString;
    }

    public int CountRepeats()
    {//need to add  variable here & change to lowercase
      //separate string for uStr
      string uWord = this.GetUserWord().ToLower();
      string[] uStr = GetCompareString().ToLower().Split(' ');
      int result = 0;

      foreach (string word in uStr)
      {
        if (uWord == word )
        {
          result++;
        }
      }
      return result;
    }
  }
}

    // public string TrimPuncuation()
    // { string newStr = this.GetCompareString();
    //   int removeLength = 0;
    //   for (int i = newStr.Length - 1; i >=0; i--)
    //   {
    //     char p = newStr[i];
    //     if (p == "?" || p == "!" || p == "," || p == "-" || p == "." || p == ";" || p == ":")
    //     {
    //       removeLength++;
    //     }
    //     else
    //     {
    //       break;
    //     }
    //   }
    //     if (removeLength > 0)
    //     {
    //       return newStr.Substring(0, newStr.Length - removeLength);
    //     }
    //     return newStr
    // }

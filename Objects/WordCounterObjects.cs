using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Objects
{
  public class RepeatCounter
  { //variable
    private string _userWord;
    private string _compareString;
    // private int _result; //counter string or int?
    // // private string _suggestion;
    // //constructor
    public WordsCount(string userWord, string compareString)
    {
      _userWord = userWord;
      _compareString = compareString;
      // _result = 0; //should this b "empty"?
      // // _suggestion = "";
    }
    public string GetUserWord()
    {
      return _userWord;
    }
    public void SetUserWord(string userWord)
    {
      _userWord = userWord;
    }
    public string GetCompareString()
    {
      return _compareString;
    }
    public void SetCompareString(string compareString)
    {
      _compareString = compareString;
    }
    // public int GetResult()
    // {
    //   return _result;
    // }
    // pubic void SetResult()
    // {
    //   _result = CountRepeats();
    // }
    //need to add Count()?
    public int CountRepeats()
    {//need to add  variable here & change to lowercase
      string uWord = this.GetUserWord().ToLower();
      string uStr = this.GetCompareString().ToLower().Split("");
      int result = 0;

      foreach (char word in uStr)
      {
        if (uWord = word )
        {
          result++
        }
        return count;
      }
      // string uW = _userWord;
      // string cStr = _compareString;
      // //search uW in cStr
      // int j = 0;
      // for (int i =0; i <= cStr.Length; i ++ )
      //   if (cStr[i] != uW[0]) {
      //     //find first letter of the word
      //     // for (j=0; j < uW.Lenght; j++) {
      //     //   //not match
      //       // if(cStr[i+j] != uW[j]) {
      //         return 0;
      //
      //     //   }
      //     // }
        // }


      // foreach (char word in u2)
      //  if (word == u1 ) count++;
    }
  }
}

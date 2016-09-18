using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Objects
{
  public class WordsCount
  { //variable
    private string _userInput1;
    private string _compareString;
    private int _result; //counter string or int?
    //constructor
    public WordsCount(string userInput1, string compareString)
    {
      _userInput1 = userInput1;
      _compareString = compareString;
      _result = 0; //should this b "empty"?
    }
    public string GetInput1()
    {
      return _userInput1;
    }
    public void SetInput1(string userInput1)
    {
      _userInput1 = userInput1;
    }
    public string GetCompareString()
    {
      return _compareString;
    }
    public void SetCompareString(string compareString)
    {
      _compareString = compareString;
    }
    public int GetResult()
    {
      return _result;
    }
    pubic void SetResult()
    {
      _result = CounterRepeats();
    }
    //need to add Count()?
    public int CounterRepeats()
    {//need to add private  variable here
      if (this.GetInput1().Any( i => char.IsDigit(i)) || this.GetCompareString().Any(i => char.IsDigit(i)))
      { return 0 + "Please Enter a word!";
      }
      // string u1 = _userInput1;
      // string u2 = _compareString;
      // int count = 0;
      //
      // foreach (char word in u2)
      //  if (word == u1 ) count++;
    }
  }
}

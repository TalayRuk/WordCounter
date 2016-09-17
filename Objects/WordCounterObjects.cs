using System;
using System.Collections.Generic;

namespace WordCounter.Objects
{
  public class WordsCount
  { //variable
    private string _userInput1;
    private string _userInput2;
    private int _result; //counter string or int?
    //constructor
    public WordsCount(string userInput1, string userInput2)
    {
      _userInput1 = userInput1;
      _userInput2 = userInput2;
      _result = 0; //should this b "empty"?
    }
    public string GetInput1()
    {
      return _userInput1;
    }
    public string GetInput2()
    {
      return _userInput2;
    }
    public int GetResult()
    {
      return _result;
    }
    public void SetInput1(string userInput1)
    {
      _userInput1 = userInput1;
    }
    public void SetInput2(string userInput2)
    {
      _userInput2 = userInput2;
    }
    //need to add Count()
    public void CounterRepeats()
    {//dneed to add private  variable here
      string u1 = _userInput1;
      string u2 = _userInput2;

      if (u1 != u2)
      {
        _result = 0;
      }
    }
  }
}

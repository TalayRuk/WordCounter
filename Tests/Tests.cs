using Xunit;
using System;
using System.Collections.Generic;
using WordCounter.Objects; //need to add namespace in HomeModule too

namespace WordCounter
{
  public class RepeatCounter
  {
    [Fact]
    public void Test1_CounterRepeats_Are2OutputsSame_No()
    {
      WordsCount testCount = new WordsCount("and", "1");//parameter need to be "string"
      int newcount = 0;
      Assert.Equal( newcount, testCount.CounterRepeats() );
      //this test doesn't compare letters in string!
      //only compare that both are string
      //the result always pass
    }
  }

}

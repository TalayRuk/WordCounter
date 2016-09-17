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
      WordsCount testCount = new WordsCount("and", "pet");//parameter need to be "string"
      testCount.CounterRepeats();
      int newcount = 0;
      Assert.Equal( newcount, testCount.GetResult() );
    }
  }

}

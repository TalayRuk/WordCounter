using Xunit;
using WordCounter.Objects
using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounter
  {
    [Fact]
    public void Test1_CounterRepeats_Are2OutputsSame_No()
    {
      WordsCount testCount = new WordsCount(and, pet)
      testCount.CouterRepeats();
      int newcount = 0;
      Assert.Equal( newcount, testCount.GetResult() );
    }
  }

}

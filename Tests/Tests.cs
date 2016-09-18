using Xunit;
using System;
using System.Collections.Generic;
using WordCounter.Objects; //need to add namespace in HomeModule too

namespace WordCounter
{
  public class RepeatCounter
  {
    [Fact]
    public void Test1_CountRepeats_Are2OutputsSame_0()
    {
      WordsCount testCount = new WordsCount("a", "b");//parameter need to be "string"
      Assert.Equal( 0 , testCount.CountRepeats() );
      //this test doesn't compare letters in string!
      //only compare that both are string
      //the result always pass
    }
  }

}

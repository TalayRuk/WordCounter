using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using WordCounter.Objects; //need to add namespace in HomeModule too

namespace WordCounter
{
  public class RepeatCounterTest
  {
    [Fact]
    public void Test1_CountRepeats_Are2InputsSame_0()
    {
      RepeatCounter testCount = new RepeatCounter("a", "b");//parameter need to be "string"
      Assert.Equal( 0 , testCount.CountRepeats() );
    }
    [Fact]
    public void Test2_CountRepeats_Are2InputsSame_1()
    {
      RepeatCounter testCount = new RepeatCounter("a", "a");
      Assert.Equal( 1 , testCount.CountRepeats() );
    }
  }

}

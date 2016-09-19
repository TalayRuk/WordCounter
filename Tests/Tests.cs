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
    [Fact]
    public void Test3_CountRepeats_AreUpperCaseInputSameAsLowerCase_1()
    {
      RepeatCounter testCount = new RepeatCounter("A", "a");
      Assert.Equal( 1 , testCount.CountRepeats() );
    }
    [Fact]//don't forget this line!!!
    public void Test4_CountRepeats_CountRepeats_AreTheyMatch_1()
    {
      RepeatCounter testCount = new RepeatCounter("a", "a b");
      Assert.Equal( 1 , testCount.CountRepeats() );
      // not pass! b/c didn't have Fact !!!
    }
    [Fact]
    public void Test5_CountRepeats_Are2WordsMatch_1()
    {
      RepeatCounter testCount = new RepeatCounter("an", "an");
      Assert.Equal( 1 , testCount.CountRepeats() );
    }
    [Fact]
    public void Test6_CountRepeats_Are2WordsMatch_0()
    {
      RepeatCounter testCount = new RepeatCounter("an", "at");
      Assert.Equal( 0 , testCount.CountRepeats() );
    }
    [Fact]
    public void Test7_CountRepeats_Are2WordsMatch_0()
    {
      RepeatCounter testCount = new RepeatCounter("and", "pet");
      Assert.Equal( 0 , testCount.CountRepeats() );
    }
    [Fact]
    public void Test8_CountRepeats_Are2WordsMatch_0()
    {
      RepeatCounter testCount = new RepeatCounter("pet", "pen");
      Assert.Equal( 0 , testCount.CountRepeats() );
    }
    [Fact]
    public void Test9_CountRepeats_Are2WordsMatch_0()
    {
      RepeatCounter testCount = new RepeatCounter("pet", "pets");
      Assert.Equal( 0 , testCount.CountRepeats() );
    }
    [Fact]
    public void Test10_CountRepeats_Are2WordsMatch_1()
    {
      RepeatCounter testCount = new RepeatCounter("pet", "pet");
      Assert.Equal( 1 , testCount.CountRepeats() );
    }
    [Fact]
    public void Test11_CountRepeats_Are2WordsMatch_1()
    {
      RepeatCounter testCount = new RepeatCounter("Pet", "pet");
      Assert.Equal( 1 , testCount.CountRepeats() );
    }
    [Fact]
    public void Test12_CountRepeats_Are2WordsMatch_0()
    {
      RepeatCounter testCount = new RepeatCounter("net", "ten");
      Assert.Equal( 0 , testCount.CountRepeats() );
    }
    [Fact]
    public void Test11_CountRepeats_Are2WordsMatch_0()
    {
      RepeatCounter testCount = new RepeatCounter("near", "earn");
      Assert.Equal( 1 , testCount.CountRepeats() );
    }
  }

}

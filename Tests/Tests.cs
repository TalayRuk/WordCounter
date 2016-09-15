using Xunit;
using RockPaperScissors.Objects;
using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
  public class Tests
  {
    [Fact]
    public void Test1_CompareForWinner_AreOutputsSame_draw()
    {
      Game testGame = new Game(1,1);
      testGame.CompareForWinner();
      string newstring = "DRAW";
      Assert.Equal( newstring , testGame.GetResult() );
    }

    [Fact]
    public void Test2_CompareForWinner_RockVsScissors_Rock()
    {
      Game testGame = new Game(100,1);
      testGame.CompareForWinner();
      string newstring = "Rock Wins";
      Assert.Equal( newstring , testGame.GetResult() );
    }

    [Fact]
    public void Test3_CompareForWinner_RockVsPaper_Paper()
    {
      Game testGame = new Game(100,10);
      testGame.CompareForWinner();
      string newstring = "Paper Wins";
      Assert.Equal( newstring , testGame.GetResult() );
    }
    [Fact]
    public void Test4_CompareForWinner_ScissorsVsPaper_Scissors()
    {
      Game testGame = new Game(10,1);
      testGame.CompareForWinner();
      string newstring = "Scissors Wins";
      Assert.Equal( newstring , testGame.GetResult() );
    }


  }
}

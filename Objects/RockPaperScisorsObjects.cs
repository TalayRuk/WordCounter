using System;
using System.Collections.Generic;


namespace RockPaperScissors.Objects
{
  public class Game
  {
    private int _player1;
    private int _player2;
    private string _result;

    public Game(int player1, int player2)
    {
      _player1 = player1;
      _player2 = player2;
      _result = " ";
    }
    public int GetPlayer1()
    {
      return _player1;
    }
    public int GetPlayer2()
    {
      return _player2;
    }
    public string GetResult()
    {
      return _result;
    }
    public void SetPlayer1(int player1)
    {
      _player1 = player1;
    }
    public void SetPlayer2(int player2)
    {
      _player2 = player2;
    }


    // rock = 100
    // paper = 10
    // scissors = 1
    public void CompareForWinner()
    {
      int p1 = _player1;
      int p2 = _player2;
      int Pcalc = Math.Abs(p1-p2);
      if (p1 == p2)
      {
        _result = "DRAW";
      }
      if (Pcalc == 99)
      // if statements dont need ";" at the end. dont listen to the error bar
      {
        _result = "Rock Wins";
      }
      if (Pcalc == 90)
      {
        _result = "Paper Wins";
      }
      if (Pcalc == 9)
      {
        _result = "Scissors Wins";
      }
    }



  }
}

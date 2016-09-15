using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Nancy;
using RockPaperScissors;
using RockPaperScissors.Objects;

namespace RockPaperScissors
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {return View["index.cshtml"]; };

      Get["/result"] = _ =>
      {
        int p1 = Int32.Parse(Request.Query["optionsRadiosP1"]);
        int p2 = Int32.Parse(Request.Query["optionsRadiosP2"]);
        Console.WriteLine(p2);
        Game resultGame = new Game(p1,p2);
        resultGame.CompareForWinner();
        return View["result.cshtml" , resultGame ];
      };
    }
  }
}

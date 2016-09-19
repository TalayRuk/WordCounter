using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Nancy;
using WordCounter.Objects;

namespace WordCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Get["/result"] = _ => {
        return View["index.cshtml"];
      };

      Post["/result"] = _ => {
        RepeatCounter newRepeatCounter = new RepeatCounter( Request.Form["new-word"], Request.Form["new-sentence"]);
        return View["result.cshtml", newRepeatCounter];
      };
    }
  }
}

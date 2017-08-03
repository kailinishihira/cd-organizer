using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using CD.Models;

namespace CD.Controllers
{
  public class HomeController: Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/cd/list")]
    public ActionResult CdList()
    {
      string newCdTitle = Request.Form["new-title"];
      CDs newCD = new CDs(newCdTitle);

      List<CDs> newList = CDs.GetAllCds();
      return View(newList);
    }

    [HttpGet("/cd/add")]
    public ActionResult CdAdd()
    {
      return View();
    }

  }
}

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

    [HttpGet("/cd/add-artist")]
    public ActionResult AddArtist()
    {
      // Dictionary<string, object> model = new Dictionary<string, object>();
      // Artist selectedCD = Artist.Find(Int32.Parse(Request.Form["new-title"]))

      return View();
    }

    [HttpPost("/cd/all-artists")]
    public ActionResult AllArtists()
    {
    string addArtist = Request.Form["new-artist"];
    Artist newArtist = new Artist(addArtist);

    List<Artist> Artists = Artist.GetAllArtists();
    return View(Artists);
    }

    [HttpGet("/artist/{id}")]
    public ActionResult ViewCdCatalog()
    {
      return View();
    }
  }
}

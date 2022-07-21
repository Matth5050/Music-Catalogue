using Microsoft.AspNetCore.Mvc;
using Catalogue.Models;
using System.Collections.Generic;

namespace Catalogue.Controllers
{
  public class SongsController : Controller
  {

    [HttpGet("/songs")]
    public ActionResult Index()
    {
      List<Song> allItems = Song.GetAll();
      return View(allItems);
    }

    [HttpGet("/songs/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/songs")]
    public ActionResult Create(string description)
    {
      Song mySong = new Song(description);
      return RedirectToAction("Index");
    }

  }
}
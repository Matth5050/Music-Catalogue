using Microsoft.AspNetCore.Mvc;
using Catalogue.Models;
using System.Collections.Generic;

namespace Catalogue.Controllers
{
  public class SongsController : Controller
  {

   

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

    [HttpGet("/albums/{albumId}/songs/{songId}")]
    public ActionResult Show(int albumId, int songId)
    {
      Song song = Song.Find(songId);
      Album album = Album.Find(albumId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("song", song);
      model.Add("album", album);
      return View(model);
    }

   

  }
}
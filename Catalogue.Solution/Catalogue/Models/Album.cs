using System.Collections.Generic;

namespace Catalogue.Models
{
  public class Album
  {
    private static List<Album> _instances = new List<Album> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Song> Songs { get; set; }
  

  public Album(string albumName)
  {
    Name = albumName;
    _instances.Add(this);
    Id = _instances.Count;
    Songs = new List<Song>{};
  }
}
}
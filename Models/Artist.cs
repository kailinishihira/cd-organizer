using System.Collections.Generic;

namespace CD.Models
{
  public class Artist
  {
    private static List<Artist> _artistList = new List<Artist> {};
    private string _artistName;
    private int _id;
    private List<CDs> _cdList;

    public Artist(string artistName)
    {
      _artistName = artistName;
      _artistList.Add(this);
      _id = _artistList.Count;
      _cdList = new List<CDs>{};
    }

    public string GetArtistName()
    {
      return _artistName;
    }

    public int GetId()
    {
      return _id;
    }

    public static List<Artist> GetAllArtists()
    {
      return _artistList;
    }

    // public static void Clear()
    // {
    //   _instances.Clear();
    // }
    // public static Category Find(int searchId)
    // {
    //   return _instances[searchId-1];
    // }

    public List<CDs> GetCDs()
    {
      return _cdList;
    }
    public void AddCDs(CDs cd)
    {
      _cdList.Add(cd);
    }
  }
}

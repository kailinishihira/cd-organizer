using System.Collections.Generic;

namespace CD.Models
{

  public class CDs
  {
    private string _cdTitle;
    // private string _cdArtist;
    private static List<CDs> _cdList = new List<CDs> {};

    public CDs (string cdTitle)
    {
      _cdTitle = cdTitle;
      _cdList.Add(this);
      // _id = _instances.Count;
    }

    public string GetCdTitle()
    {
      return _cdTitle;
    }

    public void SetCdTitle(string cdTitle)
    {
      _cdTitle = cdTitle;
    }

    // public int GetID() {
    //   return _id;
    // }

    public static List<CDs> GetAllCds()
    {
      return _cdList;
    }
    //
    // public static void ClearAll()
    // {
    //   _instances.Clear();
    // }
    //
    // public static Task Find(int searchID)
    // {
    //   return _instances[searchID - 1];
    // }
  }
}

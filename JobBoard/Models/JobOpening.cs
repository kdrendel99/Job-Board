using System.Collections.Generic;

namespace JobBoard.Models
{
  public class JobOpening
  {
    public string Title {get; set; }
    public string Description {get; set; }
    private static List<JobOpening> _instances = new List<JobOpening> { };

    public JobOpening(string title, string description)
    {
      Title = title;
      Description = description;
      _instances.Add(this);
    }

    public static List<JobOpening> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
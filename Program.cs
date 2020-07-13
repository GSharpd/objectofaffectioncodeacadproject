using System;

namespace DatingProfile
{
  class Program
  {
    static void Main(string[] args)
    {
      Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him");
      sam.SetHobbies(new string[] {"swimming", "playing games", "bdsm", "chronical shower masturbation"});
      Console.WriteLine(sam.ViewProfile());
    }
  }
}

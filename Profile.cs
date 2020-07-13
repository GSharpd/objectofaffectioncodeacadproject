using System;

namespace DatingProfile
{
  class Profile
  {
    //fields
    private string name;
    private int age;
    private string city;
    private string country;
    private string pronouns;
    private string[] hobbies;
  
   //constructor
    public Profile(string name, int age, string city, string country, string pronouns = "they/them")
    {
      this.name = name;
      this.age = age;
      this.city = city;
      this.country = country;
      this.pronouns = pronouns;
      this.hobbies = new string[0];
    }

    //methods
    public string ViewProfile()
    {
      string bio = $"Name: {name}\nAge: {age}\nCity: {city}\nCountry: {country}\nPronouns: {pronouns}\n";
      bio += "Hobbies:\n";
      if(hobbies.Length == 0)
      {
      return bio += "This person has set no hobbies!";
      }
      else
      {      
      foreach(string hobby in hobbies)
      {
        bio += $"- {hobby}\n";
      }
      return bio;
      }
    }
    
      public void SetHobbies(string[] hobbies)
      {
      this.hobbies = hobbies;
      }
    
}
}

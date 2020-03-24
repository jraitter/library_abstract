namespace library_abstract.Models
{
  class Newspaper : Publication
  {
    public string City { get; set; }
    public string DayOfWeek { get; set; }
    public Newspaper(string title, bool checkedOut, PubType pubType, string city, string dayOfWeek) : base(title, checkedOut, pubType)
    {
      City = city;
      DayOfWeek = dayOfWeek;
    }
  }//end of class
}//end of namespace
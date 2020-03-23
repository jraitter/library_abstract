using library_abstract.Interfaces;

namespace library_abstract.Models
{
  class Book : Publication, ICheckoutable
  {
    public string Author { get; set; }
    public string UPC { get; set; }
    public Book(string title, bool checkedOut, PubType pubType, string author) : base(title, checkedOut, pubType)
    {
      Author = author;
    }


  }//end of class
}//end of namespace
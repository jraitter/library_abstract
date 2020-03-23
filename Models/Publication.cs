namespace library_abstract.Models
{

  abstract class Publication
  {


    public string Title { get; set; }
    public bool CheckedOut { get; set; }
    public PubType PubType { get; set; }


    protected Publication(string title, bool checkedOut, PubType pubType)
    {
      Title = title;
      CheckedOut = checkedOut;
      PubType = pubType;
    }

  }// end of class
  enum PubType
  {
    book,
    magazine,
    newspaper
  }
} // end of namespace
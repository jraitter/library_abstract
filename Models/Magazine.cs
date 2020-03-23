namespace library_abstract.Models
{
  class Magazine : Publication
  {
    public string Publisher { get; set; }
    public string Volume { get; set; }
    public Magazine(string title, bool checkedOut, PubType pubType, string publisher, string volume) : base(title, checkedOut, pubType)
    {
      Volume = volume;
      Publisher = publisher;
    }




  }//end of class
}//end of namespace
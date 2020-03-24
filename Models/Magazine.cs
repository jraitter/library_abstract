using System;
using library_abstract.Interfaces;

namespace library_abstract.Models
{
  class Magazine : Publication, ICheckoutable
  {
    public string Publisher { get; set; }
    public string Volume { get; set; }
    public string UPC { get; set; }

    public Magazine(string title, bool checkedOut, PubType pubType, string publisher, string volume) : base(title, checkedOut, pubType)
    {
      Volume = volume;
      Publisher = publisher;
      string UUID = Guid.NewGuid().ToString();
      UPC = UUID;
    }




  }//end of class
}//end of namespace
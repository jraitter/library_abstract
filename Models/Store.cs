using System.Collections.Generic;
using library_abstract.Interfaces;

namespace library_abstract.Models
{
  class Store
  {
    public string Address { get; set; }
    public List<ICheckoutable> Checkouts { get; set; }
    public List<Magazine> Magazines { get; set; }
    public List<Newspaper> NewsPapers { get; set; }



  }//endof class
}//endof namespace
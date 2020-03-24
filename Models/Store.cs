using System;
using System.Collections.Generic;
using library_abstract.Interfaces;

namespace library_abstract.Models
{
  class Store
  {
    //properties
    public string Address { get; set; }
    public List<ICheckoutable> Checkouts { get; set; }
    public List<Magazine> Magazines { get; set; }
    public List<Newspaper> NewsPapers { get; set; }

    //helper methods
    public void AddMag(Magazine newMag)
    {
      Magazines.Add(newMag);
    }
    public void AddPaper(Newspaper newPaper)
    {
      NewsPapers.Add(newPaper);
    }
    public void AddItem(ICheckoutable newItem)
    {
      Checkouts.Add(newItem);
    }
    public void AddItem(IEnumerable<ICheckoutable> newItems)
    {
      //add list of books
      Checkouts.AddRange(newItems);
    }

    public void PrintAvailableItems()
    {
      Console.WriteLine("Items that can be checked out: ");
      for (int i = 0; i < Checkouts.Count; i++)
      {
        ICheckoutable item = Checkouts[i];
        if (item is Book)
        {
          Book book = (Book)item;//explicit type casting (force after checking w/ is)
          Console.WriteLine($"{i + 1}. Type={book.PubType}: {book.Title} -- {book.Author} ");
        }
        Magazine newMag = item as Magazine;//implicit type casting, try and check for null
        if (newMag != null)
        {
          Console.WriteLine($"{i + 1}. Type={newMag.PubType}: {newMag.Title} -- {newMag.Volume} ");
        }
      }
    }//end of printavailabeitems
    public void PrintViewOnly()
    {
      Console.WriteLine("Items that can be viewed only: ");

      for (int i = 0; i < NewsPapers.Count; i++)
      {
        Console.WriteLine($"{i + 1}. Type={NewsPapers[i].PubType}: {NewsPapers[i].Title} -- {NewsPapers[i].City} -- {NewsPapers[i].DayOfWeek} ");
      }
    }

    public Store(string address)
    {
      Address = address;
      Checkouts = new List<ICheckoutable>();
      Magazines = new List<Magazine>();
      NewsPapers = new List<Newspaper>();
    }


  }//endof class
}//endof namespace
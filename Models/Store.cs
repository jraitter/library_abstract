using System;
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
      for (int i = 0; i < Checkouts.Count; i++)
      {
        ICheckoutable item = Checkouts[i];
        if (item is Book)
        {
          Book book = (Book)item;
          Console.WriteLine($"{i + 1}. Type={book.PubType}: {book.Title} -- {book.Author} \n");
        }
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
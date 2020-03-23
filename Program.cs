using System;
using System.Collections.Generic;
using library_abstract.Interfaces;
using library_abstract.Models;

namespace library_abstract
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Store nampa = new Store("123 Maint St.");
      nampa.AddItem(new Book("Where The Sidewalk Ends", false, PubType.book, "Shel Silverstein"));

      Book sw4 = new Book("Star Wars: A New Hope", false, PubType.book, "Ryder Windham");
      Book sw5 = new Book("Star Wars: Empire Strikes Back", false, PubType.book, "Ryder Windham");
      Book sw6 = new Book("Star Wars: Return of the Jedi", false, PubType.book, "Ryder Windham");

      List<ICheckoutable> swSagabooks = new List<ICheckoutable>()
      {
        sw4,
        sw5,
        sw6
      };
      nampa.AddItem(swSagabooks);//using method overriding passing list

      nampa.PrintAvailableItems();
    }
  }
}

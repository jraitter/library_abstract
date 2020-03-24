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
      nampa.AddItem(new Magazine("Arizona Highways", false, PubType.magazine, "AZ. Magazine", "Original"));
      Magazine vol1 = new Magazine("Arizona Highways", false, PubType.magazine, "AZ. Magazine", "Volume1968.1");
      Magazine vol2 = new Magazine("Arizona Highways", false, PubType.magazine, "AZ. Magazine", "Volume1968.2");
      Magazine vol3 = new Magazine("Arizona Highways", false, PubType.magazine, "AZ. Magazine", "Volume1968.3");
      Magazine vol4 = new Magazine("Arizona Highways", false, PubType.magazine, "AZ. Magazine", "Volume1968.4");
      Magazine vol5 = new Magazine("Arizona Highways", false, PubType.magazine, "AZ. Magazine", "Volume1968.5");
      Magazine vol6 = new Magazine("Arizona Highways", false, PubType.magazine, "AZ. Magazine", "Volume1968.6");
      Magazine vol7 = new Magazine("Arizona Highways", false, PubType.magazine, "AZ. Magazine", "Volume1968.7");
      Magazine vol8 = new Magazine("Arizona Highways", false, PubType.magazine, "AZ. Magazine", "Volume1968.8");
      Magazine vol9 = new Magazine("Arizona Highways", false, PubType.magazine, "AZ. Magazine", "Volume1968.9");
      Magazine vol10 = new Magazine("Arizona Highways", false, PubType.magazine, "AZ. Magazine", "Volume1968.10");
      Magazine vol11 = new Magazine("Arizona Highways", false, PubType.magazine, "AZ. Magazine", "Volume1968.11");
      Magazine vol12 = new Magazine("Arizona Highways", false, PubType.magazine, "AZ. Magazine", "Volume1968.12");
      List<ICheckoutable> azHiways = new List<ICheckoutable>()
      {
        vol1,vol2,vol3,vol4,vol5,vol6,vol7,vol8,vol9,vol10,vol11,vol12
      };
      nampa.AddItem(azHiways);//using method overriding passing list
      nampa.AddItem(new Book("Where The Sidewalk Ends", false, PubType.book, "Shel Silverstein"));
      Book sw4 = new Book("Star Wars: A New Hope", false, PubType.book, "Ryder Windham");
      Book sw5 = new Book("Star Wars: Empire Strikes Back", false, PubType.book, "Ryder Windham");
      Book sw6 = new Book("Star Wars: Return of the Jedi", false, PubType.book, "Ryder Windham");
      List<ICheckoutable> swSagabooks = new List<ICheckoutable>()
      {
        sw4,sw5,sw6
      };
      nampa.AddItem(swSagabooks);//using method overriding passing list

      nampa.PrintAvailableItems();
    }
  }
}

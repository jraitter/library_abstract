namespace library_abstract.Interfaces
{
  interface ICheckoutable
  {
    public bool CheckedOut { get; set; }
    public string UPC { get; set; }
  }
}
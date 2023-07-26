using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Category
  {
    public string Name { get; set; }
    public int CategoryId { get; set; }
    public List<Item> Items { get; set; }

  }
}

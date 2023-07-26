using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    public string Description { get; set; }
    public int ItemId{ get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; }

    public override bool Equals(System.Object otherItem)
    {
      if (!(otherItem is Item))
      {
        return false;
      }
      else
      {
        Item newItem = (Item) otherItem;
        bool idEquality = (this.ItemId == newItem.ItemId);
        bool descriptionEquality = (this.Description == newItem.Description);
        return (idEquality && descriptionEquality);
      }
    }

    public override int GetHashCode()
    {
        return ItemId.GetHashCode();
    }

  }
}

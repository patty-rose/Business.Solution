using System.ComponentModel.DataAnnotations;

namespace Business.Models
{
  public class Shop
  {
    public int ShopId { get; set; }

    public string Name { get; set; }

    public string ShopType { get; set; }

    public string TypeCategory { get; set; }
  }
}
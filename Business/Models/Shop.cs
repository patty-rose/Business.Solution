using System.ComponentModel.DataAnnotations;

namespace Business.Models
{
  public class Shop
  {
    [Required(ErrorMessage = "'ShopId' is required.")]
    public int ShopId { get; set; }

    [Required(ErrorMessage = "'Name' is required."), StringLength(50)]
    public string Name { get; set; }

    [Required(ErrorMessage = "'ShopType' is required."), StringLength(50)]
    public string ShopType { get; set; }

    [Required(ErrorMessage = "'TypeCategory' is required."), StringLength(50)]
    public string TypeCategory { get; set; }
  }
}
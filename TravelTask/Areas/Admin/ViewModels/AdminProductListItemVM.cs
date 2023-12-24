using TravelTask.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TravelTask.Areas.Admin.ViewModels
{
    public class AdminProductListItemVM
    {
        public int Id { get; set; }

        [MaxLength(64)]
        public string Name { get; set; }
        [MaxLength(128)]

        public decimal Price { get; set; }
        [Column(TypeName = "smallmoney")]

        public string ImageUrl { get; set; }
    }
}

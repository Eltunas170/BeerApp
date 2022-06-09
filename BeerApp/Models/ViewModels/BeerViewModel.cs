using System.ComponentModel.DataAnnotations;

namespace BeerApp.Models.ViewModels
{
    public class BeerViewModel
    {
        [Required]
        [Display(Name = "Nombre")]
        public String? Name { get; set; }

        [Required]
        [Display(Name = "Marca")]
        public int BrandId { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace FormsApp.Models
{
    public class Product
    {
        [Display(Name="Urun Id")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Ürün Adı Alanını Doldurun")]
        [Display(Name="Urun Adi")]
        public string Name { get; set; }  = null!;  

        [Required]
        [Range(0,100000000)]
        [Display(Name="Fiyat")]
        public decimal? Price { get; set; }    

        [Display(Name="Resim")]
        public string Image { get; set; } = string.Empty;   
        public bool IsActive { get; set; }    
        
        [Display(Name="Category")]
        [Required(ErrorMessage ="Kategori Seçin")]
        public int? CategoryId { get; set; }    

        public IFormFile ImageFile { get; set; }
    }
}
using CS350_BaggingApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CS350_BaggingApplication.ViewModels
{
    public class ItemFormViewModel
    {
        public int? Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        
        public string Description { get; set; }


        [Required]
        [Display(Name = "Length in inches")]
        [Range(1, 1000)]
        public double? Length { get; set; }
        
        [Required]
        [Display(Name = "Height in inches")]
        [Range(1, 1000)]
        public double? Height { get; set; }
        
        [Required]
        [Display(Name = "Width in inches")]
        [Range(1, 1000)]
        public double? Width { get; set; }

        [Required]
        [Display(Name = "Weight in pounds")]
        [Range(1, 1000)]
        public double? Weight { get; set; }

        [Required]
        [Display(Name = "Quantity")]
        [Range(1, 100)]
        public int? Quantity { get; set; }

        [Required]
        [Display(Name = "Price in USD $")]
        [Range(1, 1000000)] 
        public double? Price { get; set; }

        public ItemFormViewModel()
        {

        }

        public ItemFormViewModel(Item item)
        {
            Id = item.Id;
            Name = item.Name;
            Description = item.Description;
            Length = item.Length;
            Height = item.Height;
            Width = item.Width;
            Weight = item.Weight;
            Quantity = item.Quantity;
            Price = item.Price;
        }
    }
}
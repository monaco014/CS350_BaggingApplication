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
        public string Name { get; set; }
        
        public string Description { get; set; }


        [Required]
        public int Length { get; set; }
        
        [Required]
        public int Height { get; set; }
        
        [Required]
        public int Width { get; set; }

        [Required]
        public int Weight { get; set; }

        [Required]
        public int Quantity { get; set; }
        
        [Required]
        public int Price { get; set; }

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
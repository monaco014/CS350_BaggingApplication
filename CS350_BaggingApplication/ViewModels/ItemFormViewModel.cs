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
        public IEnumerable<ContainerType> Container { get; set; }

        [Required]
        public int X { get; set; }
        
        [Required]
        public int Y { get; set; }
        
        [Required]
        public int Z { get; set; }
        
        [Required]
        public int Quantity { get; set; }
        
        [Required]
        public int Price { get; set; }
    }
}
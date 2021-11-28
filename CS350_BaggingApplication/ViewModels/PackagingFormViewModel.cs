using CS350_BaggingApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CS350_BaggingApplication.ViewModels
{
    public class PackagingFormViewModel
    {
        public int? Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display (Name = "Length in Inches")]
        [Range(1, 1000)]
        public int? Length { get; set; }

        [Required]
        [Display(Name = "Height in Inches")]
        [Range(1, 1000)]
        public int? Height { get; set; }

        [Required]
        [Display(Name = "Width in Inches")]
        [Range(1, 1000)]
        public int? Width { get; set; }

        [Required]
        [Display(Name = "Weight Capacity in Pounds")]
        [Range(1, 1000)]
        public int? WeightCapacity { get; set; }

        [Required]
        [Display(Name = "Item Limit")]
        [Range(1, 100)]
        public int? HardItemLimit { get; set; }

        public PackagingFormViewModel()
        {

        }

        public PackagingFormViewModel(Packaging pack)
        {
            Id = pack.Id;
            Name = pack.Name;
            Length = pack.Length;
            Height = pack.Height;
            Width = pack.Width;
            WeightCapacity = pack.WeightCapacity;
            HardItemLimit = pack.HardItemLimit;
        }
    }
}
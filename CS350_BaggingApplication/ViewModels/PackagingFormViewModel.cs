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
        public int Length { get; set; }

        [Required]
        public int Height { get; set; }

        [Required]
        public int Width { get; set; }

        [Required]
        public int WeightCapacity { get; set; }

        [Required]
        public int HardItemLimit { get; set; }

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
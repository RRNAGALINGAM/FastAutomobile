﻿using System.ComponentModel.DataAnnotations;

namespace Fast.Web.Models
{
    public class Brand
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display (Name = "Etablished Year")]
        public int EstablishedYear { get; set; }

        [Display(Name = "Brand Logo")]
        public string BrandLogo { get; set; }
    }
}

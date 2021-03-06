﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CS4790A1.Models
{
    public class Site
    {
        [Required(ErrorMessage = "Enter Site Name")]
        public string siteName { get; set; }
        [Required(ErrorMessage = "Email Required")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        public string siteSubmiterEmail { get; set; }
        [Required(ErrorMessage = "Site Description Required")]
        public string siteDescription { get; set; }
        [Required(ErrorMessage = "Land Type Required")]
        public string siteLandType { get; set; }
        public string siteUses { get; set; }
        [Required(ErrorMessage = "Longitude Required")]
        public string siteLong { get; set; }
        [Required(ErrorMessage = "Latitude Required")]
        public string siteLat { get; set; }
        public Boolean? siteLevel { get; set; }

    }
}

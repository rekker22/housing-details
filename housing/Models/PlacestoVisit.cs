﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace housing.Models
{
    public class PlacestoVisit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string TypePreferenceOrder1 { get; set; }
        public string TypePreferenceOrder2 { get; set; }
        public string TypePreferenceOrder3 { get; set; }
        public string TypePreferenceOrder4 { get; set; }
        public string Location { get; set; }
    }
}

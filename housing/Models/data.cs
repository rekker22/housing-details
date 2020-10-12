using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace housing.Models
{
    public class data
    {
        [Key]
        public int Id { get; set; }  
        public string Location { get; set; }
        [Required]
        public int Dfd { get; set; }
        public string AccdName { get; set; }
        public string AccdTypePreferenceOrder1 { get; set; }
        public string AccdTypePreferenceOrder2 { get; set; }
        public string AccdTypePreferenceOrder3 { get; set; }
        public string AccdTypePreferenceOrder4 { get; set; }
        public string PtvName { get; set; }
        public string PtvTypePreferenceOrder1 { get; set; }
        public string PtvTypePreferenceOrder2 { get; set; }
        public string PtvTypePreferenceOrder3 { get; set; }
        public string PtvTypePreferenceOrder4 { get; set; }
        [Required]
        public int Budget { get; set; }
    }
}

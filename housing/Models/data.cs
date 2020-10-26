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
        public string Location { get; set; }
        [Required]
        public int Dfd { get; set; }
        public List<Accommodation> accd { get; set; }
        public List<PlacestoVisit> ptv { get; set; }
        [Required]
        public int Budget { get; set; }
    }
}

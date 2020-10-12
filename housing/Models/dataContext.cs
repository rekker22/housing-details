using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace housing.Models
{
    public class dataContext : DbContext
    {
        public dataContext(DbContextOptions<dataContext> options) : base(options)
        {

        }

        public DbSet<data> Datas { get; set; }
        public DbSet<Accommodation> Accds { get; set; }
        public DbSet<PlacestoVisit> Ptvs { get; set; }
    }
}

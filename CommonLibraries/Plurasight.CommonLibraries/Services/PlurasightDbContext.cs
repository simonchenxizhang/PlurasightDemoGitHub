using Plurasight.CommonLibraries.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Plurasight.CommonLibraries.Services
{
    public class PlurasightDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}

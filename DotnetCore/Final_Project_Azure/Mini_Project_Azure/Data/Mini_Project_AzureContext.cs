using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mini_Project_Azure.Models;

namespace Mini_Project_Azure.Data
{
    public class Mini_Project_AzureContext : DbContext
    {
        public Mini_Project_AzureContext (DbContextOptions<Mini_Project_AzureContext> options)
            : base(options)
        {
        }

        public DbSet<Mini_Project_Azure.Models.Product>? Product { get; set; }
    }
}

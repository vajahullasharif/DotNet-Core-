using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Final_Evaluation_Code.Models;

namespace Final_Evaluation_Code.Data
{
    public class Final_Evaluation_CodeContext : DbContext
    {
        public Final_Evaluation_CodeContext (DbContextOptions<Final_Evaluation_CodeContext> options)
            : base(options)
        {
        }

        public DbSet<Final_Evaluation_Code.Models.Employee>? Employee { get; set; }
    }
}

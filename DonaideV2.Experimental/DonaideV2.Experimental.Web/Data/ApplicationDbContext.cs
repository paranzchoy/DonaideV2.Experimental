using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DonaideV2.Experimental.Domain;

namespace DonaideV2.Experimental.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<DonaideV2.Experimental.Domain.Person> Person { get; set; } = default!;
    }
}

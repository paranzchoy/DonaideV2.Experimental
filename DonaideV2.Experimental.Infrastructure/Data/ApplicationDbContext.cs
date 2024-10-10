using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DonaideV2.Experimental.Domain;

namespace DonaideV2.Experimental.Infrastructure.Data;

// Migrations command:
//  dotnet ef migrations add InitialCreate -p DonaideV2.Experimental.Infrastructure -s DonaideV2.Experimental.Web -c ApplicationDbContext
//  dotnet ef database update -p DonaideV2.Experimental.Infrastructure -s DonaideV2.Experimental.Web

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<DonaideV2.Experimental.Domain.Person> Person { get; set; } = default!;
}

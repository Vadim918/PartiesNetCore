using System;
using Microsoft.EntityFrameworkCore;
using Parties.Core.Models;


namespace Parties.Core.Domain
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<GuestResponse> Parties { get; set; }
        public DbSet<Models.Parties> ResponsePartieses { get; set; }


    }
}
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using API.Enitities;
namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; } 
    }
}
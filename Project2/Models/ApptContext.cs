using System;
using Microsoft.EntityFrameworkCore;

namespace Project2.Models
{
    public class ApptContext : DbContext
    {
        public ApptContext(DbContextOptions<ApptContext> options) : base(options)
        {
        }
        public DbSet<Appt> Appts { get; set; }
    }
}

using IngesDom.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngesDom
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet <User> Users { get; set; }
    }
}

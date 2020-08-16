using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DemoSql.Models
{
    public class DemoDBContex:DbContext
    {
        public DemoDBContex(DbContextOptions<DemoDBContex> options):base(options)
        {

        }
        public DbSet<demoDB> stockmarket { get; set; }
    }
}

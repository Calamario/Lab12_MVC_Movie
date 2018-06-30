using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcMovie2.Models
{
    public class MvcMovie2Context : DbContext
    {
        public MvcMovie2Context (DbContextOptions<MvcMovie2Context> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie2.Models.Movie> Movie { get; set; }
    }
}

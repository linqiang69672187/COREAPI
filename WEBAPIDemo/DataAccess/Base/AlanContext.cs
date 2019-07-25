using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPIDemo.Model.MySQL;

namespace WEBAPIDemo.DataAccess.Base
{
    public class AlanContext:DbContext
    {
        public AlanContext(DbContextOptions<AlanContext> options)
            : base(options)
        { }

        public DbSet<Student> Student { get; set; }
    }
}

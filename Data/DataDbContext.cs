using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RainbowSchoolApi.Model;

namespace RainbowSchoolApi.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext (DbContextOptions<DataDbContext> options)
            : base(options)
        {
        }

        public DbSet<RainbowSchoolApi.Model.RainbowSchool> RainbowSchool { get; set; } = default!;
    }
}

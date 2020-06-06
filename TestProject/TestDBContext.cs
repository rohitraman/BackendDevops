using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestProject.Models;

namespace TestProject
{
    public class TestDBContext:DbContext
    {
        public TestDBContext(DbContextOptions<TestDBContext> options):base(options)
        {
                
        }
        public DbSet<TestModel> testModels { get; set; }
    }
}

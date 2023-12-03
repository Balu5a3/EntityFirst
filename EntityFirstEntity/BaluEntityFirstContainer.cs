using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstEntity
{
    public class BaluEntityFirstContainer : DbContext
    {
        public DbSet<Class1> Class1 { get; set; }
        public DbSet<Class2> Class2 { get; set; }
    }
}

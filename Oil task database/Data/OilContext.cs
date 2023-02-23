using Oil_task_database.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_task_database.Data
{
    public class OilContext : DbContext
    {
        public OilContext()
       : base("OilDb")
        {
        }
        public DbSet<Oil> Oils { get; set; }
    }
}

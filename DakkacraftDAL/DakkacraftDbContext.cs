using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DakkacraftDAL.Models;

namespace DakkacraftDAL
{
    // https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/new-database
    // DbContext allows for an SQL session
    public class DakkacraftDbContext : DbContext
    {
        public DbSet<VerificationUser> VerificationUsers { get; set; }
    }
}

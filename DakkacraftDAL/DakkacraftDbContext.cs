using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DakkacraftDAL.Models;

namespace DakkacraftDAL
{
    // DbContext allows for an SQL session
    public class DakkacraftDbContext : DbContext
    {
        public DbSet<VerificationUser> VerificationUsers { get; set; }
    }
}

using DakkacraftDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DakkacraftDAL
{
    public class Init
    {
        public static void run() {
            // remove Init.run() from DakkacraftAPI.Program.cs
            using (var db = new DakkacraftDbContext())
            {
                var verificationUser = new VerificationUser
                {
                    Id = 0,
                    Uuid = 5,
                    Username = "Branimir XII",
                    VerificationCode = "xisfas2",
                    Verified = false,
                    Update = false
                };


                //db.VerificationUsers.Add(verificationUser);
                //db.SaveChanges();

                // Display all Blogs from the database
                var query = from b in db.VerificationUsers
                            orderby b.Username
                            select b;

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Username);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}

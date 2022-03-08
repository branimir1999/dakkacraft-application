using DakkacraftDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DakkacraftDAL.Repositories;

namespace DakkacraftDAL
{
    public class Init
    {
        public static void run2()
        {
            DakkacraftDbContext context = new DakkacraftDbContext();
            VerificationUserRepository repo = new VerificationUserRepository(context);
            var users = repo.GetAllVerificationUsers();
            if(users.ToList().Count == 0)
            {
                Console.WriteLine("Usao sam u if uvjet");
                populate(repo);
                users = repo.GetAllVerificationUsers();
            }
            Console.WriteLine("Pisem preko liste:\n");
            Console.WriteLine(users.ToList().ToString());
            Console.WriteLine("Pisem preko kolekcije:\n");
            Console.WriteLine(users.ToString());
        }

        private static void populate(VerificationUserRepository repo)
        {
            var verificationUser1 = new VerificationUser
            {
                Id = 0,
                Uuid = 5,
                Username = "Branimir X",
                VerificationCode = "ABCDEF",
                Verified = false,
                Update = false
            };
            var verificationUser2 = new VerificationUser
            {
                Id = 1,
                Uuid = 2,
                Username = "Branimir XI",
                VerificationCode = "FEDCBA",
                Verified = false,
                Update = false
            };
            var verificationUser3 = new VerificationUser
            {
                Uuid = 7,
                Username = "Branimir XII",
                VerificationCode = "ABCCBA",
                Verified = false,
                Update = false
            };

            // *TODO*: implement group add
            repo.AddEntity(verificationUser1);
            repo.AddEntity(verificationUser2);
            repo.AddEntity(verificationUser3);
            repo.Save();
        }
        public static void run() {
            // remove Init.run() from DakkacraftAPI.Program.cs
            using (var db = new DakkacraftDbContext())
            {
                

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

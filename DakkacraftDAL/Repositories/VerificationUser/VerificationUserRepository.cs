using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DakkacraftDAL.Models;
using System.Data.Entity;

namespace DakkacraftDAL.Repositories
{
    // https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application
    class VerificationUserRepository : Repository<VerificationUserDB>, IVerificationUserRepository
    {
        public VerificationUserRepository(DakkacraftDbContext context) : base(context) { }

        private DakkacraftDbContext DakkacraftDbContext {
            get { return Context as DakkacraftDbContext; }
        }

        public void Create(VerificationUserDB verificationUser)
        {
            DakkacraftDbContext.VerificationUsers.Add(verificationUser);
            //throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            VerificationUserDB verificationUser = DakkacraftDbContext.VerificationUsers.Find(id);
            DakkacraftDbContext.VerificationUsers.Remove(verificationUser);
            //throw new NotImplementedException();
        }

        public IEnumerable<VerificationUserDB> GetAllVerificationUsers()
        {
            return DakkacraftDbContext.VerificationUsers.ToList();
            //throw new NotImplementedException();
        }

        public VerificationUserDB GetVerificationUser(int id)
        {
            return DakkacraftDbContext.VerificationUsers.Find(id);
            //throw new NotImplementedException();
        }

        public void Update(VerificationUserDB verificationUser)
        {
            DakkacraftDbContext.Entry(verificationUser).State = EntityState.Modified;
            //throw new NotImplementedException();
        }

        // public void save() is inherited from repository class
    }
}

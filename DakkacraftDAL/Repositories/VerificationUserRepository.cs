using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DakkacraftDAL.Models;
using System.Data.Entity;

namespace DakkacraftDAL.Repositories
{
    class VerificationUserRepository : Repository<VerificationUser>, IVerificationUserRepository
    {
        public VerificationUserRepository(DakkacraftDbContext context) : base(context) { }

        private DakkacraftDbContext DakkacraftDbContext {
            get { return Context as DakkacraftDbContext; }
        }

        public void Create(VerificationUser verificationUser)
        {
            DakkacraftDbContext.VerificationUsers.Add(verificationUser);
            //throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            VerificationUser verificationUser = DakkacraftDbContext.VerificationUsers.Find(id);
            DakkacraftDbContext.VerificationUsers.Remove(verificationUser);
            //throw new NotImplementedException();
        }

        public IEnumerable<VerificationUser> GetAllVerificationUsers()
        {
            return DakkacraftDbContext.VerificationUsers.ToList();
            throw new NotImplementedException();
        }

        public VerificationUser GetVerificationUser(int id)
        {
            return DakkacraftDbContext.VerificationUsers.Find(id);
            //throw new NotImplementedException();
        }

        public void Update(VerificationUser verificationUser)
        {
            DakkacraftDbContext.Entry(verificationUser).State = EntityState.Modified;
            //throw new NotImplementedException();
        }

        // public void save() is inherited from repository class
    }
}

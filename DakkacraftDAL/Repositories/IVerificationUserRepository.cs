using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DakkacraftDAL.Models;

namespace DakkacraftDAL.Repositories
{
    public interface IVerificationUserRepository
    {
        void Create(VerificationUser verificationUser);
        void Update(VerificationUser verificationUser);
        void Delete(int id);
        IEnumerable<VerificationUser> GetAllVerificationUsers();
        VerificationUser GetVerificationUser(int id);
    }
}

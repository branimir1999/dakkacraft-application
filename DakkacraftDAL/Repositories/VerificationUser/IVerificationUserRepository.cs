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
        void Create(VerificationUserDB verificationUser);
        void Update(VerificationUserDB verificationUser);
        void Delete(int id);
        IEnumerable<VerificationUserDB> GetAllVerificationUsers();
        VerificationUserDB GetVerificationUser(int id);
    }
}

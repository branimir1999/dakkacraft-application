using DakkacraftBLL.Models;
using DakkacraftDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DakkacraftBLL.Services
{
    interface IVerificationUserServices
    {
        void setVerificationUser(VerificationUserDB verificationUserDB);
        void createVerificationUser(VerificationRequestDTO verificationRequestDTO);
        String createVerificationCode();
        void verifyVerificationCode(PostVerifyUserDTO postVerifyUserDTO);
    }
}

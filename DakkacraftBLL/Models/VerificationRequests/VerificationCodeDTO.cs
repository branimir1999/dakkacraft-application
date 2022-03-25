using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DakkacraftBLL.Models
{
    // Server vraca verification code korisniku u Minecraftu
    class VerificationCodeDTO
    {
        // Verification code generiran od strane servera
        public String VerificationCode { get; set; }
    }
}

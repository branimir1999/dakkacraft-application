using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DakkacraftBLL.Models
{
    // Discord salje request serveru s kodom za verifikaciju
    class PostVerifyUserDTO
    {
        // ID discord korisnika? potrebnost ovisi o implementaciji discord bota
        public int Uuid { get; set; }
        // Korisnikov (s discorda) verification code
        public String VerificationCode { get; set; }
    }
}

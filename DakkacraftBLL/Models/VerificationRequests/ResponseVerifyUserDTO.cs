using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DakkacraftBLL.Models
{
    // Odgovor discord botu je li verification code ispravan
    class ResponseVerifyUserDTO
    {
        // ID discord korisnika? potrebnost ovisi o implementaciji discord bota
        public int Uuid { get; set; }
        // Stanje uspjesnosti
        public int status { get; set; }
        // Username u koji se treba promijeniti
        public String Username { get; set; }
    }
}

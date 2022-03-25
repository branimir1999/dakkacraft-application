using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DakkacraftBLL.Models
{
    // Minecraft korisnik salje verification request na server; Stavljamo ga na listu korisnika
    class VerificationRequestDTO
    {
        // Minecraft user id
        public int Uuid { get; set; }
        // Minecraft username
        public string Username { get; set; }
    }
}

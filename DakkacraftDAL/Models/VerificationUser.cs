using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DakkacraftDAL.Models
{
    public class VerificationUser
    {
        public int Id { get; set; }
        public int Uuid { get; set; }
        public string Username { get; set; }
        public string VerificationCode { get; set; }
        public bool Verified { get; set; }
        public bool Update { get; set; }
    }
}

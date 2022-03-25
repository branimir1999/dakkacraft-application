using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DakkacraftBLL.Models
{
    class VerificationUserDTO
    {
        public virtual int Id { get; set; }
        [Required]
        public virtual int Uuid { get; set; }
        [Required]
        public virtual string Username { get; set; }
        [Required, StringLength(6)]
        public virtual string VerificationCode { get; set; }
        [Required]
        public virtual bool Verified { get; set; }
        [Required]
        public virtual bool Update { get; set; }
    }
}

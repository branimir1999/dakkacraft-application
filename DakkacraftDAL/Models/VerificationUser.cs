using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DakkacraftDAL.Models
{
    // https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/data-annotations
    public class VerificationUser
    {
        // Auto-generate primary key
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int Uuid { get; set; }
        [Required]
        public string Username { get; set; }
        [Required, StringLength(6)]
        public string VerificationCode { get; set; }
        [Required]
        public bool Verified { get; set; }
        [Required]
        public bool Update { get; set; }
    }
}

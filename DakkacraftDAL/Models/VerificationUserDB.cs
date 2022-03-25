using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DakkacraftDAL.Models.Generic;

namespace DakkacraftDAL.Models
{
    // https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/data-annotations
    [Table("VerificationUsers")]
    public class VerificationUserDB : IIdentifiable
    {
        // Auto-generate primary key
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual Guid Id { get; set; }
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

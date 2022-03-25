using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DakkacraftDAL.Models.Generic
{
    interface IIdentifiable
    {
        Guid Id { get; set; }
    }
}

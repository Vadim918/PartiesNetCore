using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parties.Core.Models
{
    public class Parties
    {
        public int Id { get; set; }

        public string PartiesName { get; set; }

        public virtual ICollection<GuestResponse> GuestResponses { get; set; }
    }
}

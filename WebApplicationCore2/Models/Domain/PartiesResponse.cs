using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore2.Models.Domain
{
    public class PartiesResponse
    {
        public int Id { get; set; }

        public string PartiesName { get; set; }

        public ICollection<UserParties> UserParties { get; set; }

        public PartiesResponse()
        {
           UserParties= new List<UserParties>();
        }
    }
}

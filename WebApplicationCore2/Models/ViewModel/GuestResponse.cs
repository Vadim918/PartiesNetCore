using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore2.Models.Domain
{
    public class GuestResponse
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool WillAttend { get; set; }
        public string PartiesName { get; set; }

    }
}

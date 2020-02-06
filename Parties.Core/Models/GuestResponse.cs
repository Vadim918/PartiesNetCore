using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parties.Core.Models
{
    public class GuestResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool WillAttend { get; set; }

        public virtual Parties Parties { get; set; }
    }
}
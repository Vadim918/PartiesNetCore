﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore2.Models.Domain
{
    public class UserParties
    {
        public int UserId { get; set; }
        public User User  { get; set; }


         public int PartieId { get; set; }
        public PartiesResponse PartiesResponse { get; set; }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore2.Models.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public int? RoleId { get; set; }
        public Role Role { get; set; }
        public virtual ICollection<UserParties> UserParties { get; set; }

        public User()
        {
           UserParties = new List<UserParties>();
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.EntityFrameworkCore;
using WebApplicationCore2.Models.Domain;

namespace WebApplicationCore2.Models.Repository
{
    public class ParticipantsRepository : IParticipantsRepository
    {
            public readonly AppDbContext context;

            public ParticipantsRepository(AppDbContext context)
            {
                this.context = context;
            }

            public IQueryable<User> Read(string PartiesName)
            {
                var partie = context.Parties.FirstOrDefault(x => x.PartiesName == PartiesName);
                var users = context.Users.Where(u => u.UserParties.Any(r => r.PartieId == partie.Id));
               return users;
            }

            public void Save(string name , string partiesName)
            {
                User user = context.Users
                    .FirstOrDefault(x => x.Name == name);
                PartiesResponse partie = context.Parties.FirstOrDefault(x => x.PartiesName == partiesName);
                user.UserParties.Add(new UserParties{ PartieId = partie.Id, UserId = user.Id });
                context.SaveChanges();
            }

            public List<string> ShowParties(string lastParties)
            {
                List<string> partiesList = new List<string>();
                partiesList.Add(lastParties);
                return partiesList;
            }


        
    }
}

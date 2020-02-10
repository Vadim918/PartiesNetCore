using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore2.Models.Domain
{
    public interface IParticipantsRepository
    {
        IQueryable<User> Read(string PartiesName);
        void Save(string entity, string partiesName);

        List<string> ShowParties(string lastParties);

    }
}

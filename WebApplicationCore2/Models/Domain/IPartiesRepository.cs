using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore2.Models.Domain
{
    public interface IPartiesRepository
    {
        IQueryable<PartiesResponse> GetParties();
        PartiesResponse GetById(int id);
        int Save(PartiesResponse entity);
        void Delete(PartiesResponse entity);
    }
}

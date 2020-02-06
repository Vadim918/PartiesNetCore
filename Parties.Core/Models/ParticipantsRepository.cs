using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using Parties.Core.Domain;
using Parties.Core.Models;

namespace Parties.Core.Models
{
    public class ParticipantsRepository
    {
        public readonly AppDbContext context;

        public ParticipantsRepository(AppDbContext context)
        {
            this.context = context;
        }

        //public IQueryable<GuestResponse> Read(string PartiesName)
        //{
        //    return context.GuestResponses.Where(x =>  == PartiesName);
        //}
        public int Save(GuestResponse entity)
        {
            context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();
            return entity.Id;
        }

        public List<string> ShowParties(string lastParties)
        {
            List<string> partiesList = new List<string>();
            partiesList.Add(lastParties);
            return partiesList;
        }


    }   
}
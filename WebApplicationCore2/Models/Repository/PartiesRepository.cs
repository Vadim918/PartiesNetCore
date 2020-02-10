using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationCore2.Models.Domain;

namespace WebApplicationCore2.Models.Repository
{
    public class PartiesRepository : IPartiesRepository
    {
        //класс-репозиторий напрямую обращается к контексту базы данных
        private readonly AppDbContext context;
        public PartiesRepository(AppDbContext context)
        {
            this.context = context;
        }

        //выбрать все записи из таблицы Articles
        public IQueryable<PartiesResponse> GetParties()
        {
            return context.Parties.OrderBy(x => x.PartiesName);
        }

        //найти определенную запись по id
        public PartiesResponse GetById(int id)
        {
            return context.Parties.Single(x => x.Id == id);
        }

        //сохранить новую либо обновить существующую запись в БД
        public int Save(PartiesResponse entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();

            return entity.Id;
        }

        //удалить существующую запись
        public void Delete(PartiesResponse entity)
        {
            context.Parties.Remove(entity);
            context.SaveChanges();
        }

    }
}

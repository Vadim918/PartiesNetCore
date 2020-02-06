using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Parties.Core.Domain;

namespace Parties.Core.Models
{
    public class PartiesRepository
    {
        //класс-репозиторий напрямую обращается к контексту базы данных
        private readonly AppDbContext context;
        public PartiesRepository(AppDbContext context)
        {
            this.context = context;
        }

        //выбрать все записи из таблицы Articles
        public IQueryable<Parties> GetParties()
        {
            return context.ResponsePartieses.OrderBy(x => x.PartiesName);
        }

        //найти определенную запись по id
        public Parties GetArticleById(int id)
        {
            return context.ResponsePartieses.Single(x => x.Id == id);
        }

        //сохранить новую либо обновить существующую запись в БД
        public int SaveArticle(Parties entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();

            return entity.Id;
        }

        //удалить существующую запись
        public void DeleteArticle(Parties entity)
        {
            context.ResponsePartieses.Remove(entity);
            context.SaveChanges();
        }

    }
}

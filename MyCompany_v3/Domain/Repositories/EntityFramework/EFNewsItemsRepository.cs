using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyCompany_v3.Domain.Entities;
using MyCompany_v3.Domain.Repositories.Abstract;

namespace MyCompany_v3.Domain.Repositories.EntityFramework
{
    public class EFNewsItemsRepository : INewsItemRepository
    {
        private readonly AppDbContext context;

        public EFNewsItemsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<NewsItem> GetNewsItems()
        {
            return context.NewsItems;
        }

        public NewsItem GetNewsItemById(Guid id)
        {
            return context.NewsItems.FirstOrDefault(x => x.Id == id);
        }

        public NewsItem GetNewsItemByCodeWord(string codeword)
        {
            return context.NewsItems.FirstOrDefault(x => x.CodeWord == codeword);
        }

        public void SaveNewsItem(NewsItem entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteNewsItem(Guid id)
        {
            context.NewsItems.Remove(new NewsItem() { Id = id });
            context.SaveChanges();
        }
    }
}
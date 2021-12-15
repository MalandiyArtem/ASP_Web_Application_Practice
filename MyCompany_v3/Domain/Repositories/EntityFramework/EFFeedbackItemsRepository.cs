using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyCompany_v3.Domain.Entities;
using MyCompany_v3.Domain.Repositories.Abstract;

namespace MyCompany_v3.Domain.Repositories.EntityFramework
{
    public class EFFeedbackItemsRepository : IFeedbackItemRepository
    {
        private readonly AppDbContext context;

        public EFFeedbackItemsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<FeedbackItem> GetFeedbackItems()
        {
            return context.FeedbackItems;
        }

        public FeedbackItem GetFeedbackItemById(Guid id)
        {
            return context.FeedbackItems.FirstOrDefault(x => x.Id == id);
        }

        public void SaveFeedbackItem(FeedbackItem entity)
        {
            context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();
        }

        public void DeleteFeedbackItem(Guid id)
        {
            context.FeedbackItems.Remove(new FeedbackItem() { Id = id });
            context.SaveChanges();
        }
    }
}

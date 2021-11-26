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
    public class EFReviewItemsRepository : IReviewItemsRepository
    {
        private readonly AppDbContext context;

        public EFReviewItemsRepository(AppDbContext context)
        {
            this.context = context;
        }
        public IQueryable<ReviewItem> GetReviewsItems()
        {
            return context.ReviewItems;
        }

        public ReviewItem GetReviewItemById(Guid id)
        {
            return context.ReviewItems.FirstOrDefault(x => x.Id == id);
        }

        public void SaveReviewItem(ReviewItem entity)
        {
            context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();
        }

        public void DeleteReviewItem(Guid id)
        {
            context.ReviewItems.Remove(new ReviewItem() { Id = id });
            context.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCompany_v3.Domain.Entities;

namespace MyCompany_v3.Domain.Repositories.Abstract
{
    public interface IReviewItemsRepository
    {
        IQueryable<ReviewItem> GetReviewsItems();
        ReviewItem GetReviewItemById(Guid id);
        void SaveReviewItem(ReviewItem entity);
        void DeleteReviewItem(Guid id);
    }
}

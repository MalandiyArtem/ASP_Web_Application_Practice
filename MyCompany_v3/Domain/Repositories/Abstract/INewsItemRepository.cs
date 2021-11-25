using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCompany_v3.Domain.Entities;

namespace MyCompany_v3.Domain.Repositories.Abstract
{
    public interface INewsItemRepository
    {
        IQueryable<NewsItem> GetNewsItems();
        NewsItem GetNewsItemById(Guid id);
        NewsItem GetNewsItemByCodeWord(string codeword);
        void SaveNewsItem(NewsItem entity);
        void DeleteNewsItem(Guid id);
    }
}

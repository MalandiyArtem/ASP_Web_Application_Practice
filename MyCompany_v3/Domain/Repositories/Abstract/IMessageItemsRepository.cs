using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCompany_v3.Domain.Entities;

namespace MyCompany_v3.Domain.Repositories.Abstract
{
    public interface IMessageItemsRepository
    {
        IQueryable<MessageItem> GeMessageItems();
        IQueryable<string> GetUsersId();
        MessageItem GeMessageItemById(Guid id);
        void SaveMessageItem(MessageItem entity);
        void DeleteMessageItem(Guid id);
    }
}

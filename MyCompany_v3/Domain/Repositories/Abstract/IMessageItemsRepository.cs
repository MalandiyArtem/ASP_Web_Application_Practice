using System;
using System.Linq;
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

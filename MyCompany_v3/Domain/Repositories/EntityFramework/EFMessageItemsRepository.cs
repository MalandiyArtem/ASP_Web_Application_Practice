using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyCompany_v3.Domain.Entities;
using MyCompany_v3.Domain.Repositories.Abstract;

namespace MyCompany_v3.Domain.Repositories.EntityFramework
{
    public class EFMessageItemsRepository : IMessageItemsRepository
    {
        private readonly AppDbContext context;

        public EFMessageItemsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<MessageItem> GeMessageItems()
        {
            return context.MessageItems;
        }

        public IQueryable<string> GetUsersId()
        {
            return context.MessageItems.Select(x => x.UserId);
        }

        public MessageItem GeMessageItemById(Guid id)
        {
            return context.MessageItems.FirstOrDefault(x => x.Id == id);
        }

        public void SaveMessageItem(MessageItem entity)
        {
            context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();
        }

        public void DeleteMessageItem(Guid id)
        {
            context.MessageItems.Remove(new MessageItem() { Id = id });
            context.SaveChanges();
        }
    }
}

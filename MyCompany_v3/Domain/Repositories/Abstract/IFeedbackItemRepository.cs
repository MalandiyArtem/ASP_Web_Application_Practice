﻿using MyCompany_v3.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany_v3.Domain.Repositories.Abstract
{
    public interface IFeedbackItemRepository
    {
        IQueryable<FeedbackItem> GetFeedbackItems();
        FeedbackItem GetFeedbackItemById(Guid id);
        void SaveFeedbackItem(FeedbackItem entity);
        void DeleteFeedbackItem(Guid id);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCompany_v3.Domain.Repositories.Abstract;
using MyCompany_v3.Domain.Repositories.EntityFramework;

namespace MyCompany_v3.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }
        public INewsItemRepository NewsItems { get; set; }
        public IMessageItemsRepository MessageItems { get; set; }
        public IReviewItemsRepository ReviewItems { get; set; }

        public DataManager(
            ITextFieldsRepository textFieldsRepository, IServiceItemsRepository serviceItemsRepository,
            INewsItemRepository newsItemRepository, IMessageItemsRepository messageRepository,
            IReviewItemsRepository reviewItemsRepository)
        {
            TextFields = textFieldsRepository;
            ServiceItems = serviceItemsRepository;
            NewsItems = newsItemRepository;
            MessageItems = messageRepository;
            ReviewItems = reviewItemsRepository;
        }
    }
}

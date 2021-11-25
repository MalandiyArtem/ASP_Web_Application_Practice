﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany_v3.Domain.Entities
{
    public class EntityBase
    {
        protected EntityBase()
        {
            DateAdded = DateTime.UtcNow;
        }

        [Required]
        public Guid Id { get; set; }

        [Display(Name="Name (Title)")]
        public virtual string Title { get; set; }

        [Display(Name="Brief description")]
        public virtual string Subtitle { get; set; }

        [Display(Name="Full description")]
        public virtual string Text { get; set; }

        [Display(Name="Title image")]
        public virtual string TitleImagePath { get; set; }

        [Display(Name="SEO metatag Title")]
        public string MetaTitle { get; set; }

        [Display(Name="SEO metatag Description")]
        public string MetaDescription { get; set; }

        [Display(Name = "SEO metatag Keywords")]
        public string MetaKeywords { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}

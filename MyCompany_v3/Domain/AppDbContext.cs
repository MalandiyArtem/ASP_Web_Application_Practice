using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyCompany_v3.Domain.Entities;

namespace MyCompany_v3.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {

         public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

         // проецируем на базу данных
         public DbSet<TextField> TextFields { get; set; }
         public DbSet<ServiceItem> ServiceItems { get; set; }
         public DbSet<NewsItem> NewsItems { get; set; }
         public DbSet<MessageItem> MessageItems { get; set; }
         public DbSet<ReviewItem> ReviewItems { get; set; }
         public DbSet<FeedbackItem> FeedbackItems { get; set; }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             base.OnModelCreating(modelBuilder);

             // Заполняем бд значениями по умолчанию

             // Создаем роли 
             // Роль админа
             modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
             {
                 Id = "391403d9-ba6d-4213-bebe-ad44d7994199",
                 Name = "admin",
                 NormalizedName = "ADMIN"
             });

            // Роль пользователя
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "4ca94fb5-67e7-4e5b-a814-7212f19d2530",
                Name = "user",
                NormalizedName = "USER"
            });

            // Создаем пользователя-админа
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
             {
                 Id = "7ff2d40a-5884-4d27-ba2d-9854b0d29581",
                 UserName = "admin",
                 NormalizedUserName = "ADMIN",
                 Email = "my@email.com",
                 NormalizedEmail = "MY@EMAIL.COM",
                 EmailConfirmed = true,
                 PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                 SecurityStamp = string.Empty
             });

            // Создаем пользователя
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "48a58e3e-7de3-40d3-9d74-97927cbd2c36",
                UserName = "user1",
                NormalizedUserName = "USER1",
                Email = "user1@gmail.com",
                NormalizedEmail = "USER1@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "user1password"),
                SecurityStamp = string.Empty
            });

            // Связываем пользователя с ролью
            // Связываем пользователя-админа с ролью админ
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
             {
                 RoleId = "391403d9-ba6d-4213-bebe-ad44d7994199",
                 UserId = "7ff2d40a-5884-4d27-ba2d-9854b0d29581"
             });

             // Связываем пользователя-админа с ролью пользователь
             modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
             {
                 RoleId = "4ca94fb5-67e7-4e5b-a814-7212f19d2530",
                 UserId = "7ff2d40a-5884-4d27-ba2d-9854b0d29581"
             });

             // Связываем пользователя с ролью пользователь
             modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
             {
                 RoleId = "4ca94fb5-67e7-4e5b-a814-7212f19d2530",
                 UserId = "48a58e3e-7de3-40d3-9d74-97927cbd2c36"
             });

            // Создаем 3 объекта в бд (наши текстовые поля)
            modelBuilder.Entity<TextField>().HasData(new TextField
             {
                 Id = new Guid("fa553176-6507-4047-9531-65a99b83d374"),
                 CodeWord = "PageIndex",
                 Title = "Home page"
             });

             modelBuilder.Entity<TextField>().HasData(new TextField
             {
                 Id = new Guid("27a8a46e-2e1c-49c5-935d-f16de71570ec"),
                 CodeWord = "PageServices",
                 Title = "Our services"
             });

             modelBuilder.Entity<TextField>().HasData(new TextField
             {
                 Id = new Guid("bd9078af-8dc7-4a7a-8d32-2b58c80ba785"),
                 CodeWord = "PageContacts",
                 Title = "Contacts"
             });

             // Создаем новость 
             modelBuilder.Entity<NewsItem>().HasData(new NewsItem
             {
                 Id = new Guid("38eaedaf-34ce-45ae-907a-0ccb17366631"),
                 CodeWord = "PageNews",
                 Title = "We opened",
                 Text = "Join us, we are here!"
             });

            // Создаем сообщение
            modelBuilder.Entity<MessageItem>().HasData(new MessageItem
            {
                Id = new Guid("2a0ca8d6-8f4f-4fe7-b7fc-23e123f650c0"),
                Title = "Tiiitle",
                Text = "Text Text Text Text",
                UserId = "48a58e3e-7de3-40d3-9d74-97927cbd2c36"
            });

            // Создаем новость на рецензию
            modelBuilder.Entity<ReviewItem>().HasData(new ReviewItem
            {
                Id = new Guid("862ff5d9-2f4f-4522-90ae-b8d66cef3764"),
                Title = "First news to review",
                Text = "Hello I am really good at writing news",
                UserId = "48a58e3e-7de3-40d3-9d74-97927cbd2c36"
            });

            // Создаем фидбек на рецензию
            modelBuilder.Entity<FeedbackItem>().HasData(new FeedbackItem
            {
                Id = new Guid("ebb21448-243e-49fb-8fc4-c711b15a6dca"),
                Title = "Well done",
                Text = "Great job, your news was approved",
                UserId = "48a58e3e-7de3-40d3-9d74-97927cbd2c36",
                ReviewId = new Guid("862ff5d9-2f4f-4522-90ae-b8d66cef3764")
            });
        }
    }
}

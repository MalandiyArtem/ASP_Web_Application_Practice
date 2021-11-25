using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

         protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             base.OnModelCreating(modelBuilder);

             // Заполняем бд значениями по умолчанию

             // Создаем роли 
             modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
             {
                 Id = "391403d9-ba6d-4213-bebe-ad44d7994199",
                 Name = "admin",
                 NormalizedName = "ADMIN"
             });


             // Создаем пользователя
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

             // Связываем пользователя с ролью
             modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
             {
                 RoleId = "391403d9-ba6d-4213-bebe-ad44d7994199",
                 UserId = "7ff2d40a-5884-4d27-ba2d-9854b0d29581"
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
         }
    }
}

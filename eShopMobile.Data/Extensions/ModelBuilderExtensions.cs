﻿using eShopMobile.Data.Entity;
using eShopMobile.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMobile.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //seed data
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is homepage of OnlineShopMobile" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of OnlineShopMobile" },
                new AppConfig() { Key = "HomeDescription", Value = "This is description of OnlineShopMobile" }
                );
            modelBuilder.Entity<Language>().HasData(
               new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
               new Language() { Id = "en-US", Name = "English", IsDefault = false }
               );
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active

                },
                new Category()
                {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Status.Active

                });
            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation() {Id=1, CategoryId = 1, Name = "Điện thoại Iphone", LanguageId = "vi-VN", SeoAlias = "dien-thoai-iphone", SeoTitle = "Điện thoại Iphone", SeoDescription = "Điện thoại Iphone" },
                new CategoryTranslation() { Id = 2, CategoryId = 1, Name = "Apple's telephone", LanguageId = "en-US", SeoAlias = "apple-telephone", SeoTitle = "Apple's telephone", SeoDescription = "Apple's telephone" },
                new CategoryTranslation() { Id = 3, CategoryId = 2, Name = "Điện thoại Samsung", LanguageId = "vi-VN", SeoAlias = "dien-thoai-samsung", SeoTitle = "Điện thoại Samsung", SeoDescription = "Điện thoại Samsung" },
                new CategoryTranslation() { Id = 4, CategoryId = 2, Name = "Samsung's telephone", LanguageId = "en-US", SeoAlias = "samsung-telephone", SeoTitle = "Samsung's telephone", SeoDescription = "Samsung's telephone" }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 20000000,
                    Stock = 0,
                    ViewCount = 0
                });
            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation() { Id = 1, ProductId = 1, Name = "Điện thoại Iphone 12 pro", LanguageId = "vi-VN", SeoAlias = "dien-thoai-iphone-12-pro", SeoTitle = "Điện thoại Iphone 12 pro", SeoDescription = "Điện thoại Iphone 12 pro", Details = "Mô tả sản phẩm", Description = "" },
                new ProductTranslation() { Id = 2, ProductId = 1, Name = "Iphone 12 Pro", LanguageId = "en-US", SeoAlias = "iphone-12-pro", SeoTitle = "Iphone 12 Pro", SeoDescription = "Iphone 12 Pro", Details = "Lorem ipsum...", Description = "" }
                );
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                );
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "tedu.international@gmail.com",
                NormalizedEmail = "tedu.international@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName = "Minh",
                LastName = "Phan",
                Dob = new DateTime(1999, 02, 17)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });

        }
    }
}

using Microsoft.EntityFrameworkCore;
using SteamApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamApplication.Data.Utilities.SeederData
{
    public static class Seeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Category 1" },
            new Category { Id = 2, Name = "Category 2" },
            new Category { Id = 3, Name = "Category 3" },
            new Category { Id = 4, Name = "Category 4" },
            new Category { Id = 5, Name = "Category 5" },
            new Category { Id = 6, Name = "Category 6" },
            new Category { Id = 7, Name = "Category 7" },
            new Category { Id = 8, Name = "Category 8" },
            new Category { Id = 9, Name = "Category 9" },
            new Category { Id = 10, Name = "Category 10" },
            new Category { Id = 11, Name = "Category 11" },
            new Category { Id = 12, Name = "Category 12" },
            new Category { Id = 13, Name = "Category 13" },
            new Category { Id = 14, Name = "Category 14" },
            new Category { Id = 15, Name = "Category 15" });

            modelBuilder.Entity<Country>().HasData(
            new Country { Id = 1, Name = "Country 1" },
            new Country { Id = 2, Name = "Country 2" },
            new Country { Id = 3, Name = "Country 3" },
            new Country { Id = 4, Name = "Country 4" },
            new Country { Id = 5, Name = "Country 5" },
            new Country { Id = 6, Name = "Country 6" },
            new Country { Id = 7, Name = "Country 7" },
            new Country { Id = 8, Name = "Country 8" },
            new Country { Id = 9, Name = "Country 9" },
            new Country { Id = 10, Name = "Country 10" },
            new Country { Id = 11, Name = "Country 11" },
            new Country { Id = 12, Name = "Country 12" },
            new Country { Id = 13, Name = "Country 13" },
            new Country { Id = 14, Name = "Country 14" },
            new Country { Id = 15, Name = "Country 15" });

            modelBuilder.Entity<Company>().HasData(
            new Company { Id = 1, Name = "Developer 1", Followers = 100, CountryId = 1 },
            new Company { Id = 2, Name = "Developer 2", Followers = 200, CountryId = 2 },
            new Company { Id = 3, Name = "Developer 3", Followers = 300, CountryId = 3 },
            new Company { Id = 4, Name = "Developer 4", Followers = 400, CountryId = 4 },
            new Company { Id = 5, Name = "Developer 5", Followers = 500, CountryId = 5 },
            new Company { Id = 6, Name = "Developer 6", Followers = 600, CountryId = 6 },
            new Company { Id = 7, Name = "Developer 7", Followers = 700, CountryId = 7 },
            new Company { Id = 8, Name = "Developer 8", Followers = 800, CountryId = 8 },
            new Company { Id = 9, Name = "Developer 9", Followers = 900, CountryId = 9 },
            new Company { Id = 10, Name = "Developer 10", Followers = 1000, CountryId = 10 },
            new Company { Id = 11, Name = "Developer 11", Followers = 1100, CountryId = 11 },
            new Company { Id = 12, Name = "Developer 12", Followers = 1200, CountryId = 12 },
            new Company { Id = 13, Name = "Developer 13", Followers = 1300, CountryId = 13 },
            new Company { Id = 14, Name = "Developer 14", Followers = 1400, CountryId = 14 },
            new Company { Id = 15, Name = "Developer 15", Followers = 1500, CountryId = 15 });

            modelBuilder.Entity<Game>().HasData(
            new Game { Id = 1, Name = "Game 1", Description = "Description 1", Cost = 9.99M, CategoryId = 1, Rate = 4, CompanyId = 1 },
            new Game { Id = 2, Name = "Game 2", Description = "Description 2", Cost = 19.99M, CategoryId = 2, Rate = 3, CompanyId = 2 },
            new Game { Id = 3, Name = "Game 3", Description = "Description 3", Cost = 14.99M, CategoryId = 3, Rate = 5, CompanyId = 3 },
            new Game { Id = 4, Name = "Game 4", Description = "Description 4", Cost = 29.99M, CategoryId = 4, Rate = 4, CompanyId = 4 },
            new Game { Id = 5, Name = "Game 5", Description = "Description 5", Cost = 9.99M, CategoryId = 5, Rate = 3, CompanyId = 5 },
            new Game { Id = 6, Name = "Game 6", Description = "Description 6", Cost = 19.99M, CategoryId = 6, Rate = 4, CompanyId = 6 },
            new Game { Id = 7, Name = "Game 7", Description = "Description 7", Cost = 14.99M, CategoryId = 7, Rate = 5, CompanyId = 7 },
            new Game { Id = 8, Name = "Game 8", Description = "Description 8", Cost = 29.99M, CategoryId = 8, Rate = 3, CompanyId = 8 },
            new Game { Id = 9, Name = "Game 9", Description = "Description 9", Cost = 9.99M, CategoryId = 9, Rate = 4, CompanyId = 9 },
            new Game { Id = 10, Name = "Game 10", Description = "Description 10", Cost = 19.99M, CategoryId = 10, Rate = 5, CompanyId = 10 },
            new Game { Id = 11, Name = "Game 11", Description = "Description 11", Cost = 14.99M, CategoryId = 11, Rate = 3, CompanyId = 11 },
            new Game { Id = 12, Name = "Game 12", Description = "Description 12", Cost = 29.99M, CategoryId = 12, Rate = 4, CompanyId = 12 },
            new Game { Id = 13, Name = "Game 13", Description = "Description 13", Cost = 9.99M, CategoryId = 13, Rate = 5, CompanyId = 13 },
            new Game { Id = 14, Name = "Game 14", Description = "Description 14", Cost = 19.99M, CategoryId = 14, Rate = 3, CompanyId = 14 },
            new Game { Id = 15, Name = "Game 15", Description = "Description 15", Cost = 14.99M, CategoryId = 15, Rate = 4, CompanyId = 15 });

            modelBuilder.Entity<Groups>().HasData(
            new Groups { Id = 1, Name = "Group 1", Followers = 100, Rate = 4 },
            new Groups { Id = 2, Name = "Group 2", Followers = 200, Rate = 3 },
            new Groups { Id = 3, Name = "Group 3", Followers = 300, Rate = 5 },
            new Groups { Id = 4, Name = "Group 4", Followers = 400, Rate = 4 },
            new Groups { Id = 5, Name = "Group 5", Followers = 500, Rate = 3 },
            new Groups { Id = 6, Name = "Group 6", Followers = 600, Rate = 4 },
            new Groups { Id = 7, Name = "Group 7", Followers = 700, Rate = 5 },
            new Groups { Id = 8, Name = "Group 8", Followers = 800, Rate = 3 },
            new Groups { Id = 9, Name = "Group 9", Followers = 900, Rate = 4 },
            new Groups { Id = 10, Name = "Group 10", Followers = 1000, Rate = 5 },
            new Groups { Id = 11, Name = "Group 11", Followers = 1100, Rate = 3 },
            new Groups { Id = 12, Name = "Group 12", Followers = 1200, Rate = 4 },
            new Groups { Id = 13, Name = "Group 13", Followers = 1300, Rate = 5 },
            new Groups { Id = 14, Name = "Group 14", Followers = 1400, Rate = 3 },
            new Groups { Id = 15, Name = "Group 15", Followers = 1500, Rate = 4 });

            modelBuilder.Entity<Platform>().HasData(
            new Platform { Id = 1, Name = "Platform 1" },
            new Platform { Id = 2, Name = "Platform 2" },
            new Platform { Id = 3, Name = "Platform 3" },
            new Platform { Id = 4, Name = "Platform 4" },
            new Platform { Id = 5, Name = "Platform 5" },
            new Platform { Id = 6, Name = "Platform 6" },
            new Platform { Id = 7, Name = "Platform 7" },
            new Platform { Id = 8, Name = "Platform 8" },
            new Platform { Id = 9, Name = "Platform 9" },
            new Platform { Id = 10, Name = "Platform 10" },
            new Platform { Id = 11, Name = "Platform 11" },
            new Platform { Id = 12, Name = "Platform 12" },
            new Platform { Id = 13, Name = "Platform 13" },
            new Platform { Id = 14, Name = "Platform 14" },
            new Platform { Id = 15, Name = "Platform 15" });

            modelBuilder.Entity<Position>().HasData(
            new Position { Id = 1, Name = "Position 1" },
            new Position { Id = 2, Name = "Position 2" },
            new Position { Id = 3, Name = "Position 3" },
            new Position { Id = 4, Name = "Position 4" },
            new Position { Id = 5, Name = "Position 5" },
            new Position { Id = 6, Name = "Position 6" },
            new Position { Id = 7, Name = "Position 7" },
            new Position { Id = 8, Name = "Position 8" },
            new Position { Id = 9, Name = "Position 9" },
            new Position { Id = 10, Name = "Position 10" },
            new Position { Id = 11, Name = "Position 11" },
            new Position { Id = 12, Name = "Position 12" },
            new Position { Id = 13, Name = "Position 13" },
            new Position { Id = 14, Name = "Position 14" },
            new Position { Id = 15, Name = "Position 15" });

            modelBuilder.Entity<Review>().HasData(
            new Review { Id = 1, Comment = "Review 1", Rating = 4, GameId = 1, UserId = 1 },
            new Review { Id = 2, Comment = "Review 2", Rating = 5, GameId = 2, UserId = 2 },
            new Review { Id = 3, Comment = "Review 3", Rating = 3, GameId = 3, UserId = 3 },
            new Review { Id = 4, Comment = "Review 4", Rating = 4, GameId = 4, UserId = 4 },
            new Review { Id = 5, Comment = "Review 5", Rating = 5, GameId = 5, UserId = 5 },
            new Review { Id = 6, Comment = "Review 6", Rating = 4, GameId = 6, UserId = 6 },
            new Review { Id = 7, Comment = "Review 7", Rating = 3, GameId = 7, UserId = 7 },
            new Review { Id = 8, Comment = "Review 8", Rating = 5, GameId = 8, UserId = 8 },
            new Review { Id = 9, Comment = "Review 9", Rating = 4, GameId = 9, UserId = 9 },
            new Review { Id = 10, Comment = "Review 10", Rating = 3, GameId = 10, UserId = 10 },
            new Review { Id = 11, Comment = "Review 11", Rating = 4, GameId = 11, UserId = 11 },
            new Review { Id = 12, Comment = "Review 12", Rating = 5, GameId = 12, UserId = 12 },
            new Review { Id = 13, Comment = "Review 13", Rating = 4, GameId = 13, UserId = 13 },
            new Review { Id = 14, Comment = "Review 14", Rating = 3, GameId = 14, UserId = 14 },
            new Review { Id = 15, Comment = "Review 15", Rating = 5, GameId = 15, UserId = 15 });

            modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                NickName = "User1",
                Email = "user1@example.com",
                Phone = "1234567890",
                Password = "password1",
                Date = DateTime.Now.AddDays(-30),
                IsVerifiedAccount = true,
                PositionId = 1, // Assuming PositionId and CountryId are valid IDs
                CountryId = 1  // Assuming PositionId and CountryId are valid IDs
            },
            new User
            {
                Id = 2,
                NickName = "User2",
                Email = "user2@example.com",
                Phone = "9876543210",
                Password = "password2",
                Date = DateTime.Now.AddDays(-45),
                IsVerifiedAccount = false,
                PositionId = 2, // Assuming PositionId and CountryId are valid IDs
                CountryId = 2  // Assuming PositionId and CountryId are valid IDs
            },
            new User
            {
                Id = 3,
                NickName = "User3",
                Email = "user3@example.com",
                Phone = "5555555555",
                Password = "password3",
                Date = DateTime.Now.AddDays(-60),
                IsVerifiedAccount = true,
                PositionId = 3, // Assuming PositionId and CountryId are valid IDs
                CountryId = 3  // Assuming PositionId and CountryId are valid IDs
            },
            new User
            {
                Id = 4,
                NickName = "User4",
                Email = "user4@example.com",
                Phone = "4444444444",
                Password = "password4",
                Date = DateTime.Now.AddDays(-75),
                IsVerifiedAccount = false,
                PositionId = 4, // Assuming PositionId and CountryId are valid IDs
                CountryId = 4  // Assuming PositionId and CountryId are valid IDs
            },
            new User
            {
                Id = 5,
                NickName = "User5",
                Email = "user5@example.com",
                Phone = "5555555555",
                Password = "password5",
                Date = DateTime.Now.AddDays(-90),
                IsVerifiedAccount = true,
                PositionId = 5, // Assuming PositionId and CountryId are valid IDs
                CountryId = 5  // Assuming PositionId and CountryId are valid IDs
            },
            new User
            {
                Id = 6,
                NickName = "User6",
                Email = "user6@example.com",
                Phone = "6666666666",
                Password = "password6",
                Date = DateTime.Now.AddDays(-105),
                IsVerifiedAccount = true,
                PositionId = 6, // Assuming PositionId and CountryId are valid IDs
                CountryId = 6  // Assuming PositionId and CountryId are valid IDs
            },
            new User
            {
                Id = 7,
                NickName = "User7",
                Email = "user7@example.com",
                Phone = "7777777777",
                Password = "password7",
                Date = DateTime.Now.AddDays(-120),
                IsVerifiedAccount = false,
                PositionId = 7, // Assuming PositionId and CountryId are valid IDs
                CountryId = 7  // Assuming PositionId and CountryId are valid IDs
            },
            new User
            {
                Id = 8,
                NickName = "User8",
                Email = "user8@example.com",
                Phone = "8888888888",
                Password = "password8",
                Date = DateTime.Now.AddDays(-135),
                IsVerifiedAccount = true,
                PositionId = 8, // Assuming PositionId and CountryId are valid IDs
                CountryId = 8  // Assuming PositionId and CountryId are valid IDs
            },
            new User
            {
                Id = 9,
                NickName = "User9",
                Email = "user9@example.com",
                Phone = "9999999999",
                Password = "password9",
                Date = DateTime.Now.AddDays(-150),
                IsVerifiedAccount = false,
                PositionId = 9, // Assuming PositionId and CountryId are valid IDs
                CountryId = 9  // Assuming PositionId and CountryId are valid IDs
            },
            new User
            {
                Id = 10,
                NickName = "User10",
                Email = "user10@example.com",
                Phone = "1010101010",
                Password = "password10",
                Date = DateTime.Now.AddDays(-165),
                IsVerifiedAccount = true,
                PositionId = 10, // Assuming PositionId and CountryId are valid IDs
                CountryId = 10  // Assuming PositionId and CountryId are valid IDs
            },
            new User
            {
                Id = 11,
                NickName = "User11",
                Email = "user11@example.com",
                Phone = "1111111111",
                Password = "password11",
                Date = DateTime.Now.AddDays(-180),
                IsVerifiedAccount = false,
                PositionId = 11, // Assuming PositionId and CountryId are valid IDs
                CountryId = 11  // Assuming PositionId and CountryId are valid IDs
            },
            new User
            {
                Id = 12,
                NickName = "User12",
                Email = "user12@example.com",
                Phone = "1212121212",
                Password = "password12",
                Date = DateTime.Now.AddDays(-195),
                IsVerifiedAccount = true,
                PositionId = 12, // Assuming PositionId and CountryId are valid IDs
                CountryId = 12  // Assuming PositionId and CountryId are valid IDs
            },
            new User
            {
                Id = 13,
                NickName = "User13",
                Email = "user13@example.com",
                Phone = "1313131313",
                Password = "password13",
                Date = DateTime.Now.AddDays(-210),
                IsVerifiedAccount = true,
                PositionId = 13, // Assuming PositionId and CountryId are valid IDs
                CountryId = 13  // Assuming PositionId and CountryId are valid IDs
            },
            new User
            {
                Id = 14,
                NickName = "User14",
                Email = "user14@example.com",
                Phone = "1414141414",
                Password = "password14",
                Date = DateTime.Now.AddDays(-225),
                IsVerifiedAccount = false,
                PositionId = 14, // Assuming PositionId and CountryId are valid IDs
                CountryId = 14  // Assuming PositionId and CountryId are valid IDs
            },
            new User
            {
                Id = 15,
                NickName = "User15",
                Email = "user15@example.com",
                Phone = "1515151515",
                Password = "password15",
                Date = DateTime.Now.AddDays(-240),
                IsVerifiedAccount = true,
                PositionId = 15, // Assuming PositionId and CountryId are valid IDs
                CountryId = 15  // Assuming PositionId and CountryId are valid IDs
            });
        }
    }
}

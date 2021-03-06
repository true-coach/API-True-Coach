﻿using System;
using Xunit;
using TrueCoachAPI.Models;
using TrueCoachAPI.Controllers;
using TrueCoachAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace TrueCoachAPI_Tests
{
    public class UserUnitTest
    {
        [Fact]
        public void CanGetUserID()
        {
            User user = new User();
            user.ID = 1;
            Assert.Equal(1, user.ID);
        }
        [Fact]
        public void CanSetUserID()
        {
            User user = new User();
            user.ID = 1;
            user.ID = 2;
            Assert.Equal(2, user.ID);
        }

        [Fact]
        public void CanGetUserName()
        {
            User user = new User();
            user.UserName = "Name";
            Assert.Equal("Name", user.UserName);
        }
        [Fact]
        public void CanSetUserNameD()
        {
            User user = new User();
            user.UserName = "First";
            user.UserName = "Name";
            Assert.Equal("Name", user.UserName);
        }

        [Fact]
        public void CanCreateUsers()
        {
            //DbContextOptions<TrueCoachDbContext> options = new DbContextOptionsBuilder<TrueCoachDbContext>().UseInMemoryDatabase("").Options;
            //using (TrueCoachDbContext context = new TrueCoachDbContext(options))
            {
                //Arrange

                //Act

                //Assert
            }
        }
    }
}


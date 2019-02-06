using System;
using Xunit;
using TrueCoachAPI.Models;
using TrueCoachAPI.Controllers;
namespace TrueCoachAPI_Tests
{
    public class GoalUnitTest
    {
        [Fact]
        public void CanGetGoalID()
        {
            Goal goal = new Goal();
            goal.ID = 1;
            Assert.Equal(1, goal.ID);
        }
        [Fact]
        public void CanSetGoalID()
        {
            Goal goal = new Goal();
            goal.ID = 1;
            goal.ID = 2;
            Assert.Equal(2, goal.ID);
        }

        [Fact]
        public void CanGetGoalName()
        {
            Goal goal = new Goal();
            goal.Name = "Time";
            Assert.Equal("Time", goal.Name);
        }
        [Fact]
        public void CanSetGoalName()
        {
            Goal goal = new Goal();
            goal.Name = "Lose";
            goal.Name = "Win";
            Assert.Equal("Win", goal.Name);
        }
    }
}
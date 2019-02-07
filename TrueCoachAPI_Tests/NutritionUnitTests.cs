using System;
using Xunit;
using TrueCoachAPI.Models;
using TrueCoachAPI.Controllers;
namespace TrueCoachAPI_Tests
{
    public class NutritionUnitTest
    {
        [Fact]
        public void CanGetNutritionID()
        {
            Nutrition nutrition = new Nutrition();
            nutrition.ID = 1;
            Assert.Equal(1, nutrition.ID);
        }
        [Fact]
        public void CanSetNutritionID()
        {
            Nutrition nutrition = new Nutrition();
            nutrition.ID = 1;
            nutrition.ID = 2;
            Assert.Equal(2, nutrition.ID);
        }

        [Fact]
        public void CanGetNutritionGoalID()
        {
            Nutrition nutrition = new Nutrition();
            nutrition.GoalID = 1;
            Assert.Equal(1, nutrition.GoalID);
        }
        [Fact]
        public void CanSetNutritionGoalID()
        {
            Nutrition nutrition = new Nutrition();
            nutrition.GoalID = 1;
            nutrition.GoalID = 2;
            Assert.Equal(2, nutrition.GoalID);
        }

    }
}

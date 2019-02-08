using System;
using Xunit;
using TrueCoachAPI.Models;
using TrueCoachAPI.Controllers;
namespace TrueCoachAPI_Tests
{
    public class MealUnitTest
    {
        [Fact]
        public void CanGetMealID()
        {
            Meal meal = new Meal();
            meal.ID = 1;
            Assert.Equal(1, meal.ID);
        }
        [Fact]
        public void CanSetMealID()
        {
            Meal meal = new Meal();
            meal.ID = 1;
            meal.ID = 2;
            Assert.Equal(2, meal.ID);
        }

        [Fact]
        public void CanGetNutritionID()
        {
            Meal meal = new Meal();
            meal.NutritionPlanId = 1;
            Assert.Equal(1, meal.NutritionPlanId);
        }
        [Fact]
        public void CanSetNutritionID()
        {
            Meal meal = new Meal();
            meal.NutritionPlanId = 1;
            meal.NutritionPlanId = 2;
            Assert.Equal(2, meal.NutritionPlanId);
        }

        [Fact]
        public void CanGetMealName()
        {
            Meal meal = new Meal();
            meal.Name = "Pizza";
            Assert.Equal("Pizza", meal.Name);
        }
        [Fact]
        public void CanSetMealName()
        {
            Meal meal = new Meal();
            meal.Name = "NotPizza";
            meal.Name = "Pizza";
            Assert.Equal("Pizza", meal.Name);
        }

        [Fact]
        public void CanGetMealDescription()
        {
            Meal meal = new Meal();
            meal.Description = "Yummy";
            Assert.Equal("Yummy", meal.Description);
        }
        [Fact]
        public void CanSetMealDescription()
        {
            Meal meal = new Meal();
            meal.Description = "NotAsYummy";
            meal.Description = "Yummy";
            Assert.Equal("Yummy", meal.Description);
        }
    }
}

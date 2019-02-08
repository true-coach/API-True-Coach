using TrueCoachAPI.Models;
using Xunit;
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
            nutrition.NutritionGoals = (FoodGoal)1;
            Assert.Equal(1, (int)nutrition.NutritionGoals);
        }
        [Fact]
        public void CanSetNutritionGoalID()
        {
            Nutrition nutrition = new Nutrition();
            nutrition.NutritionGoals = (FoodGoal)1;
            nutrition.NutritionGoals = (FoodGoal)2;
            Assert.Equal(2, (int)nutrition.NutritionGoals);
        }

    }
}

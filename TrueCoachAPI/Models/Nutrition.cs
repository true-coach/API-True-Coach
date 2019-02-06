namespace TrueCoachAPI.Models
{
    public class Nutrition
    {
        public int ID { get; set; }       
        public FoodGoal NutritionGoals { get; set; }
        public Meal Meals { get; set; }
    }

    public enum FoodGoal
    {
        LoseFat = 1,
        BuildMuscle,
        Maintain
    }
}
﻿namespace TrueCoachAPI.Models
{
    public class Meal
    {
        public int ID { get; set; }
        public int NutritionPlanId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

       public Nutrition Nutrition { get; set; }
    }
}
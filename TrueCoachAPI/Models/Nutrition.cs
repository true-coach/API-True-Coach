namespace TrueCoachAPI.Models
{
    public class Nutrition
    {
        public int ID { get; set; }
        public int GoalID { get; set; }      

        public Goal Goal { get; set; }
    }
}
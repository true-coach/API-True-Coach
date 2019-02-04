namespace TrueCoachAPI.Models
{
    public class Workout
    {
        public int ID { get; set; }
        public int WorkoutTypeID { get; set; }
        public int GoalID { get; set; }

        public WorkoutType WorkoutType { get; set; }
        public Goal Goal { get; set; }
    }
}

namespace TrueCoachAPI.Models
{
    public class Exercise
    {
        public int ID { get; set; }
        public int WorkoutID { get; set; }
        public string Name { get; set; }
        public string Description  { get; set; }
     
        public Workout Workout { get; set; }
    }
}

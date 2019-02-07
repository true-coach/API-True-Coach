namespace TrueCoachAPI.Models
{
    public class WorkoutType
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Exercise Exercise { get; set; }
    }
}

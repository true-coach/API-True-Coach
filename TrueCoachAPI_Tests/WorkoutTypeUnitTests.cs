using System;
using Xunit;
using TrueCoachAPI.Models;
using TrueCoachAPI.Controllers;
namespace TrueCoachAPI_Tests
{
    public class WorkoutTypeUnitTest
    {
        [Fact]
        public void CanGetWorkoutTypeID()
        {
            WorkoutType workoutType = new WorkoutType();
            workoutType.ID = 1;
            Assert.Equal(1, workoutType.ID);
        }
        [Fact]
        public void CanSetWorkoutID()
        {
            WorkoutType workoutType = new WorkoutType();
            workoutType.ID = 1;
            workoutType.ID = 2;
            Assert.Equal(2, workoutType.ID);
        }

        [Fact]
        public void CanGetWorkoutName()
        {
            WorkoutType workoutType = new WorkoutType();
            workoutType.Name = "Name";
            Assert.Equal("Name", workoutType.Name);
        }
        [Fact]
        public void CanSetWorkoutName()
        {
            WorkoutType workoutType = new WorkoutType();
            workoutType.Name = "First";
            workoutType.Name = "Name";
            Assert.Equal("Name", workoutType.Name);
        }
    }
}

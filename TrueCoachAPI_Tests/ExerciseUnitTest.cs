using System;
using Xunit;
using TrueCoachAPI.Models;
using TrueCoachAPI.Controllers;

namespace TrueCoachAPI_Tests
{
    public class ExerciseUnitTest
    {
        [Fact]
        public void CanGetExerciseID()
        {
            Exercise exercise = new Exercise();
            exercise.ID = 1;
            Assert.Equal(1, exercise.ID);
        }
        [Fact]
        public void CanSetExerciseID()
        {
            Exercise exercise = new Exercise();
            exercise.ID = 1;
            exercise.ID = 2;
            Assert.Equal(2, exercise.ID);
        }
            
        [Fact]
        public void CanGetExerciseName()
        {
            Exercise exercise = new Exercise();
            exercise.Name = "Up";
            Assert.Equal("Up", exercise.Name);
        }
        [Fact]
        public void CanSetExerciseName()
        {
            Exercise exercise = new Exercise();
            exercise.Name = "Pull";
            exercise.Name = "Push";
            Assert.Equal("Push", exercise.Name);
        }
            
        [Fact]
        public void CanGetExerciseWorkoutID()
        {
            Exercise exercise = new Exercise();
            exercise.WorkoutID = 1;
            Assert.Equal(1, exercise.WorkoutID);
        }
        [Fact]
        public void CanSetExerciseWorkoutID()
        {
            Exercise exercise = new Exercise();
            exercise.WorkoutID = 1;
            exercise.WorkoutID = 2;
            Assert.Equal(2, exercise.WorkoutID);
        }

        [Fact]
        public void CanGetExerciseDescription()
        {
            Exercise exercise = new Exercise();
            exercise.Description = "yes";
            Assert.Equal("yes", exercise.Description);
        }
        [Fact]
        public void CanSetExerciseDescription()
        {
            Exercise exercise = new Exercise();
            exercise.Description = "no";
            exercise.Description = "yes";
            Assert.Equal("yes", exercise.Description);
        }

    }
}

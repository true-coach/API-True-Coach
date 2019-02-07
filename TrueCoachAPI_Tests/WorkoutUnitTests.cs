using System;
using Xunit;
using TrueCoachAPI.Models;
using TrueCoachAPI.Controllers;
namespace TrueCoachAPI_Tests
{
    public class WorkoutUnitTest
    {
        [Fact]
        public void CanGetWorkoutID()
        {
            Workout workout = new Workout();
            workout.ID = 1;
            Assert.Equal(1, workout.ID);
        }
        [Fact]
        public void CanSetWorkoutID()
        {
            Workout workout = new Workout();
            workout.ID = 1;
            workout.ID = 2;
            Assert.Equal(2, workout.ID);
        }

        [Fact]
        public void CanGetWorkoutTypeID()
        {
            Workout workout = new Workout();
            workout.WorkoutTypeID = 1;
            Assert.Equal(1, workout.WorkoutTypeID);
        }
        [Fact]
        public void CanSetWorkoutTypeID()
        {
            Workout workout = new Workout();
            workout.WorkoutTypeID = 1;
            workout.WorkoutTypeID = 2;
            Assert.Equal(2, workout.WorkoutTypeID);
        }

        [Fact]
        public void CanGetWorkoutGoals()
        {
            Goals goals = new Goals();
            goals = Goals.FatLoss;
            Assert.Equal(Goals.FatLoss, goals);
        }
        [Fact]
        public void CanSetWorkoutGoalsD()
        {
            Goals goals = new Goals();
            goals = Goals.FatLoss;
            goals = Goals.Mobility;
            Assert.Equal(Goals.Mobility, goals);
        }

        [Fact]
        public void CanGetWorkoutType()
        {
            WorkoutType workout = new WorkoutType();
            workout.ID = 1;
            Assert.Equal(1, workout.ID);
        }
        [Fact]
        public void CanSetWorkoutType()
        {
            WorkoutType workout = new WorkoutType();
            workout.ID = 1;
            workout.ID = 2;
            Assert.Equal(2, workout.ID);
        }
    }
}

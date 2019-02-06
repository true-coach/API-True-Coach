using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrueCoachAPI.Data;
using TrueCoachAPI.Models;

namespace TrueCoachAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private readonly TrueCoachDbContext _context;

        public ExerciseController(TrueCoachDbContext context)
        {
            _context = context;
        }



        ////GET:api/Exercise/2
        [HttpGet("{WorkoutID}")]
        public List<Exercise> GetExercise(int WorkoutID)
        {

            // var results = from name in Exercise select name;

            //var Exercises = _context.Exercise.Where(c => c.WorkoutID);
            //var workouts = _context.WorkoutType.Where(c => c.ID == WorkoutID).Include(c => c.Name == c.Exercise.Description);

            return _context.Exercise.ToList();

            //return workouts;
        }



        private bool WorkoutExists(int id)
        {
            return _context.Workout.Any(e => e.ID == id);
        }
    }
}




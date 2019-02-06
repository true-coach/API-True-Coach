using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrueCoachAPI.Data;
using TrueCoachAPI.Models;

namespace TrueCoachAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkoutsController : ControllerBase
    {
        private readonly TrueCoachDbContext _context;

        public WorkoutsController(TrueCoachDbContext context)
        {
            _context = context;
        }

        // GET: api/Workouts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Workout>>> GetWorkout()
        {
            return await _context.Workout.ToListAsync();
        }

        // GET: api/Workouts/5
        [HttpGet("{GoalID}")]
        public async Task<ActionResult<List<Workout>>> GetWorkout(int GoalID)
        {
            var workout = await _context.Workout.Where(c => c.WorkoutGoals == (Goals)GoalID).Include(c => c.WorkoutType).ToListAsync();

            if (workout == null)
            {
                return NotFound();
            }

            return workout;
        }
        // GET:api/Workouts/2/2
        //[httpget("{workoutid}")]
        //public list<workout> getexercise(int workoutid)
        //{
        //    var exercise = _context.workout.where(c => c.workouttype.id == workoutid).include(c => c.workouttype.exercises).tolist();



        //    return exercise;
        //}



        private bool WorkoutExists(int id)
        {
            return _context.Workout.Any(e => e.ID == id);
        }
    }
}

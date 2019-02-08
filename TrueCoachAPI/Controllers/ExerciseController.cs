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
        public async Task<ActionResult<List<Exercise>>> GetExercise(int WorkoutID)
        {
            return await _context.Exercise.Where(e => e.WorkoutID == WorkoutID).ToListAsync();
        }
        private bool WorkoutExists(int id)
        {
            return _context.Workout.Any(e => e.ID == id);
        }
    }
}




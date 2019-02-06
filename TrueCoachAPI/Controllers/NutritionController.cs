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
    public class NutritionController : ControllerBase
    {
        private readonly TrueCoachDbContext _context;

        public NutritionController(TrueCoachDbContext context)
        {
            _context = context;
        }

        //GET: api/Nutritions/5
        [HttpGet("{GoalID}")]
        public async Task<ActionResult<List<Nutrition>>> GetNutrition(int GoalID)
        {
            //var MealPlan = await _context.MealPlan.Where(m => m.Nutrition.NutritionGoals == (FoodGoal)GoalID && m.ID == m.Nutrition.ID).ToListAsync();
          var MealPlan = await _context.Nutrition.Where(c => c.NutritionGoals == (FoodGoal)GoalID).Include(m => m.Meals).ToListAsync();
            //_context.Workout.ToListAsync();
            return MealPlan;
        }




        private bool NutritionExists(int id)
        {
            return _context.Nutrition.Any(e => e.ID == id);
        }
    }

}
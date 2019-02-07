using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        //GET: api/Nutrition/5
        [HttpGet("{GoalID}")]
        public async Task<ActionResult<List<Meal>>> GetNutrition(int GoalID)
        {
            var nutritionPlan = await _context.Nutrition.Where(n => n.NutritionGoals == (FoodGoal)GoalID).FirstOrDefaultAsync();
            var meals = await _context.Meal.Where(m => m.NutritionPlanId == nutritionPlan.ID).ToListAsync();
            return Ok(meals);
        }

        private bool NutritionExists(int id)
        {
            return _context.Nutrition.Any(e => e.ID == id);
        }
    }
}
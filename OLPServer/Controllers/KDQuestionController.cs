using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OLPServer.Data;
using OLPServer.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLPServer.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class KDQuestionController : ControllerBase
   {
      private readonly ApplicationDbContext _context;

      public KDQuestionController(ApplicationDbContext context)
      {
         _context = context;
      }

      // GET: api/KDQuestion
      [HttpGet]
      public async Task<ActionResult<IEnumerable<KDQuestion>>> GetQuestionsReady()
      {
         var fields = await _context.KDQuestions.Select(q => q.Field).Distinct().ToListAsync();
         var questions = await _context.KDQuestions.Where(q => q.IsAnswered == false).ToListAsync();
         var result = fields.Select(field => questions.FirstOrDefault(q => q.Field == field)).Where(q => q != null).ToList();
         return Ok(result);
      }

      // POST: api/KDQuestion/answered
      [HttpPost("answered")]
      /*
      Received a list of answered questions by id, mark them as True
      */
      public async Task<ActionResult> AnsweredQuestions(List<int> ids)
      {
         foreach (var id in ids)
         {
            var question = await _context.KDQuestions.FindAsync(id);
            if (question == null)
            {
               return NotFound();
            }
            question.IsAnswered = true;
            _context.Entry(question).State = EntityState.Modified;
         }
         await _context.SaveChangesAsync();
         return NoContent();
      }
   }
}
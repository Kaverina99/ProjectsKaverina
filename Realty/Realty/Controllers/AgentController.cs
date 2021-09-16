using RealtyProg.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace RealtyProg.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgentController : ControllerBase
    {
        private readonly RealtyContext _context;

        public AgentController(RealtyContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Agent> GetAll() //получение всех записей 
        {
            return _context.Agent;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAgent([FromRoute] int id) //получение записи 
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var agent = await _context.Agent.SingleOrDefaultAsync(m => m.AgentId == id);

            if (agent == null)
            {
                return NotFound();
            }

            return Ok(agent);
        }

        [Authorize(Roles = "admin")]
        [HttpPost] //Метод создания записи
        public async Task<IActionResult> Create([FromBody] Agent agent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Agent.Add(agent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAgent", new { id = agent.AgentId }, agent);
        }

        [Authorize(Roles = "admin")]
        [HttpPut("{id}")] //метод обновления записи
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Agent agent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var item = _context.Agent.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            item.Name = agent.Name;
            item.Tell = agent.Tell;
            item.Email = agent.Email;
            _context.Agent.Update(item);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [Authorize(Roles = "admin")]
        [HttpDelete("{id}")] //метод удаления записи 
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var item = _context.Agent.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            _context.Agent.Remove(item);
            await _context.SaveChangesAsync();
            return NoContent();
        }


    }
}

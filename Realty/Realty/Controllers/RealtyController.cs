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
    public class RealtyController : ControllerBase
    {
        private readonly RealtyContext _context;

        public RealtyController(RealtyContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Realty> GetAll() //получение всех записей 
        {
            return _context.Realty.Include(a => a.Property);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRealty([FromRoute] int id) //получение записи 
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var realty = await _context.Realty.SingleOrDefaultAsync(m => m.RealtyId == id);

            if (realty == null)
            {
                return NotFound();
            }

            return Ok(realty);
        }

        [Authorize(Roles = "user")]
        [HttpPost] //Метод создания записи
        public async Task<IActionResult> Create([FromBody] Realty realty)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Realty.Add(realty);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRealty", new { id = realty.RealtyId }, realty);
        }

        [Authorize(Roles = "user")]
        [HttpPut("{id}")] //метод обновления записи
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Realty realty)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var item = _context.Realty.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            item.Adress = realty.Adress;
            item.Area = realty.Area;
            item.Cost = realty.Cost;
            _context.Realty.Update(item);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [Authorize(Roles = "user")]
        [HttpDelete("{id}")] //метод удаления записи 
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var item = _context.Realty.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            _context.Realty.Remove(item);
            await _context.SaveChangesAsync();
            return NoContent();
        }


    }
}

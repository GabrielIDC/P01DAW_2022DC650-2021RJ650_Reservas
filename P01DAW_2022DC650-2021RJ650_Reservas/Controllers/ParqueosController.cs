using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using P01DAW_2022DC650_2021RJ650_Reservas.Data;
using P01DAW_2022DC650_2021RJ650_Reservas.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P01DAW_2022DC650_2021RJ650_Reservas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParqueosController : ControllerBase
    {
        private readonly ParqueosDbContext _context;

        public ParqueosController(ParqueosDbContext context)
        {
            _context = context;
        }

        // GET: api/Parqueos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Parqueo>>> GetParqueos()
        {
            return await _context.Parqueos.ToListAsync();
        }

        // GET: api/Parqueos
        [HttpGet("{id}")]
        public async Task<ActionResult<Parqueo>> GetParqueo(int id)
        {
            var parqueo = await _context.Parqueos.FindAsync(id);

            if (parqueo == null)
            {
                return NotFound();
            }

            return parqueo;
        }

        // POST: api/Parqueos
        [HttpPost]
        public async Task<ActionResult<Parqueo>> PostParqueo(Parqueo parqueo)
        {
            _context.Parqueos.Add(parqueo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetParqueo", new { id = parqueo.IdEspacio }, parqueo);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutParqueo(int id, Parqueo parqueo)
        {
            if (id != parqueo.IdEspacio)
            {
                return BadRequest();
            }

            _context.Entry(parqueo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Parqueos.Any(e => e.IdEspacio == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteParqueo(int id)
        {
            var parqueo = await _context.Parqueos.FindAsync(id);
            if (parqueo == null)
            {
                return NotFound();
            }

            _context.Parqueos.Remove(parqueo);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

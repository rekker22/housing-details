using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using housing.Models;

namespace housing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class dataController : ControllerBase
    {
        private readonly dataContext _context;

        public dataController(dataContext context)
        {
            _context = context;
        }

        // GET: api/data
        [HttpGet]
        public async Task<ActionResult<IEnumerable<data>>> GetDatas()
        {
            return await _context.Datas.ToListAsync();
        }

        // GET: api/data/5
        [HttpGet("{id}")]
        public async Task<ActionResult<data>> Getdata(string id)
        {
            var data = await _context.Datas.FindAsync(id);

            if (data == null)
            {
                return NotFound();
            }

            return data;
        }

        // PUT: api/data/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> Putdata(string id, data data)
        {
            if (id != data.Location)
            {
                return BadRequest();
            }

            _context.Entry(data).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!dataExists(id))
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

        // POST: api/data
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<data>> Postdata(data data)
        {
            _context.Datas.Add(data);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (dataExists(data.Location))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("Getdata", new { id = data.Location }, data);
        }

        // DELETE: api/data/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<data>> Deletedata(string id)
        {
            var data = await _context.Datas.FindAsync(id);
            if (data == null)
            {
                return NotFound();
            }

            _context.Datas.Remove(data);
            await _context.SaveChangesAsync();

            return data;
        }

        private bool dataExists(string id)
        {
            return _context.Datas.Any(e => e.Location == id);
        }
    }
}

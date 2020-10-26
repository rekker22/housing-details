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
        private readonly dataContext db;

        public dataController(dataContext context)
        {
            db = context;
        }

        // GET: api/data
        [HttpGet]
        public Object GetDatas()
        {
            var data = (from d in db.Datas
                        join a in db.Accds
                            on d.Location equals a.Location
                        join p in db.Ptvs
                            on a.Location equals p.Location
                        select new
                        {
                            Location = d.Location,
                            d.Dfd,
                            Accomodation_Name = a.Name,
                            Places_to_visit = p.Name,
                            Budget = d.Budget
                        }).ToList();
            return data;
            //return await db.Datas.ToListAsync();
        }

        // GET: api/data/5
        [HttpGet("{id}")]
        public async Task<ActionResult<data>> Getdata(string id)
        {
            var data = await db.Datas.FindAsync(id);

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

            db.Entry(data).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
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
            db.Datas.Add(data);
            try
            {
                await db.SaveChangesAsync();
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
            var data = await db.Datas.FindAsync(id);
            if (data == null)
            {
                return NotFound();
            }

            db.Datas.Remove(data);
            await db.SaveChangesAsync();

            return data;
        }

        private bool dataExists(string id)
        {
            return db.Datas.Any(e => e.Location == id);
        }
    }
}

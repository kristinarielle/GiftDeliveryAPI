using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GiftDeliveryAPI.Models;
using Newtonsoft.Json;

namespace GiftDeliveryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiftController : ControllerBase
    {
        private readonly GiftDeliveryDBContext _context;

        public GiftController(GiftDeliveryDBContext context)
        {
            _context = context;
        }

        // GET: api/Gift
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Gift>>> GetGifts()
        {
            var response = new Response<Gift>();
            if (_context.Gifts == null)
            {
                return NotFound("Cannot find this gift");
               
            }
                return await _context.Gifts.ToListAsync();
        }

        //GET: api/Gift/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Gift>> GetGift(int id)
        {
          
            if (_context.Gifts == null)
            {
                return NotFound("Cannot find this gift");
             

            }
            var gift = await _context.Gifts.FindAsync(id);

            if (gift == null)
            {
                return NotFound("Cannot find this gift");
            }

            return gift;
        }

        // PUT: api/Gift/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGift(int id, Gift gift)
        {
            if (id != gift.GiftId)
            {
                return BadRequest("Invalid id");
            }

            _context.Entry(gift).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GiftExists(id))
                {
                    return NotFound("Cannot find this gift");
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Gift
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Gift>> PostGift(Gift gift)
        {
          if (_context.Gifts == null)
          {
                // return Problem("Entity set 'GiftDeliveryDBContext.Gifts'  is null.");
                return BadRequest("Missing some information");
          }
            _context.Gifts.Add(gift);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGift", new { id = gift.GiftId }, gift);
        }

        // DELETE: api/Gift/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGift(int id)
        {
            if (_context.Gifts == null)
            {
                return NotFound("Cannot find this gift");
            }
            var gift = await _context.Gifts.FindAsync(id);
            if (gift == null)
            {
                return NotFound("Cannot find this gift");
            }

            _context.Gifts.Remove(gift);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GiftExists(int id)
        {
            return (_context.Gifts?.Any(e => e.GiftId == id)).GetValueOrDefault();
        }

        
    }
        
}

        
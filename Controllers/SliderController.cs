using FiorelloApi.Data;
using FiorelloApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace FiorelloApi.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class SliderController : ControllerBase
    {
        private readonly AppDbContext _context;
        public SliderController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSlidersAsync()
        {
            return Ok(await _context.Sliders.ToListAsync());
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] int? id)
        {
            if (id is null) return BadRequest();

            var data = await _context.Sliders.FindAsync(id);

            if (id is null) return BadRequest();

            _context.Remove(data);

            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Slider Sliders)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _context.Sliders.AddAsync(Sliders);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Create", Sliders);
        }

        [HttpPost]
        public async Task<IActionResult> Edit([FromRoute] int id, [FromBody] Slider Sliders)
        {

            if (!ModelState.IsValid) return BadRequest(ModelState);

            var data = await _context.Sliders.FindAsync(id);

            if (data is null) return BadRequest();

            data.Name = Sliders.Name;

            await _context.SaveChangesAsync();

            return Ok();
        }


    }
}
//sehvimi tapa bilmirem
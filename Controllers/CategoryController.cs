using AutoMapper;
using FiorelloApi.Data;
using FiorelloApi.DTOs.Categories;
using FiorelloApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FiorelloApi.Controllers
{
   
    public class CategoryController : BaseController
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public CategoryController(AppDbContext context,
                                  IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IActionResult> GetAll()
        {
            var response = await _context.Categories.ToListAsync();

            var mappedDatas =  _mapper.Map<List<CategoryDto>>(response);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CategoryCreateDto request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            await _context.Categories.AddAsync(new Category { Name = request.Name, Title = request.Title });
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Create),request);
        }
    }
}

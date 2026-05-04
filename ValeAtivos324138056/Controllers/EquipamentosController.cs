using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ValeAtivos324138056.Data;
using ValeAtivos324138056.Models;


namespace ValeAtivos324138056.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipamentosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EquipamentosController(AppDbContext context)
        {
            _context = context;
        }

    
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Equipamentos>>> GetEquipamentos()
        {
            return await _context.Equipamentos.ToListAsync();
        }

        
        [HttpPost]
        public async Task<ActionResult<Equipamentos>> PostEquipamento(Equipamentos equipamento)
        {
            _context.Equipamentos.Add(equipamento);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetEquipamentos),
                new { id = equipamento.Id },
                equipamento
            );
        }
    }
}
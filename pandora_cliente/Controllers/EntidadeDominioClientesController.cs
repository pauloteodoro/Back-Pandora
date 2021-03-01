using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pandora_cliente.Model;

namespace pandora_cliente.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntidadeDominioClientesController : ControllerBase
    {
        private readonly APandoraDbContext _context;

        public EntidadeDominioClientesController(APandoraDbContext context)
        {
            _context = context;
        }

        // GET: api/EntidadeDominioClientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EntidadeDominioCliente>>> GetEntidadeDominioCliente()
        {
            return await _context.EntidadeDominioCliente.ToListAsync();
        }

        // GET: api/EntidadeDominioClientes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EntidadeDominioCliente>> GetEntidadeDominioCliente(int id)
        {
            var entidadeDominioCliente = await _context.EntidadeDominioCliente.FindAsync(id);

            if (entidadeDominioCliente == null)
            {
                return NotFound();
            }

            return entidadeDominioCliente;
        }

        // PUT: api/EntidadeDominioClientes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEntidadeDominioCliente(int id, EntidadeDominioCliente entidadeDominioCliente)
        {
            if (id != entidadeDominioCliente.ID)
            {
                return BadRequest();
            }

            _context.Entry(entidadeDominioCliente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EntidadeDominioClienteExists(id))
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

        // POST: api/EntidadeDominioClientes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EntidadeDominioCliente>> PostEntidadeDominioCliente(EntidadeDominioCliente entidadeDominioCliente)
        {
            _context.EntidadeDominioCliente.Add(entidadeDominioCliente);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEntidadeDominioCliente", new { id = entidadeDominioCliente.ID }, entidadeDominioCliente);
        }

        // DELETE: api/EntidadeDominioClientes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EntidadeDominioCliente>> DeleteEntidadeDominioCliente(int id)
        {
            var entidadeDominioCliente = await _context.EntidadeDominioCliente.FindAsync(id);
            if (entidadeDominioCliente == null)
            {
                return NotFound();
            }

            _context.EntidadeDominioCliente.Remove(entidadeDominioCliente);
            await _context.SaveChangesAsync();

            return entidadeDominioCliente;
        }

        private bool EntidadeDominioClienteExists(int id)
        {
            return _context.EntidadeDominioCliente.Any(e => e.ID == id);
        }
    }
}

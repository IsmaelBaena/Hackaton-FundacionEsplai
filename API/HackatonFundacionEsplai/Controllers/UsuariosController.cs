using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HackatonFundacionEsplai.Context;
using HackatonFundacionEsplai.Entities;
using HackatonFundacionEsplai.DataTransferObjects;

namespace HackatonFundacionEsplai.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public UsuariosController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/Usuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
        {
          if (_context.Usuarios == null)
          {
              return NotFound();
          }
            return await _context.Usuarios.ToListAsync();
        }

        // GET: api/Usuarios/CheckCredentials
        [HttpGet("CheckCredentials/email_{email},psswrd_{psswrd}")]
        public async Task<ActionResult<bool>> CheckCredentials(string email, string psswrd)
        {
            if (_context.Usuarios == null)
            {
                return NotFound();
            }

            if (UsuarioExists(email))
            {
                var user = _context.Usuarios.Find(email);

                if (user.Psswrd == psswrd)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        // GET: api/Usuarios/CheckCredentials
        [HttpGet("EmailExist/{id}")]
        public async Task<ActionResult<bool>> CheckEmailRegistered(string id)
        {
            if (_context.Usuarios == null)
            {
                return NotFound();
            }

            return UsuarioExists(id);
        }

        // GET: api/Usuarios/5
        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<Usuario>> GetUsuario(string id)
        {
          if (_context.Usuarios == null)
          {
              return NotFound();
          }
            var usuario = await _context.Usuarios.FindAsync(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return usuario;
        }

        // PUT: api/Usuarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuario(string id, Usuario usuario)
        {
            if (id != usuario.Email)
            {
                return BadRequest();
            }

            _context.Entry(usuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioExists(id))
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

        // POST: api/Usuarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("Post")]
        public async Task<ActionResult<Usuario>> PostUsuario(Usuario usuario)
        {
          if (_context.Usuarios == null)
          {
              return Problem("Entity set 'ApplicationDBContext.Usuarios'  is null.");
          }
            _context.Usuarios.Add(usuario);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UsuarioExists(usuario.Email))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUsuario", new { id = usuario.Email }, usuario);
        }

        // DELETE: api/Usuarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(string id)
        {
            if (_context.Usuarios == null)
            {
                return NotFound();
            }
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }

            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UsuarioExists(string id)
        {
            return (_context.Usuarios?.Any(e => e.Email == id)).GetValueOrDefault();
        }
    }
}

using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperViagemAPI.Data;
using SuperViagemAPI.Model;

namespace SuperViagemAPI.Controllers
{
[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase{

    private readonly DataContext _dataContext;

    public UsuarioController(DataContext dataContext){
        _dataContext = dataContext;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuario(){
        return await _dataContext.Usuarios.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Usuario>> GetUsuarioById(int id)
    {
        var usuario = await _dataContext.Usuarios.FindAsync(id);
        if(usuario == null)
        {
            return NotFound();
        }
            return Ok(usuario);
            }




            
        }       
    }

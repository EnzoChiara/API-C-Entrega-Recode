using Entrega.Data;
using Entrega.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Usuario.Controller {

[ApiController]
[Route("api/[controller]")]
    public class UsuarioController : ControllerBase{

        private readonly DataContext _dataContext;


        public UsuarioController(DataContext dataContext){
            _dataContext = dataContext;
        }


    [HttpGet]
    public async Task<ActionResult<IEnumerable<Entregas>>> GetEntregas(){
        return await _dataContext.Entrega.ToListAsync();
    }

    
    }

}
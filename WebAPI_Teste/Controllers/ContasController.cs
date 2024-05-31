using Microsoft.AspNetCore.Mvc;
using Models;
using WebAPI_Teste.Models;
using WebAPI_Teste.Service.ContaService;

namespace WebAPI_Teste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

  
    public class ContasController : ControllerBase
    {
        private readonly IContaInterface _contaInterface;
        public ContasController(IContaInterface contaInterface)
        {
            _contaInterface = contaInterface;
        }
    [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Conta>>>> GetConta()
        {

        
        return Ok(await _contaInterface.GetContas());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Conta>>> GetContaByID(int id)
        {
            ServiceResponse<Conta> serviceResponse = await _contaInterface.GetContaByID(id);

            return Ok(serviceResponse);
        } 
            


        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Conta>>>> CreateContas(Conta novoConta)
        {
            return Ok(await _contaInterface.CreateContas(novoConta));
        }
    }
}

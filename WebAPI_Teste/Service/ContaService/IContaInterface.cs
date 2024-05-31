using Models;
using WebAPI_Teste.Models;

namespace WebAPI_Teste.Service.ContaService
{
    public interface IContaInterface
    {
        Task<ServiceResponse<List<Conta>>> GetContas();
        Task<ServiceResponse<List<Conta>>> CreateContas(Conta newConta);
        Task<ServiceResponse<Conta>> GetContaByID(int id);
        Task<ServiceResponse<List<Conta>>> UpdateConta(Conta editadoConta);
        Task<ServiceResponse<List<Conta>>> DeleteConta(int id);
            }
}

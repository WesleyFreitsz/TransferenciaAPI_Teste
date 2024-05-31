using Models;
using WebAPI_Teste.DataContext;
using WebAPI_Teste.Models;

namespace WebAPI_Teste.Service.ContaService
{
    public class ContaService : IContaInterface
    {

        private readonly ApplicationDbContext _context;
            public ContaService(ApplicationDbContext context) {
        
            _context=context;
        }
        public async Task<ServiceResponse<List<Conta>>> CreateContas(Conta novoConta)
        {
            ServiceResponse<List<Conta>> serviceResponse = new ServiceResponse<List<Conta>>();

            try
            {

                if (novoConta == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Informar dados!";
                    serviceResponse.Sucesso = false;
                    return serviceResponse;
                }
                _context.Add(novoConta);
                await _context.SaveChangesAsync();

                serviceResponse.Dados = _context.Contas.ToList();


            }catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;
        }

        public Task<ServiceResponse<List<Conta>>> DeleteConta(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<Conta>> GetContaByID(int id)
        {
            ServiceResponse<Conta> serviceResponse = new ServiceResponse<Conta>();

            try
            {
                Conta conta = _context.Contas.FirstOrDefault(x => x.conta == id);
               

                if (conta == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Conta não encontrada";
                    serviceResponse.Sucesso = false;
                };

                serviceResponse.Dados = conta;
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Conta>>> GetContas()
        {
            ServiceResponse<List<Conta>> serviceResponse = new ServiceResponse<List<Conta>>();

            try
            {
                serviceResponse.Dados = _context.Contas.ToList();
                if(serviceResponse.Dados.Count == 0)
                {
                    serviceResponse.Mensagem = "Nenhum dado encontrado!";
                };

            }catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;
        }

        public Task<ServiceResponse<List<Conta>>> UpdateConta(Conta editadoConta)
        {
            throw new NotImplementedException();
        }
    }
}

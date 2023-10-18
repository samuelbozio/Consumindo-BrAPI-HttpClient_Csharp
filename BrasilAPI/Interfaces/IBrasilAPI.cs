using BrasilAPI.DTOs;
using BrasilAPI.Models;

namespace BrasilAPI.Interfaces
{
    public interface IBrasilAPI
    {
        Task<GenericResponse<EnderecoModel>> BuscarEnderecoPorCEP(string cep);
        Task<GenericResponse<BancoModel>> BuscarBanco(string codigo);
        Task<GenericResponse<List<BancoModel>>> BuscarTodosBancos();
    }
}

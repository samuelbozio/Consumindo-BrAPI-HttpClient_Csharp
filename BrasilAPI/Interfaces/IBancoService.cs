using BrasilAPI.DTOs;
using BrasilAPI.Models;

namespace BrasilAPI.Interfaces
{
    public interface IBancoService
    {
        Task<GenericResponse<BancoResponse>> BuscarBanco(string codigo);
        Task<GenericResponse<List<BancoResponse>>> BuscarTodosBancos();
    }
}

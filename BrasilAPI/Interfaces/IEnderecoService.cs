using BrasilAPI.DTOs;
using BrasilAPI.Models;

namespace BrasilAPI.Interfaces
{
    public interface IEnderecoService
    {
        Task<GenericResponse<EnderecoResponse>> BuscarEndereco(string cep);
    }
}

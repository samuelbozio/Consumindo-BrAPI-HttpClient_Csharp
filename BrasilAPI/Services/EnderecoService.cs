using AutoMapper;
using BrasilAPI.DTOs;
using BrasilAPI.Interfaces;

namespace BrasilAPI.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilAPI _brasilAPI;

        public EnderecoService(IMapper mapper, IBrasilAPI brasilAPI)
        {
            _mapper = mapper;
            _brasilAPI = brasilAPI;
        }

        public async Task<GenericResponse<EnderecoResponse>> BuscarEndereco(string cep)
        {
            var endereco = await _brasilAPI.BuscarEnderecoPorCEP(cep);
            return _mapper.Map<GenericResponse<EnderecoResponse>>(endereco);
        }



    }
}

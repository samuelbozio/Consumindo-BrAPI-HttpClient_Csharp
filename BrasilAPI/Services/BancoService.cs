using AutoMapper;
using BrasilAPI.DTOs;
using BrasilAPI.Interfaces;

namespace BrasilAPI.Services
{
    public class BancoService : IBancoService
    {


        private readonly IMapper _mapper;
        private readonly IBrasilAPI _brasilAPI;

        public BancoService(IMapper mapper, IBrasilAPI brasilAPI)
        {
            _mapper = mapper;
            _brasilAPI = brasilAPI;
        }

        public async Task<GenericResponse<BancoResponse>> BuscarBanco(string codigo) //
        {
            var banco = await _brasilAPI.BuscarBanco(codigo);
            return _mapper.Map<GenericResponse<BancoResponse>>(banco);
        }

        public async Task<GenericResponse<List<BancoResponse>>> BuscarTodosBancos()
        {
            var bancos = await _brasilAPI.BuscarTodosBancos();
            return _mapper.Map<GenericResponse<List<BancoResponse>>>(bancos);
        }
    }
}

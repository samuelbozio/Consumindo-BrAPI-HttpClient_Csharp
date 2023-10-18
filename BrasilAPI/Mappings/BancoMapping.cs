using BrasilAPI.DTOs;
using BrasilAPI.Models;
using AutoMapper;
namespace BrasilAPI.Mappings
{
    public class BancoMapping: Profile
    {
        public BancoMapping()
        {

            CreateMap(typeof(GenericResponse<>), typeof(GenericResponse<>));
            CreateMap<BancoResponse, BancoModel>();
            CreateMap<BancoModel, BancoResponse>();

        }
    }
}

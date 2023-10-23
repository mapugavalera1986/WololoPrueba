using AutoMapper;
using WololoPrueba.Models;
using WololoPrueba.ObjetosTransferir;

namespace WololoPrueba.Utilities
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Civ, CivDto>().ReverseMap();
            CreateMap<Colegio, ColegioDto>().ReverseMap();
            CreateMap<Participante, ParticipanteDto>().ReverseMap();
            CreateMap<Ensayo, EnsayoDto>().ReverseMap();
            CreateMap<Premio, PremioDto>().ReverseMap();
        }
    }
}

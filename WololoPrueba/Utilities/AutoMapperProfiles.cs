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
            CreateMap<Colegio, ColegioCrearDto>().ReverseMap();
            CreateMap<Participante, ParticipanteCrearDto>().ReverseMap();
            CreateMap<Premios , PremiosCrearDto>().ReverseMap();
        }
    }
}

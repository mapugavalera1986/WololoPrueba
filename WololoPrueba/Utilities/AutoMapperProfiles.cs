using AutoMapper;
using WololoPrueba.Models;
using WololoPrueba.ObjetosTransferir;

namespace WololoPrueba.Utilities
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Colegio, ColegioCrearDto>().ReverseMap();
            CreateMap<Participante, ParticipanteCrearDto>().ReverseMap();
        }
    }
}

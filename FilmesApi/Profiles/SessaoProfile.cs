using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace FilmesApi.Profiles
{
    public class SessaoProfile : Profile
    {
        public SessaoProfile()
        {
            CreateMap<CreatSessaoDto, Sessao>();
            CreateMap<Sessao, ReadSessaoDto>();
        }
    }
}

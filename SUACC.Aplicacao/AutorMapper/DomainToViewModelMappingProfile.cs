using AutoMapper;
using SUACC.Aplicacao.ViewModel;
using SUACC.Dominio.Entidades;

namespace SUACC.Aplicacao.AutorMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Atendimento, AtendimentoCadastroViewModel>();
            CreateMap<Menu, MenuItemViewModel>();
        }
    }
}

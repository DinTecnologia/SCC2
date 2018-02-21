using AutoMapper;
using SUACC.Aplicacao.ViewModel;
using SUACC.Dominio.Entidades;

namespace SUACC.Aplicacao.AutorMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {

        public ViewModelToDomainMappingProfile()
        {
            CreateMap<AtendimentoCadastroViewModel, Atendimento>();
        }
       
    }
}

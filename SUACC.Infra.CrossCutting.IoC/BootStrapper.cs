using SUACC.Aplicacao.Interfaces;
using SUACC.Dominio.Interfaces.Repositorio;
using SUACC.Dominio.Interfaces.Servicos;
using SUACC.Dominio.Servicos;
using SUACC.Infra.Contexto;
using SUACC.Infra.Contexto.Interfaces;
using SimpleInjector;
using SUACC.Aplicacao;
using SUACC.Infra.Repositorio.Dapper;

namespace SUACC.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void Register(Container container)
        {
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Singleton);
            container.Register<IDapperContexto, DapperContexto>(Lifestyle.Singleton);

            container.Register<IAplicacaoAppServico, AplicacaoAppServico>(Lifestyle.Singleton);
            container.Register<IAplicacaoServico, AplicacaoServico>(Lifestyle.Singleton);
            container.Register<IAplicacaoRepositorio, AplicacaoRepositorio>(Lifestyle.Singleton);

            container.Register<IAnotacaoServico, AnotacaoServico>(Lifestyle.Singleton);
            container.Register<IAnotacaoRepositorio, AnotacaoRepositorio>(Lifestyle.Singleton);

            container.Register<IAreaServico, AreaServico>(Lifestyle.Singleton);
            container.Register<IAreaRepositorio, AreaRepositorio>(Lifestyle.Singleton);

            container.Register<IArquivoServico, ArquivoServico>(Lifestyle.Singleton);
            container.Register<IArquivoRepositorio, ArquivoRepositorio>(Lifestyle.Singleton);

            container.Register<IAspNetRoleServico, AspNetRoleServico>(Lifestyle.Singleton);
            container.Register<IAspNetRoleRepositorio, AspNetRoleRepositorio>(Lifestyle.Singleton);

            container.Register<IAspNetUserServico, AspNetUserServico>(Lifestyle.Singleton);
            container.Register<IAspNetUserRepositorio, AspNetUserRepositorio>(Lifestyle.Singleton);

            container.Register<IAspNetUserClaimServico, AspNetUserClaimServico>(Lifestyle.Singleton);
            container.Register<IAspNetUserClaimRepositorio, AspNetUserClaimRepositorio>(Lifestyle.Singleton);

            container.Register<IAspNetUserLoginServico, AspNetUserLoginServico>(Lifestyle.Singleton);
            container.Register<IAspNetUserLoginRepositorio, AspNetUserLoginRepositorio>(Lifestyle.Singleton);

            container.Register<IAtendimentoServico, AtendimentoServico>(Lifestyle.Singleton);
            container.Register<IAtendimentoRepositorio, AtendimentoRepositorio>(Lifestyle.Singleton);

            container.Register<IAtividadeServico, AtividadeServico>(Lifestyle.Singleton);
            container.Register<IAtividadeRepositorio, AtividadeRepositorio>(Lifestyle.Singleton);

            container.Register<IAtividadeEnvolvidoServico, AtividadeEnvolvidoServico>(Lifestyle.Singleton);
            container.Register<IAtividadeEnvolvidoRepositorio, AtividadeEnvolvidoRepositorio>(Lifestyle.Singleton);

            //container.Register<IAtividadeTipoServico, AtividadeTipoServico>(Lifestyle.Singleton);
            //container.Register<IAtividadeTipoRepositorio, AtividadeTipoRepositorio>(Lifestyle.Singleton);

            container.Register<ICampanhaServico, CampanhaServico>(Lifestyle.Singleton);
            container.Register<ICampanhaRepositorio, CampanhaRepositorio>(Lifestyle.Singleton);

            container.Register<ICampoDinamicoServico, CampoDinamicoServico>(Lifestyle.Singleton);
            container.Register<ICampoDinamicoRepositorio, CampoDinamicoRepositorio>(Lifestyle.Singleton);

            container.Register<ICampoDinamicoOpcaoServico, CampoDinamicoOpcaoServico>(Lifestyle.Singleton);
            container.Register<ICampoDinamicoOpcaoRepositorio, CampoDinamicoOpcaoRepositorio>(Lifestyle.Singleton);

            container.Register<ICampoDinamicoPreenchidoServico, CampoDinamicoPreenchidoServico>(Lifestyle.Singleton);
            container.Register<ICampoDinamicoPreenchidoRepositorio, CampoDinamicoPreenchidoRepositorio>(Lifestyle.Singleton);

            //container.Register<ICanalServico, CanalServico>(Lifestyle.Singleton);
            //container.Register<ICanalRepositorio, CanalRepositorio>(Lifestyle.Singleton);

            container.Register<ICidadeServico, CidadeServico>(Lifestyle.Singleton);
            container.Register<ICidadeRepositorio, CidadeRepositorio>(Lifestyle.Singleton);

            container.Register<IClassificacaoServico, ClassificacaoServico>(Lifestyle.Singleton);
            container.Register<IClassificacaoRepositorio, ClassificacaoRepositorio>(Lifestyle.Singleton);

            container.Register<IClienteServico, ClienteServico>(Lifestyle.Singleton);
            container.Register<IClienteRepositorio, ClienteRepositorio>(Lifestyle.Singleton);

            container.Register<IClienteEnderecoServico, ClienteEnderecoServico>(Lifestyle.Singleton);
            container.Register<IClienteEnderecoRepositorio, ClienteEnderecoRepositorio>(Lifestyle.Singleton);

            container.Register<IConfiguracaoServico, ConfiguracaoServico>(Lifestyle.Singleton);
            container.Register<IConfiguracaoRepositorio, ConfiguracaoRepositorio>(Lifestyle.Singleton);

            container.Register<IContratoServico, ContratoServico>(Lifestyle.Singleton);
            container.Register<IContratoRepositorio, ContratoRepositorio>(Lifestyle.Singleton);

            container.Register<IEmailServico, EmailServico>(Lifestyle.Singleton);
            container.Register<IEmailRepositorio, EmailRepositorio>(Lifestyle.Singleton);

            container.Register<IEmailAnexoServico, EmailAnexoServico>(Lifestyle.Singleton);
            container.Register<IEmailAnexoRepositorio, EmailAnexoRepositorio>(Lifestyle.Singleton);

            container.Register<IEmailContaServico, EmailContaServico>(Lifestyle.Singleton);
            container.Register<IEmailContaRepositorio, EmailContaRepositorio>(Lifestyle.Singleton);

            container.Register<IEmailModeloServico, EmailModeloServico>(Lifestyle.Singleton);
            container.Register<IEmailModeloRepositorio, EmailModeloRepositorio>(Lifestyle.Singleton);

            container.Register<IEntidadeServico, EntidadeServico>(Lifestyle.Singleton);
            container.Register<IEntidadeRepositorio, EntidadeRepositorio>(Lifestyle.Singleton);

            container.Register<IEntidadeCampoValorServico, EntidadeCampoValorServico>(Lifestyle.Singleton);
            container.Register<IEntidadeCampoValorRepositorio, EntidadeCampoValorRepositorio>(Lifestyle.Singleton);

            container.Register<IEntidadeSecaoServico, EntidadeSecaoServico>(Lifestyle.Singleton);
            container.Register<IEntidadeSecaoRepositorio, EntidadeSecaoRepositorio>(Lifestyle.Singleton);

            container.Register<IEntidadeSecaoAbaServico, EntidadeSecaoAbaServico>(Lifestyle.Singleton);
            container.Register<IEntidadeSecaoAbaRepositorio, EntidadeSecaoAbaRepositorio>(Lifestyle.Singleton);

            container.Register<IEntidadeSecaoAbaCampoDinamicoServico, EntidadeSecaoAbaCampoDinamicoServico>(Lifestyle.Singleton);
            container.Register<IEntidadeSecaoAbaCampoDinamicoRepositorio, EntidadeSecaoAbaCampoDinamicoRepositorio>(Lifestyle.Singleton);

            container.Register<IFilaServico, FilaServico>(Lifestyle.Singleton);
            container.Register<IFilaRepositorio, FilaRepositorio>(Lifestyle.Singleton);

            container.Register<IFilaAtividadeServico, FilaAtividadeServico>(Lifestyle.Singleton);
            container.Register<IFilaAtividadeRepositorio, FilaAtividadeRepositorio>(Lifestyle.Singleton);

            container.Register<IFuncionalidadeServico, FuncionalidadeServico>(Lifestyle.Singleton);
            container.Register<IFuncionalidadeRepositorio, FuncionalidadeRepositorio>(Lifestyle.Singleton);

            container.Register<ILigacaoServico, LigacaoServico>(Lifestyle.Singleton);
            container.Register<ILigacaoRepositorio, LigacaoRepositorio>(Lifestyle.Singleton);

            container.Register<IMailingServico, MailingServico>(Lifestyle.Singleton);
            container.Register<IMailingRepositorio, MailingRepositorio>(Lifestyle.Singleton);

            container.Register<IMenuServico, MenuServico>(Lifestyle.Singleton);
            container.Register<IMenuRepositorio, MenuRepositorio>(Lifestyle.Singleton);

            container.Register<IMotivoServico, MotivoServico>(Lifestyle.Singleton);
            container.Register<IMotivoRepositorio, MotivoRepositorio>(Lifestyle.Singleton);

            container.Register<IMotivoClassificacaoServico, MotivoClassificacaoServico>(Lifestyle.Singleton);
            container.Register<IMotivoClassificacaoRepositorio, MotivoClassificacaoRepositorio>(Lifestyle.Singleton);

            container.Register<IMotivoClassificacaoFilaServico, MotivoClassificacaoFilaServico>(Lifestyle.Singleton);
            container.Register<IMotivoClassificacaoFilaRepositorio, MotivoClassificacaoFilaRepositorio>(Lifestyle.Singleton);

            container.Register<IMotivoPausaServico, MotivoPausaServico>(Lifestyle.Singleton);
            container.Register<IMotivoPausaRepositorio, MotivoPausaRepositorio>(Lifestyle.Singleton);

            container.Register<IOcorrenciaServico, OcorrenciaServico>(Lifestyle.Singleton);
            container.Register<IOcorrenciaRepositorio, OcorrenciaRepositorio>(Lifestyle.Singleton);

            container.Register<IRemessaServico, RemessaServico>(Lifestyle.Singleton);
            container.Register<IRemessaRepositorio, RemessaRepositorio>(Lifestyle.Singleton);

            container.Register<ITarefaServico, TarefaServico>(Lifestyle.Singleton);
            container.Register<ITarefaRepositorio, TarefaRepositorio>(Lifestyle.Singleton);

            container.Register<ITelefoneServico, TelefoneServico>(Lifestyle.Singleton);
            container.Register<ITelefoneRepositorio, TelefoneRepositorio>(Lifestyle.Singleton);

            container.Register<ITokenServico, TokenServico>(Lifestyle.Singleton);
            container.Register<ITokenRepositorio, TokenRepositorio>(Lifestyle.Singleton);

            container.Register<ITurnoServico, TurnoServico>(Lifestyle.Singleton);
            container.Register<ITurnoRepositorio, TurnoRepositorio>(Lifestyle.Singleton);

            container.Register<IUsuarioCampanhaServico, UsuarioCampanhaServico>(Lifestyle.Singleton);
            container.Register<IUsuarioCampanhaRepositorio, UsuarioCampanhaRepositorio>(Lifestyle.Singleton);

            container.Register<IUsuarioTelefoniaServico, UsuarioTelefoniaServico>(Lifestyle.Singleton);
            container.Register<IUsuarioTelefoniaRepositorio, UsuarioTelefoniaRepositorio>(Lifestyle.Singleton);

            container.Register<IConfiguracaoAppServico, ConfiguracaoAppServico>(Lifestyle.Singleton);
            container.Register<IAtendimentoAppServico, AtendimentoAppServico>(Lifestyle.Singleton);

        }
    }
}

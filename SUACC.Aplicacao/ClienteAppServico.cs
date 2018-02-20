using System;
using System.Collections.Generic;
using SUACC.Aplicacao.Interfaces;
using SUACC.Aplicacao.ViewModel;
using SUACC.Dominio.Interfaces.Servicos;
using SUACC.Dominio.Validacoes;
using SUACC.Infra.Contexto.Interfaces;

namespace SUACC.Aplicacao
{
    public class ClienteAppServico : AppServico, IClienteAppServico
    {
        private readonly IClienteServico _clienteServico;
        private readonly IUnitOfWork _uow;

        public ClienteAppServico(IUnitOfWork uow, IClienteServico clienteServico)
        {
            _uow = uow;
            _clienteServico = clienteServico;
        }

        public ValidationResult Adicionar(ClienteCadastroViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public ClienteEnderecoCadastroViewModel AdicionarEndereco(ClienteEnderecoCadastroViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public ClienteCadastroViewModel Atualizar(ClienteCadastroViewModel clienteViewModel)
        {
            throw new NotImplementedException();
        }

        public ClienteEnderecoCadastroViewModel AtualizarEndereco(ClienteEnderecoCadastroViewModel enderecoViewModel)
        {
            throw new NotImplementedException();
        }

        public ClienteCadastroViewModel Novo(string usuarioId)
        {
            throw new NotImplementedException();
        }

        public ClienteEnderecoCadastroViewModel NovoEndereco()
        {
            throw new NotImplementedException();
        }

        public ClienteEnderecoCadastroViewModel ObterEnderecoPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public ClienteCadastroViewModel ObterPorDocumento(string documento)
        {
            throw new NotImplementedException();
        }

        public ClienteCadastroViewModel ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public ClienteCadastroViewModel ObterPorProtocoloAtendimento(string protocolo)
        {
            throw new NotImplementedException();
        }

        public ClienteCadastroViewModel ObterPorProtocoloOcorrencia(string protocoloOcorrencia)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClienteViewModel> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(Guid id)
        {
            throw new NotImplementedException();
        }

        public void RemoverEndereco(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}

using SUACC.Aplicacao.ViewModel;
using SUACC.Dominio.Validacoes;
using System;
using System.Collections.Generic;

namespace SUACC.Aplicacao.Interfaces
{
    public interface IClienteAppServico
    {
        ClienteCadastroViewModel Novo(string usuarioId);
        ValidationResult Adicionar(ClienteCadastroViewModel viewModel);
        ClienteCadastroViewModel ObterPorId(Guid id);
        ClienteCadastroViewModel ObterPorDocumento(string documento);
        ClienteCadastroViewModel ObterPorProtocoloAtendimento(string protocolo);
        ClienteCadastroViewModel ObterPorProtocoloOcorrencia(string protocoloOcorrencia);
        IEnumerable<ClienteViewModel> ObterTodos();
        ClienteCadastroViewModel Atualizar(ClienteCadastroViewModel clienteViewModel);
        void Remover(Guid id);

        ClienteEnderecoCadastroViewModel NovoEndereco();
        ClienteEnderecoCadastroViewModel AdicionarEndereco(ClienteEnderecoCadastroViewModel viewModel);
        ClienteEnderecoCadastroViewModel AtualizarEndereco(ClienteEnderecoCadastroViewModel enderecoViewModel);
        ClienteEnderecoCadastroViewModel ObterEnderecoPorId(Guid id);
        void RemoverEndereco(Guid id);
    }
}

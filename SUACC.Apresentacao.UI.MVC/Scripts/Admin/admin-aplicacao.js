




var _botaoAplicaoAdicionar;

$(function () {
    init_checkboxe_radios();
    _botaoAplicaoAdicionar = Ladda.create(document.querySelector('#Aplicacao_Adicionar'));
});

function adicionarAplicacao() {

    _botaoAplicaoAdicionar.start();

    var viewModel = {
        Nome: $('#AplicacaoAdicionar_Nome').val(),
        Url: $('#AplicacaoAdicionar_Url').val(),
        Ssl: $('#AplicacaoAdicionar_Ssl').is(':checked')
    };

    if (!validarNovaAplicao(viewModel)) {
        _botaoAplicaoAdicionar.stop();
        return;
    }

    $.ajax({
        url: '/Admin/Aplicacao/Adicionar',
        type: 'POST',
        cache: false,
        data: viewModel,
        success: function (retorno) {

            _botaoAplicaoAdicionar.stop();

            if (retorno.statusRequisicao === 'sucesso') {
                alert('Aplicação Adicionada com Sucesso');
            }
            else {
                alert(retorno.mensagem);
            }


        },
        error: function (jqXHR, status, error) {
            if (onError !== null && onError !== undefined) {
                onError(jqXHR, status, error);
                $("#" + settings.updateTargetId).html(error);
            }
        }
    });
}

function validarNovaAplicao(viewModel) {

    var retorno = true;

    if (viewModel.Nome === '') {
        alert('Informe o Nome');
        retorno = false;
    }

    if (viewModel.Url === '') {
        alert('informe a Url');
        retorno = false;
    }

    return retorno;
}

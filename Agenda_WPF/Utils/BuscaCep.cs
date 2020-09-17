using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Agenda_WPF.Utils
{
    class BuscaCep
    {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string unidade { get; set; }
        public string ibge { get; set; }
        public string gia { get; set; }
    }

    //public void LocalizarCEP()
    //{
    //    RestClient restClient = new RestClient(string.Format("https://viacep.com.br/ws/{0}/json/", txtCep_Leave.Text));
    //    RestRequest restRequest = new RestRequest(Method.GET);
    //    IRestResponse restResponse = restClient.Execute(restRequest);

    //    BuscaCep cepRetorno = new JsonDeserializer().Deserialize<BuscaCep>(restResponse);

    //    if (cepRetorno.cep is null)
    //    {
    //        MessageBox.Show("CEP não encontrado! ", "Atenção!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
    //        frmtxtCep_Leave.Clear();
    //        txtCep_Leave.Focus();
    //        return;
    //    }
    //    txtRua.Text = cepRetorno.logradouro;
    //    txtBairro.Text = cepRetorno.bairro;
    //    txtCidade.Text = cepRetorno.localidade;
    //    txtEstado.Text = cepRetorno.uf;
    //}
}

using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    //abstract serve para ninguem instanciar a classe
    public abstract class Entidade
    {
        private List<string> _mensagensValidacao { get; set; }
        private List<string> mensagemValidacao 
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        protected void LimparMensagemValidacao()
        {
            mensagemValidacao.Clear();
        }

        protected void AdicionarCritica(string mensagem)
        {
            mensagemValidacao.Add(mensagem);
        }

        public abstract void Validate();
        protected bool EhValido
        {
            //a leitura que se faz aqui é, se não tiver nenhuma mensagem de validacao a classe é considerada como valida
            get { return !mensagemValidacao.Any(); }
        }
    }
}

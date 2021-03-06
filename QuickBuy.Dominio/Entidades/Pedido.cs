using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public string NumeroEndereco { get; set; }

        public int FormaPagementoId { get; set; }

        public FormaPagamento FormaPagamento { get; set; }



        //Pedido deve ter pelo menos um pedido ou muitos pedidos
        //ou muito itens de pedido
        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();

            if (!ItensPedido.Any())
                AdicionarCritica("Crítica - Pedido não pode ficar sem Item de Pedido");

            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("Crítica - CEP deve estar preenchido");

            if (FormaPagementoId == 0)
                AdicionarCritica("Crítica -Não foi informado a forma de pagamento");

        }
    }
}

﻿namespace QuickBuy.Dominio.Entidades
{
    //definindo que a classe Entidade é a classe pai
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if (ProdutoId == 0)
                AdicionarCritica("Não foi identificado a referencia do produto");

            if (Quantidade == 0)
                AdicionarCritica("Quantidade não foi informada");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
//teste gitbash
namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }


        //Um usuário pode ter nenhum ou muitos pedidos
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Email não informado");

            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("Senha não informado");
        }
    }
}

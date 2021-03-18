using QuickBuy.Dominio.Enumerados;

namespace QuickBuy.Dominio.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool EhBoleto
        {
            //está sendo feito um cast de int (Cast é um meio pelo qual vc transforma um valor de um tipo para outro)
            get { return Id == (int) TipoFormaPagamentoEnum.Boleto; }
        }

        public bool EhCartaoCredito
        {
            //está sendo feito um cast de int (Cast é um meio pelo qual vc transforma um valor de um tipo para outro)
            get { return Id == (int)TipoFormaPagamentoEnum.CartaoCredito; }
        }

        public bool EhDeposito
        {
            //está sendo feito um cast de int (Cast é um meio pelo qual vc transforma um valor de um tipo para outro)
            get { return Id == (int)TipoFormaPagamentoEnum.Deposito; }
        }

        public bool NaoFoiDefinido
        {
            //está sendo feito um cast de int (Cast é um meio pelo qual vc transforma um valor de um tipo para outro)
            get { return Id == (int)TipoFormaPagamentoEnum.NaoDefinido; }
        }   
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_contas_v1_MVC.Models
{
    public class ContasReceberModel
    {

        public int FaturaId { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataPagamento { get; set; }
        public int ClienteId { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorPago { get; set; }
        public decimal ValorReceber { get; set; }


       /* public ContasReceberModel(
            int faturaid, 
            DateTime datavencimento, 
            DateTime datapagamento, 
            int clienteid, 
            decimal valor,
            decimal valorpago,
            decimal valorreceber)
        {
            faturaid = FaturaId;
            datavencimento = DataVencimento;
            clienteid = ClienteId;
            valor = Valor;
            valorpago = ValorPago;
            valorreceber = ValorReceber;
        }*/

        public decimal CalcValorPago()
        {
            ValorReceber = Valor - ValorPago;

            return ValorReceber;
        }

    }
}

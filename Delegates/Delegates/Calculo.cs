using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Delegates
{
    public class Calculo
    {
        public delegate decimal CalcularPrecoTotal(decimal precoUnitario, int quantidade);

        public static decimal CalcularPrecoTotalPedido(CalcularPrecoTotal calcularPrecoTotal, List<(decimal precoUnitario, int quantidade)> itensPedido)
        {
            decimal precoTotal = 0;

            foreach (var item in itensPedido)
            {
                precoTotal += calcularPrecoTotal(item.precoUnitario, item.quantidade);
            }

            return precoTotal;
        }

    }
}

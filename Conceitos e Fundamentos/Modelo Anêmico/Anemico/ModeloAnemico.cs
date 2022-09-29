using System;
using System.Collections.Generic;

namespace Anemico
{
    public class Pedido
    {
        public int Id { get; set; }
        public string ClienteId { get; set; }
        public decimal Desconto { get; set; }
        public DateTime? DataPagamento { get; set; }
        public List<ItemPedido> Itens { get; set; }
    }

    public class ItemPedido
    {
        //codigo...
    }

    public class PedidoService
    {
        public void AddItem(int id, ItemPedido item)
        {
            //codigo...
        }
        public void DescontoPedido(int id, decimal desconto)
        {
            //codigo...
        }
        public void PagamentoPedido(int id)
        {
            //codigo...
        }
    }
    /// <summary>
    /// No arquivo ModeloRico.cs fiz as implementações de um modelo rico, 
    /// onde deixamos uma classe mais limpa e mais segura de sofres mudanças
    /// </summary>
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

    }
}

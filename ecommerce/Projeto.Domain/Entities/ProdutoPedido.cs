using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.Domain.Entities
{
    [Table("produtoPedido")]
    public class ProdutoPedido
    {
        [Key,Column(Order = 0)]
        public string PedidoId { get; set; }
        public virtual Pedido Pedido { get; set; }

        [Key, Column(Order = 1)]
        public string ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }

      
    }
}
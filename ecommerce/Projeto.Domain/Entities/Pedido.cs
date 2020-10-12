using Projeto.Domain.Enumerators;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.Domain.Entities
{
    [Table("pedido")]
    public class Pedido
    {
        [Key]
        public string Id { get; set; }
        public DateTime Data_cadastro { get; set; }
        public string ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public string Status_entrega { get; set; }
    }
}
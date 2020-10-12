using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.Domain.Entities
{
    [Table("produto")]
    public class Produto
    {
        [Key]
        public string Id { get; set; }
        [MaxLength(60)]
        public string Nome { get; set; }
        [Required]
        public double Valor { get; set; }
        public Boolean Disponivel { get; set; }
    }
}
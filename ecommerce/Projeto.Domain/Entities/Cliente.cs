using Projeto.Domain.Enumerators;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.Domain.Entities
{
    [Table("cliente")]
    public class Cliente
    {
        [Key]
        public string Id { get; set; }
        [MaxLength(60)]
        public string Nome { get; set; }
        public DateTime Data_cadastro { get; set; }
        public String Status { get; set; }
    }
}
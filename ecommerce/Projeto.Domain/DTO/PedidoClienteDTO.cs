using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Projeto.Domain.DTO
{
    public class PedidoClienteDTO
    {
        public string Id { get; set; }
        public DateTime Data_cadastro { get; set; }
        public string ClienteId { get; set; }
        public string Status_entrega { get; set; }
        public List<Produto> Produto { get; set; }
        public int Quantidade { get; set; }
    }
}


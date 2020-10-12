using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using MySql.Data.EntityFramework;
using Projeto.Domain.Entities;

namespace Projeto.Infra.Data.Context
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ProjetoModeloContext : DbContext
    {      
        public ProjetoModeloContext()
            : base("DefaultConnection")
        {

        }

         public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Produto> Produto { get; set; }

        public DbSet<Pedido> Pedido { get; set; }
        
        public DbSet<ProdutoPedido> ProdutoPedido { get; set; }

    }

}

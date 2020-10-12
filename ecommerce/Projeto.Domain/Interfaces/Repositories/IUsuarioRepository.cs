using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Domain.Entities;

namespace Projeto.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository
    {
        Usuario Login(Usuario usuario);
    }
}

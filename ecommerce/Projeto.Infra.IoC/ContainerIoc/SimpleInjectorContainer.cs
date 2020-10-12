
using System.Threading;
using Projeto.Application.ApplicationServices;
using Projeto.Application.Interfaces;
using Projeto.Domain.Interfaces.Repositories;
using Projeto.Domain.Interfaces.Services;
using Projeto.Domain.Interfaces.UnitOfWork;
using Projeto.Infra.Data;
using Projeto.Infra.Data.Context;
using Projeto.Infra.Data.Repositories;
using Projeto.Infra.Data.Services;
using SimpleInjector;
using SimpleInjector.Integration.Web;

namespace Projeto.Infra.IoC.ContainerIoc
{
    public class SimpleInjectorContainer
    {
        public static Container _container;
        private static readonly object s_lock = new object();

        static SimpleInjectorContainer()
        {
            RegisterServices();
        }

        public static Container Container
        {
            get
            {
                if (_container != null) return _container;
                Container temp = RegisterServices();
                Interlocked.Exchange(ref _container, temp);
                return _container;
            }
        }

        public static Container RegisterServices()
        {
            _container = new Container();
            _container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            _container.Register<ProjetoModeloContext>(Lifestyle.Scoped);

            _container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);

            #region Repository
            _container.Register<IUsuarioRepository, UsuarioRepository>(Lifestyle.Scoped);
            _container.Register<IClienteRepository, ClienteRepository>(Lifestyle.Scoped);
            _container.Register<IPedidoRepository, PedidoRepository>(Lifestyle.Scoped);
            _container.Register<IProdutoRepository, ProdutoRepository>(Lifestyle.Scoped);
            _container.Register<IProdutoPedidoRepository, ProdutoPedidoRepository>(Lifestyle.Scoped);

            #endregion

            #region Service
            _container.Register<IClienteService, ClienteService>(Lifestyle.Scoped);
            _container.Register<IPedidoService, PedidoService>(Lifestyle.Scoped);
            _container.Register<IProdutoService, ProdutoService>(Lifestyle.Scoped);
            _container.Register<IProdutoPedidoService, ProdutoPedidoService>(Lifestyle.Scoped);

            #endregion

            #region Application
            _container.Register<IClienteApplication, ClienteApplication>(Lifestyle.Scoped);
            _container.Register<IPedidoApplication, PedidoApplication>(Lifestyle.Scoped);
            _container.Register<IProdutoApplication, ProdutoApplication>(Lifestyle.Scoped);
            _container.Register<IProdutoPedidoApplication, ProdutoPedidoApplication>(Lifestyle.Scoped);
            #endregion

            return _container;
        }
    }
}

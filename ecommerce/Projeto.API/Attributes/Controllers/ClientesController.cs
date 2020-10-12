using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Projeto.API.Util.Helper;
using Projeto.Application.Interfaces;
using Projeto.Domain.DTO;
using Projeto.Domain.Entities;
using Projeto.Infra.IoC.ContainerIoc;


namespace Projeto.API.Controllers
{
    // [Authorize]
    [RoutePrefix("api/Clientes")]
    public class ClientesController : ApiController
    {
        private readonly IClienteApplication _clienteApplication = SimpleInjectorContainer.Container.GetInstance<IClienteApplication>();
        private readonly IPedidoApplication _pedidoApplication = SimpleInjectorContainer.Container.GetInstance<IPedidoApplication>();


        /// <summary>
        ///Lista todos os clientes de acordo com o filtro
        /// </summary>
        /// <param name="ordem">Filtro de status a ser aplicado</param>
        /// <param name="status">Campo a ser usado como ordenação da listagem</param>
        /// <returns></returns>
        [ResponseType(typeof(Cliente))]
        [HttpGet]
        [Route("ListarClientes")]
        public async Task<IHttpActionResult>ListarClientes(string ordem, string status = null)
        {
              try
            {
                var result = await _clienteApplication.GetListarClientesFiltro(ordem, status);
           
                if (result.Count() == 0)
                    return StatusCode(HttpStatusCode.NoContent);
                else
                    return Ok(result);

            }
            catch (BusinessException ex)
            {
                return new BusinessResult(ex.Message, HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                 return new BusinessResult(ex.Message, HttpStatusCode.InternalServerError);
            }
         
        }
      
        /// <summary>
        ///Cria novo Cliente
        ///</summary>
        /// <returns></returns>
        [ResponseType(typeof(Cliente))]
        [HttpPost]
        [Route("InserirCliente")]
        public async Task<IHttpActionResult> InserirCliente(Cliente cliente)
        {

            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                _clienteApplication.Incluir(cliente);

                return CreatedAtRoute("Default", new { controller = "Cliente", id = cliente.Id }, cliente);
            }
            catch (ApplicationException ex)
            {
                return new BusinessResult(ex.Message, HttpStatusCode.BadRequest);
            }
         
            catch (Exception ex)
            {
                return new BusinessResult(ex.Message, HttpStatusCode.InternalServerError);
            }
        }

        /// <summary>
        ///Recupera os dados do cliente selecionado
        ///</summary>
        /// <param name="idCliente">Identificador do cliente a ser atualizado</param>
        /// <returns></returns>
        [ResponseType(typeof(Cliente))]
        [HttpGet]
        [Route("ObterCliente/{idCliente}")]
        public async Task<IHttpActionResult> ObterCliente(string idCliente)
        {
            try
            {
                var result = await _clienteApplication.ObterCliente(idCliente);
                if (result == null)
                    return StatusCode(HttpStatusCode.NoContent);
                else
                    return Ok(result);

              
            }
            catch (ApplicationException ex)
            {
                return new BusinessResult(ex.Message, HttpStatusCode.BadRequest);
            }

            catch (Exception ex)
            {
                return new BusinessResult(ex.Message, HttpStatusCode.InternalServerError);
            }
        }

        /// <summary>
        ///Atualiza os dados de um cliente
        ///</summary>
        /// <returns></returns>
        [ResponseType(typeof(Cliente))]
        [HttpPut]
        [Route("AtualizarCliente")]
        public async Task<IHttpActionResult> AtualizarCliente(Cliente cliente)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                _clienteApplication.Atualizar(cliente);

                return CreatedAtRoute("Default", new { controller = "Cliente", id = cliente.Id }, cliente);
            }

            catch (ApplicationException ex)
            {
                return new BusinessResult(ex.Message, HttpStatusCode.BadRequest);
            }

            catch (Exception ex)
            {
                return new BusinessResult(ex.Message, HttpStatusCode.InternalServerError);
            }
        }

        /// <summary>
        ///Lista todos os pedidos de um cliente
        ///</summary>
        /// <param name="idCliente">Identificador do cliente</param>
        /// <returns></returns>
        [ResponseType(typeof(List<PedidoClienteDTO>))]
        [HttpGet]
        [Route("ListarPedidosClientes/{idcliente}")]
        public async Task<IHttpActionResult> ListarPedidosClientes(string idcliente)
        {
            try
            {
                var result = await _pedidoApplication.GetListarPedidosCliente(idcliente);

                if (result.Count() == 0)
                    return StatusCode(HttpStatusCode.NoContent);
                else
                    return Ok(result);
            }

            catch (BusinessException ex)
            {
                return new BusinessResult(ex.Message, HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                return new BusinessResult(ex.Message, HttpStatusCode.InternalServerError);
            }
        }

        /// <summary>
        ///Cria um novo pedido para o cliente
        ///</summary>
        /// <param name="idCliente">Identificador do cliente</param>
        /// <returns></returns>
        [ResponseType(typeof(PedidoClienteDTO))]
        [HttpPost]
        [Route("InserirPedido/{idcliente}")]
        public async Task<IHttpActionResult> InserirPedido(PedidoClienteDTO pedidoCliente, string idCliente)
        {

            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                _pedidoApplication.Incluir(pedidoCliente, idCliente);

                return new BusinessResult("Pedido inserido", HttpStatusCode.Created,true);
            }
       
            catch (ApplicationException ex)
            {
                return new BusinessResult(ex.Message, HttpStatusCode.BadRequest);
            }

            catch (Exception ex)
            {
                return new BusinessResult(ex.Message, HttpStatusCode.InternalServerError);
            }
        }
    }
}
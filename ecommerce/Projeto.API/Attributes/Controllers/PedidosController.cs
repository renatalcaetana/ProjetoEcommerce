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
using Projeto.Infra.IoC.ContainerIoc;

namespace Projeto.API.Controllers
{
    // [Authorize]
    [RoutePrefix("api/Pedidos")]
    public class PedidosController : ApiController
    {
         private readonly IPedidoApplication _pedidoApplication = SimpleInjectorContainer.Container.GetInstance<IPedidoApplication>();


        /// <summary>
        ///Lista todos os pedidos conforme o filtro de status da entrega
        /// </summary>
        /// <param name="status_entrega">Informe o status da entrega</param>
        /// <returns></returns>
        [ResponseType(typeof(List<PedidoClienteDTO>))]
        [HttpGet]
        [Route("ListarPedidos")]
        public async Task<IHttpActionResult> ListarPedidos(string statusEntrega)
        {
            try
            {
                var result = await _pedidoApplication.GetListarPedidosStatus(statusEntrega);

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



    }
}
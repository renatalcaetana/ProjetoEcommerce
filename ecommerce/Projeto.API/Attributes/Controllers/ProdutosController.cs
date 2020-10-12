using System;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Projeto.Application.Interfaces;
using Projeto.Domain.Entities;
using Projeto.Infra.IoC.ContainerIoc;
using Projeto.API.Util.Helper;

namespace Projeto.API.Controllers
{
    // [Authorize]
    [RoutePrefix("api/Produtos")]
    public class ProdutosController : ApiController
    {
        private readonly IProdutoApplication _produtoApplication = SimpleInjectorContainer.Container.GetInstance<IProdutoApplication>();

        /// <summary>
        ///Lista todos os produtos
        /// </summary>
        /// <returns></returns>
        [ResponseType(typeof(Produto))]
        [HttpGet]
        [Route("ListarProdutos")]
        public async Task<IHttpActionResult> ListarProdutos()
        {
            try
            {
                var result = await _produtoApplication.ObterProdutos();

                if (result == null)
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

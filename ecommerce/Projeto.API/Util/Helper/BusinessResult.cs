using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace Projeto.API.Util.Helper
{
    public class BusinessResult : IHttpActionResult
    {
        private readonly Dictionary<string, string> _customizedException;
        private HttpStatusCode _statusCode;
        public BusinessResult(string message, HttpStatusCode statusCode,bool? sucesso = false)
        {
            _customizedException = CreateCustomizedException(message, sucesso);
            _statusCode = statusCode;
        }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            var response = new HttpResponseMessage()
            {
                Content = new StringContent(JsonConvert.SerializeObject(_customizedException,Formatting.Indented)),
                StatusCode = _statusCode

            };

            return Task.FromResult(response);
        }

        private Dictionary<string, string> CreateCustomizedException(string message, bool? sucesso = false)
        {
           
            var customizedException = new Dictionary<string, string>()
            {
                { "mensagem", message },
                { "sucesso", sucesso == true? "true": "False" },
                { "descricao", message }
            };
            return customizedException;
               
        }
    }
}
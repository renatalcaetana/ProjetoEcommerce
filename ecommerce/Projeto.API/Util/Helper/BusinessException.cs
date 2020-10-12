using System;

namespace Projeto.API.Util.Helper
{
    public class BusinessException : ApplicationException
    {

        public BusinessException(string message) : base(message)
        {

        }
    }
}

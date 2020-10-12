using System;
using System.Collections.Generic;
using Projeto.Utilities;
using Projeto.Domain.Enumerators;

namespace Projeto.Domain.Exceptions
{
    public class InformationException : Exception
    {
        public InformationException(StatusException status, List<string> mensagens, Exception innerException = null ): base(status.GetDescription(), innerException)
        {
            Status = status;
            Mensagens = mensagens;
        }

        public InformationException(StatusException status, string mensagens, Exception innerException = null) : base(status.GetDescription(), innerException)
        {
            Status = status;
            Mensagens = new List<string> { mensagens };
        }

        public List<string> Mensagens { get; set; }

        public StatusException Status { get; set; }
    }
}

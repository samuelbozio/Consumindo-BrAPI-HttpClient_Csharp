using System.Dynamic;
using System.Net;

namespace BrasilAPI.DTOs
{
    public class GenericResponse<T> where T : class
    {
        public HttpStatusCode CodigoHttp { get; set; }
        public T? DadosRetorno { get; set; }
        public ExpandoObject? ErroRetorno { get; set; }

    }
}

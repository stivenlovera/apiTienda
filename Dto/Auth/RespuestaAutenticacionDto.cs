using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiTienda.Dto.Auth
{
    public class RespuestaAutenticacionDto
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
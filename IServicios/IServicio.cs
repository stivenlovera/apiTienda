using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiTienda.IServicios
{
    public interface IServicio
    {
        void RealizarTarea();
    }
    public class ServicioA : IServicio
    {
        private readonly ILogger<ServicioA> _logger;
        public ServicioA(ILogger<ServicioA> _logger)
        {
            this._logger = _logger;
        }
        public void RealizarTarea()
        {
            throw new NotImplementedException();
        }
    }
    public class ServicioB : IServicio
    {
        public void RealizarTarea()
        {
            throw new NotImplementedException();
        }
    }
}
using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiTienda.IServicios
{
    public interface IServicio
    {
        Guid ObtenerTransit();
        Guid ObtenerScope();
        Guid ObtenerSingelton();
        void RealizarTarea();
    }
    public class ServicioA : IServicio
    {
        private readonly ILogger<ServicioA> _logger;
        private readonly ServicioTransit _servicioTransit;
        private readonly ServicioScope _servicioScope;
        private readonly ServicioSingelton _servicioSingelton;

        public ServicioA(
            ILogger<ServicioA> logger,
            ServicioTransit servicioTransit,
            ServicioScope servicioScope,
            ServicioSingelton servicioSingelton
        )
        {
            this._logger = logger;
            this._servicioTransit = servicioTransit;
            this._servicioScope = servicioScope;
            this._servicioSingelton = servicioSingelton;
        }
        public Guid ObtenerTransit()
        {
            return _servicioTransit.Guid;
        }
        public Guid ObtenerScope()
        {
            return _servicioScope.Guid;
        }
        public Guid ObtenerSingelton()
        {
            return _servicioSingelton.Guid;
        }
        public void RealizarTarea()
        {

        }
    }
    public class ServicioB : IServicio
    {
        public Guid ObtenerScope()
        {
            throw new NotImplementedException();
        }

        public Guid ObtenerSingelton()
        {
            throw new NotImplementedException();
        }

        public Guid ObtenerTransit()
        {
            throw new NotImplementedException();
        }

        public void RealizarTarea()
        {

        }
    }
    public class ServicioTransit
    {
        public Guid Guid = Guid.NewGuid();
    }
    public class ServicioScope
    {
        public Guid Guid = Guid.NewGuid();
    }
    public class ServicioSingelton
    {
        public Guid Guid = Guid.NewGuid();
    }
}
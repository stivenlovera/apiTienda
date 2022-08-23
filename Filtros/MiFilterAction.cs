using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace apiTienda.Filtros
{
    public class MiFilterAction : IActionFilter
    {
        public MiFilterAction(ILogger<MiFilterAction> logger)
        {
            this._logger = logger;
        }
        private ILogger<MiFilterAction> _logger;
        public void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation("antes de ejecutar la accion");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogInformation("despues de ejecutar la accion");
        }




    }
}
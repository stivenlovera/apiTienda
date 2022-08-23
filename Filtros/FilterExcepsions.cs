using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace apiTienda.Filtros
{
    public class FilterExceptions : ExceptionFilterAttribute
    {
        private readonly ILogger<FilterExceptions> _logger;
        public FilterExceptions(ILogger<FilterExceptions> logger)
        {
            this._logger=logger;
        }
        public override void OnException(ExceptionContext context)
        {
            this._logger.LogError(context.Exception, context.Exception.Message);
            base.OnException(context);
        }

    }
}
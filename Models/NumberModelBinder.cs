using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.Extensions.Logging;
using System;
using System.Globalization;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class NumberModelBinder : IModelBinder
    {
        private readonly NumberStyles _supportedStyles = NumberStyles.Float | NumberStyles.AllowThousands;
        private DecimalModelBinder _innerBinder;

        public NumberModelBinder(ILoggerFactory loggerFactory)
        {
            _innerBinder = new DecimalModelBinder(_supportedStyles, loggerFactory);
        }

        /// <inheritdoc />
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            return _innerBinder.BindModelAsync(bindingContext);
        }
    }
}
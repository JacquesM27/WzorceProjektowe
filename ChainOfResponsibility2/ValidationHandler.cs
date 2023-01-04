using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility2
{
    internal class ValidationHandler : BaseHandler
    {
        public ValidationHandler(IHandler handler) : base(handler)
        {
        }

        public override void Handle(RequestContext requestContext)
        {
            Console.WriteLine("Validation handler");
            if (requestContext.Request.EntityId > 1)
            {
                _handler.Handle(requestContext);
                return;
            }
            requestContext.Response.Successful = false;
            requestContext.Response.Message = "Validation error! Id must be greater than 1";
        }
    }
}

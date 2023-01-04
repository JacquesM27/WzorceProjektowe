using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility2
{
    internal class AuthorizationHandler : BaseHandler
    {
        private readonly Dictionary<int, int> entityOwners = new()
        {
            { 1, 1 },
            { 2, 2 },
        };
        public AuthorizationHandler(IHandler handler) : base(handler)
        {
        }

        public override void Handle(RequestContext requestContext)
        {
            Console.WriteLine("Authorization handler");
            if (requestContext.Request.UserRole.Equals("Admin"))
            {
                _handler.Handle(requestContext);
                return;
            }
            if (entityOwners.TryGetValue(requestContext.Request.EntityId, out int ownerId))
            {
                if (ownerId == requestContext.Request.UserId) 
                {
                    _handler.Handle(requestContext);
                    return;
                }
            }
            requestContext.Response.Successful = false;
            requestContext.Response.Message = "User not authorized";
        }
    }
}

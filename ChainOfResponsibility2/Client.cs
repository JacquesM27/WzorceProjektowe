using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility2
{
    internal class Client
    {
        public static void SomeBusinessLogic(RequestContext requestContext)
        {
            var resultHandler = new ResultHandler(null);
            var validationHandler = new ValidationHandler(resultHandler);
            var authorizationHandler = new AuthorizationHandler(validationHandler);

            authorizationHandler.Handle(requestContext);

            Console.WriteLine($"Success? {(requestContext.Response.Successful ? "YES" : "NO")}");
            Console.WriteLine($"Message: {requestContext.Response.Message}");
            Console.WriteLine($"Data: {requestContext.Response.Data}");
        }
    }
}

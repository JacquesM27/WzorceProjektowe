using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility2
{
    internal class ResultHandler : BaseHandler
    {
        public ResultHandler(IHandler handler) : base(handler)
        {
        }

        public override void Handle(RequestContext requestContext)
        {
            Console.WriteLine("Result handler");
            requestContext.Response.Successful= true;
            requestContext.Response.Data = "Many secret data...";
        }
    }
}

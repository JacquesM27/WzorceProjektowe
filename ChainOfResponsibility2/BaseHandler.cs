using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility2
{
    internal abstract class BaseHandler : IHandler
    {
        protected IHandler _handler;
        protected BaseHandler(IHandler handler)
        {
            _handler = handler;
        }
        public abstract void Handle(RequestContext requestContext);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility2
{
    internal class Response
    {
        public bool Successful { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}

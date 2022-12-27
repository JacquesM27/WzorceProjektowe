using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.SomeVideoLibrary
{
    internal class CodecFactory
    {
        public string Extract(VideoFile file)
        {
            string codec = file.FileName[(file.FileName.LastIndexOf('.') + 1)..];
            return codec;
        }
    }
}

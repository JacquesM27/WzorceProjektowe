using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder2
{
    internal interface IPastaBuilder
    {
        IPastaBuilder BoilPasta();
        IPastaBuilder PrepareMeat();
        IPastaBuilder MakeTomatoSauce();
        IPastaBuilder MakeCreamSauce();
        IDinner Build();
        void Reset();
    }
}

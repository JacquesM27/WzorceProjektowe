using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    abstract class State
    {
        protected Context _context;

        public void SetContext(Context context) => _context = context;

        public abstract void HandleFirstTask();
        public abstract void HandleSecondTask();
    }
}

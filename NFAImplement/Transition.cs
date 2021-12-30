using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFAImplement
{
    class Transition
    {
        public State From
        {
            get;
            set;
        }
        public State To
        {
            get;
            set;
        }

        public String Word
        {
            get;
            set;
        }
    }
}

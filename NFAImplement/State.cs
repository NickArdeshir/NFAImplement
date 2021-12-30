using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFAImplement
{
    class State
    {
        public State()
        {
            Transitions = new List<Transition>();

        }
        public String Name
        {
            get;
            set;
        }
        public List<Transition> Transitions
        {
            get;
            set;
        }
        public bool Initial
        {
            get;
            set;
        }
        public bool Final
        {
            get;
            set;
        }

    }
}

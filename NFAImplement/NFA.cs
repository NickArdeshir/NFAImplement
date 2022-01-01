using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace NFAImplement
{
    class NFA
    {
       
        public NFA(List<State> nodes, List<Transition> transitions, string[] alphabet)
        {
            Nodes = nodes;
            Transitions = transitions;
            Alphabet = alphabet;
        }

        public List<State> Nodes
        {
            get;
            set;
        }
        public List<Transition> Transitions
        {
            get;
            set;
        }
        public string[] Alphabet
        {
            get;
            set;
        }

        public bool isAcceptedByNFA(string str)
        {
            Debug.WriteLine("Input = " + str);
            char[] StrArr = str.ToCharArray();
            return (IsNFA(StrArr, 0, Nodes[0]));
        }

        public bool IsNFA(char[] StrArr, int i, State CurrentState)
        {
            if (i == StrArr.Length && CurrentState.Final == true)
            {
                return true;
            }
            else if (i > StrArr.Length)
            {
                return false;
            }
            else
            {
                bool accepted = false;
                bool temp = false;
                for (int j = 0; j < CurrentState.Transitions.Count; j++)
                {
                    if (i < StrArr.Length)
                    {
                        if (CurrentState.Transitions[j].Word == StrArr[i].ToString())
                        {
                            temp = IsNFA(StrArr, i + 1, CurrentState.Transitions[j].To);
                            if (temp == true)
                            {
                                accepted = true;
                                break;
                            }
                        }
                    }
                }

                for (int j = 0; j < CurrentState.Transitions.Count; j++)
                {
                    if (CurrentState.Transitions[j].Word == "_")
                    {
                        temp = IsNFA(StrArr, i, CurrentState.Transitions[j].To);
                        if (temp == true)
                        {
                            accepted = true;
                            break;
                        }
                    }

                }

                return accepted;
            }
        }

    }
}

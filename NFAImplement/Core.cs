using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace NFAImplement
{
    class Core
    {
        public static List<State> Nodes = new List<State>();
        public static List<Transition> Transitions = new List<Transition>();
        public static string[] Alphabet;
        

        public static void InitStates(string[] States)
        {
            for (int i = 0; i < States.Length; i++)
            {
                State NewState = new State();
                if (i == 0)
                {
                    NewState.Initial = true;
                }
                Debug.WriteLine(States[i]);               
                NewState.Name = States[i];
                Nodes.Add(NewState);
            }
        }

        public static void InitFinalStates(string[] FinalStates)
        {
            for (int i = 0; i < FinalStates.Length; i++)
            {
                for (int j = 0; j < Nodes.Count; j++)
                {
                    
                    if (FinalStates[i] == Nodes[j].Name)
                    {
                        Debug.WriteLine("final="+ FinalStates[i]);
                        Nodes[j].Final = true;
                    }
                }
            }
        }

        public static void InitTransitions(string TextBox, int NumOfTransitions)
        {
            string[] Tr = TextBox.Split('\n');
            
            for (int i = 0; i < NumOfTransitions; i++)
            {
                Debug.WriteLine($"Tr[{i}] = "+Tr[i]);
                string[] Transition = Tr[i].Split(' ');
                string qi = Transition[0];
                string qf = Transition[1];
                string Alpha;
                if (Transition.Length == 3)
                {
                    Alpha = Transition[2].Replace("\r","");
                }
                else
                {
                    Alpha = "_";
                }
                Debug.WriteLine("From: "+qi);
                Debug.WriteLine("To: " + qf);
                Debug.WriteLine("With: " + Alpha);
                Transition newTransition = new Transition();
                newTransition.Word = Alpha;
                for (int j = 0; j < Nodes.Count; j++)
                {
                    if (qi == Nodes[j].Name)
                    {
                        newTransition.From = Nodes[j];
                    }
                    if (qf == Nodes[j].Name)
                    {
                        newTransition.To = Nodes[j];
                    }
                }
                Transitions.Add(newTransition);
            }
        }
        public static void InitAlphabet(string alphabet)
        {
            
            string[] alpha = alphabet.Split(',');
            Alphabet = alpha;
            Debug.WriteLine("Alphabet = " + Alphabet[0]);
            Debug.WriteLine("Alphabet = " + Alphabet[1]);
        }
        public static void SetTransitionsToStates()
        {
            for (int i = 0; i < Nodes.Count; i++)
            {
                for (int j = 0; j < Transitions.Count; j++)
                {
                    if (Nodes[i] == Transitions[j].From)
                    {
                        Nodes[i].Transitions.Add(Transitions[j]);
                    }
                }
            }
        }
    
        public static bool Check(string input)
        {
            NFA nfa = new NFA(Nodes, Transitions, Alphabet);
            
            return nfa.isAcceptedByNFA(input);
        }
    }
}

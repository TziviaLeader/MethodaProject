using Methoda.BLL;
using Methoda.Models;

namespace Methoda.DAL
{
    public static class TransitionDAL
    {
        public static List<Transition> transitions { get; set; }=new List<Transition>();

        public static List<Transition> getAll()
        {
            return transitions;
        }

        public static Transition getTrasitionByName(string name)
        {
            return transitions.First(t => t.Name == name);
        }
        
        //need throw exeption
        public static string AddTransition(Transition transition)
        {
            foreach (var tran in transitions)
            {
                if (tran.Name == transition.Name)
                {
                    return "the name already exists";
                }
            }
            transitions.Add(transition);
            StatusBLL.ChangeTypeOfStatusForAddTransition(transition.FromStatus, transition.ToStatus);
            return "the transition added successfully";
        }

        public static void DeleteTransition(string name)
        {
            Transition t = getTrasitionByName(name);
            transitions.Remove(t);
            StatusBLL.ChangeTypeOfStatusForDeleteTransition(t.FromStatus, t.ToStatus);

        }

        public static void Reset()
        {
            transitions.Clear();
        }

    }
}

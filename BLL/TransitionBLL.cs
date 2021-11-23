using Methoda.DAL;
using Methoda.Models;

namespace Methoda.BLL
{
    public static class TransitionBLL
    {
        public static void DeleteTransitions(string status)
        {
            foreach (var tran in TransitionDAL.transitions)
            {
                if (tran.FromStatus.Name == status || tran.ToStatus.Name == status)
                    TransitionDAL.DeleteTransition(tran.Name);
            }

        }
    }
}

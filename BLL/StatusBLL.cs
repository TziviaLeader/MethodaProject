using Methoda.DAL;
using Methoda.Models;

namespace Methoda.BLL
{
    public static class StatusBLL
    {
        public static void SetTypeOfStatus(Status status)
        {
            if (StatusDAL.statuses.Count == 0)
            {
                status.Type = Models.Type.Init | Models.Type.Final;
            }
            else
            {
                status.Type = Models.Type.Final | Models.Type.Orphan;
            }
        }

        public static bool ExistsInFrom(string nameOfStatus)
        {
            foreach (var tran in TransitionDAL.transitions)
            {
                if (tran.FromStatus.Name == nameOfStatus)
                    return true;
            }
            return false;
        }

        public static bool ExistsInTo(string nameOfStatus)
        {
            foreach (var tran in TransitionDAL.transitions)
            {
                if (tran.ToStatus.Name == nameOfStatus)
                    return true;
            }
            return false;
        }
        public static void ChangeTypeOfStatusForAddTransition(Status fromStatus,Status toStatus)
        {
            if(fromStatus.Type != Models.Type.Init)
            {
                if (!ExistsInTo(fromStatus.Name))
                {
                    fromStatus.Type = Models.Type.Orphan;
                }
                else
                {
                    fromStatus.Type = Models.Type.Basic;
                }
            }
            if (toStatus.Type != Models.Type.Init)
            {
                if (!ExistsInFrom(toStatus.Name))
                {
                    fromStatus.Type = Models.Type.Final;
                }
                else
                {
                    fromStatus.Type = Models.Type.Basic;
                }
            }
            else
                if(!ExistsInFrom(toStatus.Name))
                    fromStatus.Type = Models.Type.Init|Models.Type.Final;

        }
        //like the ChangeTypeOfStatusForAddTransition function ...
        public static void ChangeTypeOfStatusForDeleteTransition(Status fromStatus, Status toStatus)
        {

        }
        
        //if the first deleted set init to the second and remove orpha
        public static void SetInit(Status statusToRemove)
        {
            if(StatusDAL.statuses.Count>1)
            {
                Status status = StatusDAL.statuses.First();
                if (statusToRemove.Name == status.Name)
                {
                    status = StatusDAL.statuses[1];
                }
                if (status != null)
                {
                    if (status.Type == Models.Type.Orphan || status.Type == (Models.Type.Orphan | Models.Type.Final))
                        status.Type -= 1;
                    else
                        status.Type += 1;
                }
            }
           
        }
    }
}

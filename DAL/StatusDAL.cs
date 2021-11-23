using Methoda.BLL;
using Methoda.Models;

namespace Methoda.DAL
{
    public static class StatusDAL
    {
        public static List<Status> statuses { get; set; }=new List<Status>();

        public static List<Status> getAll()
        {
            return statuses;
        }

        public static Status getStatusByName(string name)
        {
            return statuses.Any() ? statuses.First(s=>s.Name==name): null;
        }

        public static string AddStatus(Status status)
        {
            foreach (var stat in statuses)
            {
                if(stat.Name==status.Name)
                {
                    return "the name already exists";
                }
            }
            StatusBLL.SetTypeOfStatus(status);
            statuses.Add(status);
            return "the status added successfully";
        }

        public static void DeleteStatus(string name)
        {
            Status status=getStatusByName(name);
            StatusBLL.SetInit(status);
            //delete all transitions connected to the status
            TransitionBLL.DeleteTransitions(name);
            statuses.Remove(status);
            

        }

        public static void Reset()
        {
            statuses.Clear();
        }
    }
}

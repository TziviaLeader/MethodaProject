namespace Methoda.Models
{
    //types of statuses. basic type is not display
    [Flags]
    public enum Type { Init=1,Orphan=2,Final=4,Basic=8} 
    public class Status
    {
        public string Name { get; set; }
        public Type Type { get; set; }

        public Status(string name)
        {
            Name = name;

        }
    }
}

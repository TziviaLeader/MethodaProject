namespace Methoda.Models
{
    public class Transition
    {
        public string Name { get; set; }
        public Status FromStatus { get; set; }
        public Status ToStatus { get; set; }

        public Transition(string name,Status fromStatus,Status toStatus)
        {
            Name = name;
            FromStatus = fromStatus;
            ToStatus = toStatus;

        }
    }
}

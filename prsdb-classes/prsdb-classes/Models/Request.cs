namespace prsdb_classes.Models
{
    public class Request
    {
        public int Id { get; set; }
        public Users UserId { get; set; }
        public string RequestNumber { get; set; }
        public string Description { get; set; }
        public string Justification { get; set; }
        public DateOnly DateNeeded { get; set; }
        public string DeliveryMode { get; set; }
        public string Status { get; set; }
        public decimal Total { get; set; }
        public DateTime DateSubmitted { get; set; }
            public string ReasonForRejection { get; set; }

        public Request(int id, Users userId, string requestNumber, string description, string justification, DateOnly dateNeeded, string deliveryMode, string status, decimal total, DateTime dateSubmitted, string reasonForRejection)
        {
            Id = id;
            UserId = userId;
            RequestNumber = requestNumber;
            Description = description;
            Justification = justification;
            DateNeeded = dateNeeded;
            DeliveryMode = deliveryMode;
            Status = status;
            Total = total;
            DateSubmitted = dateSubmitted;
            ReasonForRejection = reasonForRejection;
        }
        public override string ToString()
        {
            return $"{Id}:{UserId}:{RequestNumber}:{Description}:{Justification}:{DateNeeded}:{DeliveryMode}:{Status}:{Total}:{DateSubmitted}:{ReasonForRejection}";
        }
    }
}

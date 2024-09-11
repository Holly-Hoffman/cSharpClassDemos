namespace prsdb_classes.Models
{
    public class LineItem
    {
        public int Id { get; set; }
        public Request RequestId { get; set; }
        public Products ProductId { get; set; }
        public int Quantity { get; set; }

        public LineItem(int id, Request requestId, Products productId, int quantity)
        {
            Id = id;
            RequestId = requestId;
            ProductId = productId;
            Quantity = quantity;

        }
        public override string ToString()
        {
            return $"{Id}:{RequestId}:{ProductId}:{Quantity}";
        }
    }
}

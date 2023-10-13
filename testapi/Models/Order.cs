namespace testapi.Models
{
    public class Order
    {

        public int Id { get; set; }

        public string? OrderClientName;

        public string? OrderProductName;

        public decimal? OrderProductQuantity;

        public string? OrderDate;

    }
}

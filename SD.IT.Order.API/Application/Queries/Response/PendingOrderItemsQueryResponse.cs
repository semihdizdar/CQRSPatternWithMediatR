namespace SD.IT.Order.API.Application.Queries.Response
{
    public class PendingOrderItemsQueryResponse
    {
        public int OrderId { get; set; }
        public int OrderItemId { get; set; }
        public string VariantCode { get; set; }
    }
}

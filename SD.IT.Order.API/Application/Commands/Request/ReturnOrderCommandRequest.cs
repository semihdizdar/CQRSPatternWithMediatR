using MediatR;
using SD.IT.Order.API.Application.Commands.Response;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SD.IT.Order.API.Application.Commands.Request
{
    public class ReturnOrderCommandRequest : IRequest<ReturnOrderCommandResponse>
    {
        [JsonIgnore] public int StoreId { get; set; }
        public string Platform { get; set; }
        public string OrderNumber { get; set; }
        public string ReturnTrackingNumber { get; set; }
        public IEnumerable<ReturnItem> ReturnedItemList { get; set; }
    }

    public class ReturnItem
    {
        public string VariantCode { get; set; }
        public int Quantity { get; set; }
    }
}

using MediatR;
using SD.IT.Order.API.Application.Queries.Response;
using System;
using System.Collections.Generic;

namespace SD.IT.Order.API.Application.Queries.Request
{
    public class PendingOrderItemsQueryRequest : IRequest<List<PendingOrderItemsQueryResponse>>
    {
        public int OrderId { get; set; }
        public string SellerCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}

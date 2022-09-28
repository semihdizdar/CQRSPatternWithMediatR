using MediatR;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using SD.IT.Order.API.Application.Queries.Request;
using SD.IT.Order.API.Application.Queries.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace SD.IT.Order.API.Application.Handlers.QueryHandlers.PendingOrderItems
{
    public class PendingOrderItemsQueryHandler : IRequestHandler<PendingOrderItemsQueryRequest, List<PendingOrderItemsQueryResponse>>
    {

        public Task<List<PendingOrderItemsQueryResponse>> Handle(PendingOrderItemsQueryRequest request, CancellationToken cancellationToken)
        {

            var response = new PendingOrderItemsQueryResponse()
            {
                OrderId = 1,
                OrderItemId = 1111,
                VariantCode = "White"
            };

            var response1 = new PendingOrderItemsQueryResponse()
            {
                OrderId = 2,
                OrderItemId = 10101,
                VariantCode = "Black"
            };

            return Task.FromResult(new List<PendingOrderItemsQueryResponse> { response,response1 });
        }
    }
}

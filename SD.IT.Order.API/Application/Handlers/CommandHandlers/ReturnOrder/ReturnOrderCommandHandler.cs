using MediatR;
using SD.IT.Order.API.Application.Commands.Request;
using SD.IT.Order.API.Application.Commands.Response;
using System.Threading;
using System.Threading.Tasks;

namespace SD.IT.Order.API.Application.Handlers.CommandHandlers.ReturnOrder
{
    public class ReturnOrderCommandHandler : IRequestHandler<ReturnOrderCommandRequest, ReturnOrderCommandResponse>
    {
        public async Task<ReturnOrderCommandResponse> Handle(ReturnOrderCommandRequest request, CancellationToken cancellationToken)
        {
            ReturnOrderCommandResponse response = new ReturnOrderCommandResponse();

            // response = _orderService.Cancel(request); 

            return response;
        }
    }
}

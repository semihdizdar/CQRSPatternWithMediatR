using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SD.IT.Order.API.Application.Commands.Request;
using SD.IT.Order.API.Application.Queries.Request;
using System.Threading.Tasks;

namespace SD.IT.Order.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediatR;
        public OrderController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromBody] PendingOrderItemsQueryRequest request)
        {
            var response = await _mediatR.Send(request);
            return Ok(response);
        }

        [HttpPost("return/{storeId:int}")]
        public async Task<IActionResult> Post(int storeId, [FromBody] ReturnOrderCommandRequest request)
        {
            request.StoreId = storeId;
            var response = await _mediatR.Send(request);
            return Ok(response);
        }


    }
}

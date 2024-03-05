using CarBookApplication.Features.Mediator.Commands.FooterAddressComands;
using CarBookApplication.Features.Mediator.Queries.FooterAddressQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FooterAdressesController : ControllerBase
    {
        private readonly IMediator _meaditor;

        public FooterAdressesController(IMediator meaditor)
        {
            _meaditor = meaditor;
        }
        [HttpGet]
        public async Task<IActionResult> FooterAddressList()
        {
            var values = await _meaditor.Send(new GetFooterAddressQuery());
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateFooterAddress(CreateFooterAddressCommand command)
        {
            await _meaditor.Send(command);
            return Ok("Footer eklendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFooterAddress(int id)
        {
            var value = await _meaditor.Send(new GetFooterAddresByIdQuery(id));
            return Ok(value);
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveFooterAddress(int id)
        {
            await _meaditor.Send(new RemoveFooterAddressCommand(id));
            return Ok("Footer silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateFooterAddress(UpdateFooterAddressCommand command)
        {
            await _meaditor.Send(command);
            return Ok("Footer güncellendi");
        }
    }
}

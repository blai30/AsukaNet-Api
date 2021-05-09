﻿using System.Threading;
using System.Threading.Tasks;
using AsukaApi.Infrastructure.Features.Tags;
using Microsoft.AspNetCore.Mvc;

namespace AsukaApi.Controllers
{
    public class TagsController : ApiControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAsync([FromQuery] Get.Query query, CancellationToken cancellationToken)
        {
            var response = await Mediator.Send(query, cancellationToken);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateAsync([FromBody] Create.Command command, CancellationToken cancellationToken)
        {
            var response = await Mediator.Send(command, cancellationToken);
            return NoContent();
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> EditAsync([FromBody] Edit.Command command, CancellationToken cancellationToken)
        {
            var response = await Mediator.Send(command, cancellationToken);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var response = await Mediator.Send(new Delete.Command(id));
            return NoContent();
        }
    }
}

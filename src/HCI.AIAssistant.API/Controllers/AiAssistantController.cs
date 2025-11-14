using Microsoft.AspNetCore.Mvc;

using HCI.AIAssistant.API.Models.DTOs.AiAssistantController;

namespace Unitbv.Assistant.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AIAssistantController : ControllerBase
{
    [HttpPost("/message")]
    public async Task<ActionResult<AiAssistantControllerPostMessageResponseDTO>> PostMessage([FromBody] AiAssistantControllerPostMessageRequestDTO request)
    {
        AiAssistantControllerPostMessageResponseDTO response = new()
        {
            TextMessage = "HI!" + request.TextMessage
        };

        return Ok(response);
    }
}
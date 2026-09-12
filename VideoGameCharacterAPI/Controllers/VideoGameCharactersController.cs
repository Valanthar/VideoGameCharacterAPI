using Microsoft.AspNetCore.Mvc;
using VideoGameCharacterAPI.DTOs;
using VideoGameCharacterAPI.Models;
using VideoGameCharacterAPI.Services;

namespace VideoGameCharacterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameCharactersController(IVideoGameCharacterService service): ControllerBase
    {
         
        [HttpGet]
        public async Task<ActionResult<List<GetCharacterResponseDTO>>> GetCharacters()
          => Ok(await service.GetAllCharacterAsync());

        [HttpGet("{id}")]

        public async Task<ActionResult<GetCharacterResponseDTO>> GetCharacter(int id)
        {
            var character = await service.GetCharacterByIdAsync(id);
            return character is null ? NotFound("  Characters with the given Id was not found.") : Ok(character);
        }

    }
}
 
 
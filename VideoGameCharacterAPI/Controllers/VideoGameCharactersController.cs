using Microsoft.AspNetCore.Mvc;
using VideoGameCharacterAPI.Models;
using VideoGameCharacterAPI.Services;

namespace VideoGameCharacterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameCharactersController(IVideoGameCharacterService service): ControllerBase
    {
         
        [HttpGet]
        public async Task<ActionResult<List<Character>>> GetCharacters()
          => Ok(await service.GetCharactersAsync());

        [HttpGet("{id}")]

        public async Task<ActionResult<Character>> GetCharacter(int id)
        {
            var character = await service.GetCharacterByIdAsync(id);
            return character is null ? NotFound("  Characters with the given Id was not found.") : Ok(character);
        }

    }
}
 
 
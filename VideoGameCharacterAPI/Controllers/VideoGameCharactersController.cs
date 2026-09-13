using Microsoft.AspNetCore.Mvc;
using VideoGameCharacterAPI.DTOs;
using VideoGameCharacterAPI.Models;
using VideoGameCharacterAPI.Services;

namespace VideoGameCharacterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameCharactersController(IVideoGameCharacterService service) : ControllerBase
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

        [HttpPost]

        public async Task<ActionResult<GetCharacterResponseDTO>> AddCharacter(CreateCharacterRequestDTO character)
        {
            var newCharacter = await service.AddCharacterAsync(character);
            return CreatedAtAction(nameof(GetCharacter), new { id = newCharacter.Id }, newCharacter);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCharacter(int id, UpdateCharacterRequestDTO character)
        {
            var isUpdated = await service.UpdateCharacterAsync(id, character);
            return isUpdated ? NoContent() : NotFound("Character with the given Id was not found.");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCharacter(int id)
        {
            var isDeleted = await service.DeleteCharacterAsync(id);
            return isDeleted ? NoContent() : NotFound("Character with the given Id was not found.");
        }

    }
}   
 
  
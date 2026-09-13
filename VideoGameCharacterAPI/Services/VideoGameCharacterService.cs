using Microsoft.EntityFrameworkCore;    
using ModelContextProtocol.Protocol;
using VideoGameCharacterAPI.Data;
using VideoGameCharacterAPI.DTOs;
using VideoGameCharacterAPI.Models;

namespace VideoGameCharacterAPI.Services
{
    public class VideoGameCharacterService(AppDbContext context) : IVideoGameCharacterService
    {

        public async Task<GetCharacterResponseDTO> AddCharacterAsync(CreateCharacterRequestDTO character)
        {
            var newCharacter = new Character
            {
                Name = character.Name,
                Game = character.Game,
                Role = character.Role
            };
            context.Characters.Add(newCharacter);
            await context.SaveChangesAsync();
            return new GetCharacterResponseDTO
            {
                Id = newCharacter.Id,
                Name = newCharacter.Name,
                Game = newCharacter.Game,
                Role = newCharacter.Role
            };
        }

        public async Task<bool> DeleteCharacterAsync(int id)
        {
            var CharacterToDelete= await context.Characters.FindAsync(id);
            if (CharacterToDelete is null)
                return false;

            context.Characters.Remove(CharacterToDelete);
            await context.SaveChangesAsync();

            return true;
        }
        public async Task<List<GetCharacterResponseDTO>> GetAllCharacterAsync()
                => await context.Characters.Select(c => new GetCharacterResponseDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                    Game = c.Game,
                    Role = c.Role
                }).ToListAsync();

        public async Task<GetCharacterResponseDTO?> GetCharacterByIdAsync(int id)  
        {
            var result = await context.Characters
                .Where(c => c.Id == id)
                .Select(c => new GetCharacterResponseDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                    Game = c.Game,
                    Role = c.Role
                })
                .FirstOrDefaultAsync();

            return result;
        }
      
        public async Task<bool> UpdateCharacterAsync(int id, UpdateCharacterRequestDTO character)
        {
            var existingCharacter = await context.Characters.FindAsync(id);
            if (existingCharacter is null)
                return false;

            existingCharacter.Name = character.Name;
            existingCharacter.Game = character.Game;
            existingCharacter.Role = character.Role;

            await context.SaveChangesAsync();

            return true;
        }
    }
}

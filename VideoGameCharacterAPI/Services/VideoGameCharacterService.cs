using Microsoft.EntityFrameworkCore;    
using ModelContextProtocol.Protocol;
using VideoGameCharacterAPI.Data;
using VideoGameCharacterAPI.DTOs;
using VideoGameCharacterAPI.Models;

namespace VideoGameCharacterAPI.Services
{
    public class VideoGameCharacterService(AppDbContext context) : IVideoGameCharacterService
    {

        public Task<GetCharacterResponseDTO> AddCharacterAsync(Character character)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCharacterAsync(int id)
        { 
            throw new NotImplementedException();
        }
        public async Task<List<GetCharacterResponseDTO>> GetAllCharacterAsync()
    => await context.Characters.Select(c => new GetCharacterResponseDTO
    {
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
                    Name = c.Name,
                    Game = c.Game,
                    Role = c.Role
                })
                .FirstOrDefaultAsync();

            return result;
        }
      
        public Task<bool> UpdateCharacterAsync(int id, Character character)
        { 
            throw new NotImplementedException();
        }
    }
}

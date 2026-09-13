using VideoGameCharacterAPI.DTOs;
using VideoGameCharacterAPI.Models;

namespace VideoGameCharacterAPI.Services
{
    public interface IVideoGameCharacterService
    {
        Task<List<GetCharacterResponseDTO>> GetAllCharacterAsync();
        Task<GetCharacterResponseDTO?> GetCharacterByIdAsync(int id);
        Task<GetCharacterResponseDTO> AddCharacterAsync(CreateCharacterRequestDTO character);
        Task<bool> UpdateCharacterAsync(int id, UpdateCharacterRequestDTO character);
        Task<bool> DeleteCharacterAsync(int id);
        
    }
}
 
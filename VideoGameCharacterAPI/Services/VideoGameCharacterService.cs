using VideoGameCharacterAPI.Models;

namespace VideoGameCharacterAPI.Services
{
    public class VideoGameCharacterService : IVideoGameCharacterService
    {
        static List<Character> characters = new List<Character>
        {
            new Character { Id = 1, Name = "Mario", Game = "Super Mario Bros.", Role = "Plumber" },
            new Character { Id = 2, Name = "Soap", Game = "Call of Duty", Role = "Private" },
            new Character { Id = 3, Name = "Bowser", Game = "Super Mario Bros.", Role = "Villain" },
            new Character { Id = 4, Name = "Illidan", Game = "World of Warcraft", Role = "Based" },
        };

        public Task<Character> AddCharacterAsync(Character character)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCharacterAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Character?> GetCharacterByIdAsync(int id)
        {
            var result = characters.FirstOrDefault(c => c.Id == id);
            return await Task.FromResult(result);
        }
         
        public async Task<List<Character>> GetCharactersAsync()
        => await Task.FromResult(characters);

        public Task<bool> UpdateCharacterAsync(int id, Character character)
        { 
            throw new NotImplementedException();
        }
    }
}

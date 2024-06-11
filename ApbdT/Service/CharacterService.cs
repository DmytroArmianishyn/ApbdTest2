    using ApbdT.Data;
    using ApbdT.Dto;
    using ApbdT.Models;
    using Microsoft.EntityFrameworkCore;

    namespace ApbdT.Service;

    public class CharacterService
    {
        private readonly MyContext _context;
        public CharacterService(MyContext context)
        {
            _context = context;
        }
        public async Task<Character> GetCharacter(int id)
        {
            return await _context.Characters
                .Include(e=>e.Backpacks)
                .ThenInclude(e=>e.Item)
                .FirstOrDefaultAsync(ch => ch.id == id);
        }

        public async Task<bool> DoesItemExist(int id)
        {
            return await _context.Items.AnyAsync(e => e.id == id);
        }

        public async Task AddItem(IEnumerable<DtoAddBackPack> addBackPacks)
        {
            await _context.AddRangeAsync(addBackPacks);
            await _context.SaveChangesAsync();
            
        }

       
              
        
        
    }
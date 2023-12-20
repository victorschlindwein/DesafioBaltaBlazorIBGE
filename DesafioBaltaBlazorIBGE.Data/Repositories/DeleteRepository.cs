using DesafioBaltaBlazorIBGE.Application.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DesafioBaltaBlazorIBGE.Data.Repositories
{
    public class DeleteRepository : IDeleteRepository
    {
        private readonly ApplicationDbContext _context;

        public DeleteRepository(ApplicationDbContext context)
            => _context = context;

        public async Task<bool> Delete(int id)
        {
            var data = await _context.Ibges.FirstOrDefaultAsync(x => x.Id == id);
            if (data == null)
                return false;

            _context.Ibges.Remove(data);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}

using DesafioBaltaBlazorIBGE.Application.InterfaceRepositories;
using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Data.Repositories
{
    public class CreateIbgeAsyncRepository : ICreateIbgeAsyncRepository
    {
        private readonly ApplicationDbContext _context;
        public CreateIbgeAsyncRepository(ApplicationDbContext context)
            => _context = context;

        public async Task<Ibge> CreateIbgeAsync(Ibge ibge)
        {
            await _context.AddAsync(ibge);
            await _context.SaveChangesAsync();

            return ibge;
        }

    }
}

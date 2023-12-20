using DesafioBaltaBlazorIBGE.Application.InterfaceRepositories;
using DesafioBaltaBlazorIBGE.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioBaltaBlazorIBGE.Data.Repositories
{
    public class GetAllIbgeAsyncRepository : IGetAllIbgeAsyncRepository
    {
        private readonly ApplicationDbContext _context;

        public GetAllIbgeAsyncRepository(ApplicationDbContext context)
            => _context = context;

        public async Task<List<Ibge>> GetAllIbgeAsync(CancellationToken cancellationToken, int skip = 0, int take = 25)
        {
            var ibges = await _context.Ibges.Skip(skip).Take(take).ToListAsync(cancellationToken);
            return ibges;
        }

        public async Task<int> GetTotalItemCountAsync(CancellationToken cancellationToken)
        {
            return await _context.Ibges.CountAsync(cancellationToken);
        }
    }
}

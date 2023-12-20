using DesafioBaltaBlazorIBGE.Application.InterfaceRepositories;
using DesafioBaltaBlazorIBGE.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioBaltaBlazorIBGE.Data.Repositories
{
    public class GetByIdAsyncRepository : IGetByIdAsyncRepository
    {
        private readonly ApplicationDbContext _context;

        public GetByIdAsyncRepository(ApplicationDbContext context)
            => _context = context;

        public async Task<Ibge> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            var data = await _context.Ibges.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            return data;
        }
    }
}

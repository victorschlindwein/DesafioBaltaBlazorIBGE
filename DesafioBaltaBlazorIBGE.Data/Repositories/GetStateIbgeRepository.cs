using DesafioBaltaBlazorIBGE.Application.InterfaceRepositories;
using DesafioBaltaBlazorIBGE.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioBaltaBlazorIBGE.Data.Repositories
{
    public class GetStateIbgeRepository : IGetStateIbgeRepository
    {
        private readonly ApplicationDbContext _context;

        public GetStateIbgeRepository(ApplicationDbContext context)
            => _context = context;

        public async Task<List<Ibge>> GetStateIbge(string state, CancellationToken cancellationToken, int skip = 0, int take = 25)
        {
            if (state == "")
            {
                return new List<Ibge>();
            }
            var stateIbgeList = await _context.Ibges.Where(x => x.State.Contains(state)).Skip(skip).Take(take).ToListAsync(cancellationToken);
            return stateIbgeList;
        }

        public async Task<int> GetTotalStateCountAsync(string state, CancellationToken cancellationToken)
        {
            return await _context.Ibges.Where(x => x.State.Contains(state)).CountAsync(cancellationToken);
        }
    }
}

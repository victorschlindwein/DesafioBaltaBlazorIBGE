using DesafioBaltaBlazorIBGE.Application.InterfaceRepositories;
using DesafioBaltaBlazorIBGE.Domain.Models;

namespace DesafioBaltaBlazorIBGE.Data.Repositories
{
    public class UpdateIbgeRepository : IUpdateIbgeRepository
    {
        private readonly ApplicationDbContext _context;

        public UpdateIbgeRepository(ApplicationDbContext context)
            => _context = context;

        public async Task<Ibge> UpdateIbge(int id, Ibge ibge)
        {
            var data = await _context.Ibges.FindAsync(id);

            if (data == null)
                return null;

            data.City = ibge.City;
            data.State = ibge.State;

            _context.Update(data);
            await _context.SaveChangesAsync();

            return data;
        }
    }
}

using DesafioBaltaBlazorIBGE.Application.InterfaceRepositories;
using DesafioBaltaBlazorIBGE.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioBaltaBlazorIBGE.Data.Repositories
{
    public class GetCityIbgeRepository : IGetCityIbgeRepository
    {
        private readonly ApplicationDbContext _context;

        public GetCityIbgeRepository(ApplicationDbContext context)
            => _context = context;

        public async Task<List<Ibge>> GetCityIbge(string city, CancellationToken cancellationToken, int skip = 0, int take = 25)
        {
            if (city == "")
            {
                return new List<Ibge>();
            }
            var cityIbgeList = await _context.Ibges.Where(x => x.City.Contains(city)).Skip(skip).Take(take).ToListAsync(cancellationToken);
            return cityIbgeList;
        }

        public async Task<int> GetTotalCityCountAsync(string city, CancellationToken cancellationToken)
        {
            return await _context.Ibges.Where(x => x.City.Contains(city)).CountAsync(cancellationToken);
        }
    }
}

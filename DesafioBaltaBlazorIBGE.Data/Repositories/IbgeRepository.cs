using System.Security.Cryptography.X509Certificates;
using DesafioBaltaBlazorIBGE.Domain.Models;
using DesafioBaltaBlazorIBGE.Application.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace DesafioBaltaBlazorIBGE.Data.Repositories
{
    public class IbgeRepository : IIbgeRepository
    {
        private readonly ApplicationDbContext _context;

        public IbgeRepository(ApplicationDbContext context)
            => _context = context;

        public async Task<Ibge> CreateIbgeAsync(Ibge ibge)
        {
            await _context.AddAsync(ibge);
            await _context.SaveChangesAsync();

            return ibge;
        }
        
        public async Task<List<Ibge>> GetAllIbgeAsync(CancellationToken cancellationToken, int skip = 0, int take = 25)
        {
            var ibges = await _context.Ibges.Skip(skip).Take(take).ToListAsync(cancellationToken);
            return ibges;
        }

        public async Task<int> GetTotalItemCountAsync(CancellationToken cancellationToken)
        {
            return await _context.Ibges.CountAsync(cancellationToken);
        }

        public async Task<Ibge> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            var data = await _context.Ibges.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            return data;
        }

        public async Task<List<Ibge>> GetCityIbge(string city, CancellationToken cancellationToken, int skip = 0, int take = 25)
        {
            var cityIbgeList = await _context.Ibges.Where(x => x.City.Contains(city)).Skip(skip).Take(take).ToListAsync(cancellationToken);
            return cityIbgeList;
        }

        public async Task<int> GetTotalCityCountAsync(string city, CancellationToken cancellationToken)
        {
            return await _context.Ibges.Where(x => x.City.Contains(city)).CountAsync(cancellationToken);
        }

        public async Task<List<Ibge>> GetStateIbge(string state, CancellationToken cancellationToken, int skip = 0, int take = 25)
        {
            var stateIbgeList = await _context.Ibges.Where(x => x.State.Contains(state)).Skip(skip).Take(take).ToListAsync(cancellationToken);
            return stateIbgeList;
        }

        public async Task<int> GetTotalStateCountAsync(string state, CancellationToken cancellationToken)
        {
            return await _context.Ibges.Where(x => x.State.Contains(state)).CountAsync(cancellationToken);
        }



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

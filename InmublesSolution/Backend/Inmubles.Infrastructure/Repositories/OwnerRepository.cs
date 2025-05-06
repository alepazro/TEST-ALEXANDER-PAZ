using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inmubles.Domain.Entities;
using Inmubles.Domain.Interfaces;
using MongoDB.Driver;
using Microsoft.Extensions.Options;


namespace Inmubles.Infrastructure.Repositories
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly IMongoCollection<Owner> _collection;

        public OwnerRepository(IOptions<MongoDbSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            var database = client.GetDatabase(settings.Value.DatabaseName);
            _collection = database.GetCollection<Owner>("Owner");
        }

        public async Task<List<Owner>> GetAllOwnersAsync() =>
            await _collection.Find(_ => true).ToListAsync();

        public async Task<Owner?> GetOwnerByIdAsync(int id) =>
            await _collection.Find(o => o.IdOwner == id).FirstOrDefaultAsync();
    }
}

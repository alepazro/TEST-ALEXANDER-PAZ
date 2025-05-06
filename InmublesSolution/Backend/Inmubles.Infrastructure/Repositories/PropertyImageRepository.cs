using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inmubles.Domain.Entities;
using Inmubles.Domain.Interfaces;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Inmubles.Infrastructure.Repositories
{
    public class PropertyImageRepository : IPropertyImageRepository
    {
        private readonly IMongoCollection<PropertyImage> _collection;

        public PropertyImageRepository(IOptions<MongoDbSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            var database = client.GetDatabase(settings.Value.DatabaseName);
            _collection = database.GetCollection<PropertyImage>("PropertyImage");
        }

        public async Task<List<PropertyImage>> GetAllPropertyImageAsync() =>
            await _collection.Find(_ => true).ToListAsync();

        public async Task<PropertyImage?> GetPropertyImageByIdAsync(int id) =>
            await _collection.Find(o => o.IdPropertyImage == id).FirstOrDefaultAsync();
    }
}

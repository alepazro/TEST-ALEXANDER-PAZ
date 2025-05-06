using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inmubles.Domain.Entities;
using Inmubles.Domain.Interfaces;
using MongoDB.Driver;
using Microsoft.Extensions.Options;
using Inmubles.Domain.ModelsResult;
using Inmubles.Infrastructure.Models;
using MongoDB.Bson;


namespace Inmubles.Infrastructure.Repositories
{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly IMongoCollection<Property> _collectionPropertys;
        private readonly IMongoCollection<PropertyImage> _collectionImages;

        public PropertyRepository(IOptions<MongoDbSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            var database = client.GetDatabase(settings.Value.DatabaseName);
            _collectionPropertys = database.GetCollection<Property>("Property");
            _collectionImages = database.GetCollection<PropertyImage>("PropertyImage");
        }
       

        public async Task<List<Property>> GetAllPropertysAsync() =>
            await _collectionPropertys.Find(_ => true).ToListAsync();

        public async Task<Property?> GetPropertyByIdAsync(int id) =>
            await _collectionPropertys.Find(o => o.IdProperty == id).FirstOrDefaultAsync();

        public async Task<List<PropertyWithImagesResult?>> GetAllPropertiesWithImagesAsync()
        {
            var result = await _collectionPropertys
                                .Aggregate()
                                .Lookup<Property, PropertyImage, PropertyWithImagesResult>(
                                    foreignCollection: _collectionImages,
                                    localField: p => p.IdProperty,
                                    foreignField: i => i.IdProperty,
                                    @as: dto => dto.Images)
                                .ToListAsync();

            return result;
        }


    }
}

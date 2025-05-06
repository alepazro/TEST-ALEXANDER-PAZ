using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inmubles.Domain.Entities;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Inmubles.Domain.ModelsResult
{
    public class PropertyWithImagesResult
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public int IdProperty { get; set; }
        public int IdOwner { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string CodeInternal { get; set; }
        public int Year { get; set; }        
        public double Price { get; set; }
        public List<PropertyImage> Images { get; set; } // Imágenes relacionadas
    }
}

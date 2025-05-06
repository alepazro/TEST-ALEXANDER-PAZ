using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Inmubles.Domain.Entities
{
    public class PropertyImage
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public int IdPropertyImage { get; set; }
        public int IdProperty { get; set; }
        public string File { get; set; } = string.Empty;
        public bool Enable { get; set; }
    }
}

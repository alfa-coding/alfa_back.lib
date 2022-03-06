using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace alfa_back.lib.Infrastructure
{
    public interface IDocument
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        string Id { get; set; }
        
    }
}
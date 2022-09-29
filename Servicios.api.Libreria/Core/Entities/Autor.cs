using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Servicios.api.Libreria.Core.Entities
{
    public class Autor
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("nombre")]
        public string nombre { get; set; }

        [BsonElement("apellido")]
        public string apellido { get; set; }


        [BsonElement("gradoAcademico")]
        public string gradoAcademico { get; set; }
    }
}

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENDAPLUS
{
    public class Usuarios
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("nombre")]
        public string Nombre { get; set; }

        [BsonElement("correo")]
        public string Correo { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }

        [BsonElement("rol")]
        public string Rol { get; set; }

        [BsonElement("Numerodocumento")]
        public int NumeroDocumento { get; set; }
    }
}
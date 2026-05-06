using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENDAPLUS
{   
     public class Invitacion
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        // Relación con Evento
        [BsonElement("idEvento")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string IdEvento { get; set; }

        // Relación con Usuario
        [BsonElement("idInvitado")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string IdInvitado { get; set; }
    }
    
}

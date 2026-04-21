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

        [BsonElement("idEvento")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string IdEvento { get; set; }

        [BsonElement("idInvitado")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string IdInvitado { get; set; }

        [BsonElement("NombreEvento")]
        public string NombreEvento { get; set; }

        [BsonElement("NombreInvitado")]
        public string NombreInvitado { get; set; }
    }
    
}

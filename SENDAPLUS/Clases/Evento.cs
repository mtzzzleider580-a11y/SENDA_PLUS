using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENDAPLUS
{
    
    public class Evento
    {// Id de MongoDB (ObjectId)
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("nombreEvento")]
        public string NombreEvento { get; set; }

        [BsonElement("tipoEvento")]
        public string TipoEvento { get; set; }

        [BsonElement("fecha")]
        public DateTime Fecha { get; set; }

        [BsonElement("hora")]
        public string Hora { get; set; }

        [BsonElement("lugar")]
        public string Lugar { get; set; }

        [BsonElement("estado")]
        public string Estado { get; set; }
    }
    
}

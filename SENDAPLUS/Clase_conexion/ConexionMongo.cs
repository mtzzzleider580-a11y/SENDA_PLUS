using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver; // Importa el espacio de nombres para MongoDB.Driver sirve llamar a las clases necesarias para conectarse a MongoDB y realizar operaciones en la base de datos
using MongoDB.Bson; // Importa el espacio de nombres para MongoDB.Bson sirve para trabajar con documentos BSON
using System.Windows.Forms; // Importa el espacio de nombres para System.Windows.Forms sirve para mostrar mensajes en la interfaz de usuario


namespace SENDAPLUS
{
    internal class ConexionMongo
    {


        public class Conectar
        {
            private readonly IMongoDatabase database;

            public Conectar()
            {

                var client = new MongoClient("mongodb://localhost:27017/");
                database = client.GetDatabase("SENDAPLUS");
            }

            public IMongoCollection<Usuarios> Usuarios()
            {
                return database.GetCollection<Usuarios>("usuarios");
            }

            public IMongoCollection<Evento> Eventos()
            {
                return database.GetCollection<Evento>("eventos");
            }

            public IMongoCollection<Invitacion> Invitacion()
            {
                return database.GetCollection<Invitacion>("invitaciones");
            }
        
        }
    }
}

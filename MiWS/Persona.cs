using System.Runtime.Serialization;

namespace MiWS
{
    [DataContract]
    public class Persona: BaseRespuesta
    {
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public int Edad { get; set; }
        public string Token { get; set; }
    }
    [DataContract]
    public class BaseRespuesta
    {
        [DataMember]
        public int Error { get; set; }
        [DataMember]
        public string Mensaje { get; set; }
        public BaseRespuesta()
        {
            Error = 1;
        }
    }
}
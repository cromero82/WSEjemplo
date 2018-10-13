using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;
using System.Xml.Serialization;

namespace MiWS {
    /// <summary>
    /// Descripción breve de WS_CargaConsumoEstacion
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class WS_CargaConsumoEstacion : System.Web.Services.WebService {
        [WebMethod]
        public string CargaConsumo(string USERTOKEN, string ESTACIONID, string CONSUMOS){
            if (!string.IsNullOrEmpty(USERTOKEN) && !string.IsNullOrEmpty(ESTACIONID) && !string.IsNullOrEmpty(CONSUMOS)) return "Ok";
            return string.Empty;
        }
    }
}

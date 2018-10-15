using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;

namespace MiWS {
    public partial class ClienteEstacion : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Button1_Click(object sender, EventArgs e) {            
            //HttpRequest __rqst = new HttpRequest("", "http://localhost:65488/WS_CargaConsumoEstacion.asmx?op=CargaConsumo", "");
            string URI = "http://localhost:65488/WS_CargaConsumoEstacion.asmx";
            //MemoryStream __mstr = new MemoryStream();
            //Request.Files[0].InputStream
            //byte[] __XML = Encoding.UTF8.GetBytes(
            //string myParameters = string.Format("USERTOKEN={0}&ESTACIONID={1}&CONSUMOSXML={2}",TextBox1.Text, TextBox2.Text,);
            var aList = new List<Persona>();
            aList.Add(new Persona { Edad = 20, Nombre = "Prueba1", Token = TextBox1.Text });
            aList.Add(new Persona { Edad = 30, Nombre = "Prueba2", Token = TextBox1.Text });
            aList.Add(new Persona { Edad = 40, Nombre = "Prueba3", Token = TextBox1.Text });
            var jsonSerialiser = new JavaScriptSerializer();
            var json = jsonSerialiser.Serialize(aList);
            //using (WebClient wc = new WebClient()){
            //    wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            //    wc.Proxy.GetProxy(new Uri(URI));                    //wc.UploadString(URI,)
            //    string HtmlResult = wc.UploadString(URI, "Post", json);
            //}
            WS_CargaConsumoEstacion __servicio = new WS_CargaConsumoEstacion();
            Response.Write(__servicio.CargaConsumo(TextBox1.Text, TextBox2.Text, json));
        }
    }
}
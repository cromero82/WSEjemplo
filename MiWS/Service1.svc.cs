﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MiWS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    [Serializable()]
    public class WSPersonas : IWSPersona {
        //public string GetData(int value)
        //{
        //    return string.Format("You entered: {0}", value);
        //}

        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}
        public Persona ObtenerPersona(string identificacion)
        {
            var persona = new Persona();
            switch (identificacion)
            {
                case "1":
                    persona.Error = 0;
                    persona.Edad = 10;
                    persona.Nombre = "PERSONA 1";
                    break;
                case "2":
                    persona.Error = 0;
                    persona.Edad = 10;
                    persona.Nombre = "PERSONA 1";
                    break;
                default:                    
                    persona.Mensaje = "Persona no encontrada";
                    break;
            }
            return persona;
        }
        public string CargaConsumo(string USERTOKEN, string ESTACIONID, string CONSUMOSXML){
            if(string.IsNullOrEmpty(USERTOKEN) && string.IsNullOrEmpty(ESTACIONID)&&string.IsNullOrEmpty(CONSUMOSXML))return "No se procesó el contenido";

            return string.Empty;
        }
    }
}

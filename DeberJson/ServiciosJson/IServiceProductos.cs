﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using Entidades;

namespace ServiciosJson
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceProductos" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceProductos
    {
        [OperationContract]
        [WebGet(UriTemplate = "ConsultarProductos",
        ResponseFormat = WebMessageFormat.Json,
         RequestFormat = WebMessageFormat.Json)]
        List<ProductoMsg> ConsultarPersonas();
    }
}

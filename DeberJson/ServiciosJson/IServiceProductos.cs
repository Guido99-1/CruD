using System;
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
        [WebInvoke(Method = "GET" ,UriTemplate = "DevolverProductos",
        ResponseFormat = WebMessageFormat.Json,
         RequestFormat = WebMessageFormat.Json)]
       List<ProductoMsg> ConsultarProducto();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "DevolverProductos/{id}",
      ResponseFormat = WebMessageFormat.Json,
       RequestFormat = WebMessageFormat.Json)]
        ProductoMsg BuscarProducto(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Insertar",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json)]
        bool InsertarProducto(ProductoMsg pro);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Actualizar",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json)]
       bool ActualizarProducto(ProductoMsg pro);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "Eliminar",
      ResponseFormat = WebMessageFormat.Json,
      RequestFormat = WebMessageFormat.Json)]
        bool EliminarProducto(ProductoMsg pro);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Datos;
using Entidades;

namespace ServiciosJson
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceProductos" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceProductos.svc o ServiceProductos.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceProductos : IServiceProductos
    {
        public bool ActualizarProducto(ProductoMsg pro)
        {
            return ProductoDatos.ActualizarProducto(pro);
        }

        public ProductoMsg BuscarProducto(string id)
        {
            return ProductoDatos.BuscarProductos(Convert.ToInt32(id));
        }

        public List<ProductoMsg> ConsultarProducto()
        {
            return ProductoDatos.DevolverListadoProductos();

        }

        public bool EliminarProducto(ProductoMsg pro)
        {
            return ProductoDatos.EliminarProducto(pro);
        }

        public bool InsertarProducto(ProductoMsg pro)
        {
            return ProductoDatos.InsertarProductos(pro);
        }
    }
}

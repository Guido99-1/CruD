using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
    public class ProductoDatos
    {
        public static List<ProductoMsg> DevolverListadoProductos()
        {
            List<ProductoMsg> listaProductos = new List<ProductoMsg>();
            SqlConnection cn = new SqlConnection(Settings1.Default.ConexionR);
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = @" SELECT 
	                             ProductID
                                ,ProductName
                                ,SupplierID
                                ,CategoryID
                                ,QuantityPerUnit
                                ,UnitPrice
                                ,UnitsInStock
                                FROM Products";
            cmd.CommandType = CommandType.Text;
            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    ProductoMsg producto = new ProductoMsg();
                    producto.ProductID = Convert.ToInt32(dr["ProductID"].ToString());
                    producto.ProductName = dr["ProductName"].ToString();
                    producto.SupplierID = Convert.ToInt32(dr["SupplierID"].ToString());
                    producto.CategoryID = Convert.ToInt32(dr["CategoryID"].ToString());
                    producto.QuantityPerUnit = dr["QuantityPerUnit"].ToString();
                    producto.UnitPrice = Convert.ToDouble(dr["UnitPrice"].ToString());
                    producto.UnitsInStock = Convert.ToInt32(dr["UnitsInStock"].ToString());
                    //cargar a la lista los valores de producto
                    listaProductos.Add(producto);
                }
            }

            cn.Close();
            return listaProductos;
        }
        public static void InsertarProductos(ProductoMsg pro)
        {
            SqlConnection conexion = new SqlConnection(Settings1.Default.ConexionR);
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = @" INSERT INTO[dbo].[Products]
                                                ([ProductName]
                                                    ,[SupplierID]
                                                    ,[CategoryID]
                                                    ,[QuantityPerUnit]
                                                    ,[UnitPrice]
                                                    ,[UnitsInStock]
                                                    )
                                              VALUES
                              (@nombre,@proovedor,@categoria,@cantidad,@precio,@unit);
                               SELECT SCOPE_IDENTITY();";
            cmd.Parameters.AddWithValue("@nombre", pro.ProductName);
            cmd.Parameters.AddWithValue("@proovedor", pro.SupplierID);
            cmd.Parameters.AddWithValue("@categoria", pro.CategoryID);
            cmd.Parameters.AddWithValue("@cantidad", pro.QuantityPerUnit);
            cmd.Parameters.AddWithValue("@precio", pro.UnitPrice);
            cmd.Parameters.AddWithValue("@unit", pro.UnitsInStock);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteScalar();
            conexion.Close();
        }
        public static void ActualizarProducto(ProductoMsg pro)
        {
            SqlConnection conexion = new SqlConnection(Settings1.Default.ConexionR);
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = @"UPDATE [dbo].[Products]
                                   SET [ProductName] = @nombre
                                      ,[SupplierID] = @proovedor
                                      ,[CategoryID] = @categoria
                                      ,[QuantityPerUnit] = @cantidad
                                      ,[UnitPrice] = @precio
                                      ,[UnitsInStock] = @unit
                                 WHERE ProductID = @id";
            cmd.Parameters.AddWithValue("@id", pro.ProductID);
            cmd.Parameters.AddWithValue("@nombre", pro.ProductName);
            cmd.Parameters.AddWithValue("@proovedor", pro.SupplierID);
            cmd.Parameters.AddWithValue("@categoria", pro.CategoryID);
            cmd.Parameters.AddWithValue("@cantidad", pro.QuantityPerUnit);
            cmd.Parameters.AddWithValue("@precio", pro.UnitPrice);
            cmd.Parameters.AddWithValue("@unit", pro.UnitsInStock);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteScalar();
            conexion.Close();
        }
        public static void EliminarProducto(int id)
        {
            SqlConnection conexion = new SqlConnection(Settings1.Default.ConexionR);
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = @"DELETE FROM [dbo].[Products]
                              WHERE  ProductID = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteScalar();
            conexion.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.Data;
using Entidades;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace JsonCruD
{
    public partial class WebFormJson : System.Web.UI.Page
    {
        private string url = "http://localhost:52707/ServiceProductos.svc/";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarDatos();
            }
        }


        protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                ProductoMsg pro = new ProductoMsg();
                pro.ProductID = Convert.ToInt32(GridView2.DataKeys[e.RowIndex].Value.ToString());
                pro.ProductName = ((TextBox)GridView2.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
                pro.SupplierID = Convert.ToInt32(((TextBox)GridView2.Rows[e.RowIndex].Cells[2].Controls[0]).Text);
                pro.CategoryID = Convert.ToInt32(((TextBox)GridView2.Rows[e.RowIndex].Cells[3].Controls[0]).Text);
                pro.QuantityPerUnit = ((TextBox)GridView2.Rows[e.RowIndex].Cells[4].Controls[0]).Text;
                pro.UnitPrice = Convert.ToDecimal(((TextBox)GridView2.Rows[e.RowIndex].Cells[5].Controls[0]).Text);
                pro.UnitsInStock = Convert.ToInt32(((TextBox)GridView2.Rows[e.RowIndex].Cells[6].Controls[0]).Text);
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(ProductoMsg));
                MemoryStream men = new MemoryStream();
                ser.WriteObject(men, pro);
                string data = Encoding.UTF8.GetString(men.ToArray(), 0, (int)men.Length);
                WebClient webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "Actualizar", "PUT", data);
                this.Page.Response.Write("<script language='JavaScript'>alert('El dato se a actulizado correctamente')</script>");
                GridView2.EditIndex = -1;
                CargarDatos();
            }
            catch (System.FormatException sy)
            {
                this.Page.Response.Write("<script language='JavaScript'>alert(' Ingreso de datos incorrectos')</script>");
            }
            catch (Exception)
            {
                    
                throw;
            }
        }

        protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                ProductoMsg pro = new ProductoMsg();
                pro.ProductID = Convert.ToInt32(GridView2.DataKeys[e.RowIndex].Value.ToString());
               
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(ProductoMsg));
                MemoryStream men = new MemoryStream();
                ser.WriteObject(men, pro);
                string data = Encoding.UTF8.GetString(men.ToArray(), 0, (int)men.Length);
                WebClient webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "Eliminar", "DELETE", data);
                this.Page.Response.Write("<script language='JavaScript'>alert('El dato se a eliminado correctamente')</script>");
                GridView2.EditIndex = -1;
                CargarDatos();
            }
            catch (System.FormatException sy)
            {
                this.Page.Response.Write("<script language='JavaScript'>alert(' Ingreso de datos incorrectos')</script>");
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView2.EditIndex = e.NewEditIndex;
            CargarDatos();
        }
        public void CargarDatos()
        {
            string json = (new WebClient()).DownloadString(url + "DevolverProductos");
            GridView2.DataSource = JsonConvert.DeserializeObject<DataTable>(json);
            GridView2.DataBind();
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            GridView gr = GridView2.SelectedRow();
            string id = GridView2.DataKeys[e.RowIndex].Value.ToString();
            string json = (new WebClient()).DownloadString(url + "DevolverProductos/{0}",id);
            GridView2.DataSource = JsonConvert.DeserializeObject<DataTable>(json);
            GridView2.DataBind();
            */
        }

        protected void Button_Agregar_Click(object sender, EventArgs e)
        {
            try
            {

                ProductoMsg pro = new ProductoMsg();
                pro.ProductName = TextBox1.Text;
                pro.SupplierID = Convert.ToInt32(TextBox2.Text);
                pro.CategoryID = Convert.ToInt32(TextBox3.Text);
                pro.QuantityPerUnit = TextBox4.Text;
                pro.UnitPrice = Convert.ToDecimal(TextBox5.Text);
                pro.UnitsInStock = Convert.ToInt32(TextBox6.Text);
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(ProductoMsg));
                MemoryStream men = new MemoryStream();
                ser.WriteObject(men, pro);
                string data = Encoding.UTF8.GetString(men.ToArray(), 0, (int)men.Length);
                WebClient webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "Insertar", "POST", data);
                this.Page.Response.Write("<script language='JavaScript'>alert('El dato se a insertado correctamente')</script>");
                limpiarDatos();
                CargarDatos();
            }
            catch (System.FormatException sy)
            {
                this.Page.Response.Write("<script language='JavaScript'>alert(' Ingreso de datos incorrectos')</script>");
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void limpiarDatos()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
        }

        protected void GridView2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView2.EditIndex = -1;
            CargarDatos();
        }
    }
}
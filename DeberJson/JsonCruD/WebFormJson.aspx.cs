using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.Data;
namespace JsonCruD
{
    public partial class WebFormJson : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 52707/ServiceProductos.svc/DevolverProductos 
            {
                string json = (new WebClient()).DownloadString("http://localhost:52707/ServiceProductos.svc/DevolverProductos");
                GridView2.DataSource = JsonConvert.DeserializeObject<DataTable>(json);
                GridView2.DataBind();
            }
        }
    }
}
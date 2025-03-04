using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp_E3_4955454
{
    public partial class Cookie2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlCategory.SelectedValue = Request.QueryString["ddlCategory"];
            ddlSupplier.SelectedValue = Request.QueryString["ddlSupplier"];
            txtProduct.Text = Request.QueryString["txtProducto"];
            txtDescripcion.Text = Request.QueryString["txtDescripcion"];
            txtImagen.Text = Request.QueryString["txtImagen"];


            Decimal decPrice = Convert.ToDecimal(Request.QueryString["decPrice"]);
            txtPrice.Text = decPrice.ToString("C");

            txtNumberInStock.Text = Request.QueryString["byNumberInStock"];
            txtNumberOnOrder.Text = Request.QueryString["byNumberOnOrder"];
            txtReorderLevel.Text = Request.QueryString["byReorderLevel"];



            Byte byNumberInStock = Convert.ToByte(Request.QueryString["byNumberInStock"]);
            Byte byNumberOnOrder = Convert.ToByte(Request.QueryString["byNumberOnOrder"]);



            Decimal decValueInStock = decPrice * byNumberInStock;
            Decimal decValueOnOrder = decPrice * byNumberOnOrder;
            txtValueInStock.Text = decValueInStock.ToString("c");
            txtValueOnOrder.Text = decValueOnOrder.ToString("c");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
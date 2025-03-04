using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp_E3_4955454
{
    public partial class Cookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            Session["ddlCategory"] = ddlCategory.SelectedValue;
            Session["ddlSupplier"] = ddlSupplier.SelectedValue;
            Session["txtProduct"] = txtProduct.Text;
            Session["txtDescripcion"] = txtDescripcion.Text;
            Session["txtImagen"] = txtImagen.Text;
            Session["txtPrice"] = txtPrice.Text;
            Session["txtNumberInStock"] = txtNumberInStock.Text;
            Session["txtNumberOnOrder"] = txtNumberOnOrder.Text;
            Session["txtReorderLevel"] = txtReorderLevel.Text;

            Response.Redirect("Cookies_Session.aspx");
        }
    }
}
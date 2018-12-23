using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace televizyon_reklam.ckeditor.plugins.simogeo
{
    public partial class Browser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            object kullanici = Session["AdminID"];
            if (kullanici == null)
            {
                Response.Redirect("~/admin/adminlogin.aspx");

            }
            if (!IsPostBack)
            {
                if (Request.QueryString["Klasor"] != null)

                    litScript.Text =
                        string.Format(@"<script type=""text/javascript"" src=""scripts/filemanager-config.ashx?Klasor=/uploads/""></script>",
                        Request.QueryString["Klasor"].ToString());
                else
                    litScript.Text =
                       @"<script type=""text/javascript"" src=""scripts/filemanager-config.ashx?Klasor=/uploads/""></script>";
                    //if (Request.QueryString["Klasor"] != null)

                    //    litScript.Text =
                    //        string.Format(@"<script type=""text/javascript"" src=""scripts/filemanager-config.ashx?Klasor={0}""></script>",
                    //        Request.QueryString["Klasor"].ToString());
                    //else
                    //    litScript.Text =
                    //      @"<script type=""text/javascript"" src=""scripts/filemanager-config.ashx?Klasor=/upload/""></script>";
            }
        }
    }
}
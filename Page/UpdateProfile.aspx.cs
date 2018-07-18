using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Page_UpdateProfile : System.Web.UI.Page
{
    const string fileName = "database.accdb";

    public string Uname;

    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["username"] == null)
        {

            Response.Redirect("../Error/ErrorPage.aspx");
        }
        else {

            Uname = " " + Session["username"];

        }
    }
}
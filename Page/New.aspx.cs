using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Page_New : System.Web.UI.Page
{
    const string fileName = "database.accdb";
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["username"] != null) {
            Response.Redirect("Home.aspx");
        }

        if (Request.Form["submit1"] != null)
        {
            string[] selectQuerys = new string[2];
            selectQuerys[0] = "SELECT * FROM accounts WHERE username = '" + Request.Form["username"] + "'";
            selectQuerys[1] = "SELECT * FROM accounts WHERE email = '" + Request.Form["email"] + "'";
            if (MyAdoHelper.Exist(fileName, selectQuerys[0]) && MyAdoHelper.Exist(fileName, selectQuerys[1]))
            {
                Response.Redirect("../Error/RegError1.aspx");
            }
            if (MyAdoHelper.Exist(fileName, selectQuerys[0]))
            {
                Response.Redirect("../Error/RegError2.aspx");
            }
            else if (MyAdoHelper.Exist(fileName, selectQuerys[1]))
            {
                Response.Redirect("../Error/RegError3.aspx");
            }
            else
            {
                string insertQuery;
                insertQuery = "INSERT INTO accounts";
                insertQuery += " (username, email, region, [password])";
                insertQuery += " VALUES (";
                insertQuery += "'" + Request.Form["username"] + "'";
                insertQuery += ",'" + Request.Form["email"] + "'";
                insertQuery += ",'" + Request.Form["region"] + "'";
                insertQuery += ",'" + Request.Form["password"] + "'";
                insertQuery += ")";
                Session["username"] = Request.Form["username"];
                Session["email"] = Request.Form["email"];
                MyAdoHelper.ExecuteNonQuery(fileName, insertQuery);
                Response.Redirect("../Page/Welcome.aspx");
            }
        }

        if (Request.Form["submit2"] != null)
        {
            string selectquery;
            selectquery = "SELECT * FROM accounts WHERE(username = '" + Request.Form["username0"] + "' AND password = '" + Request.Form["password0"] + "')";

            if (MyAdoHelper.Exist(fileName, selectquery)){
                Session["username"] = Request.Form["username0"];
                Response.Redirect("../Page/Welcome.aspx");

            }
            else {
                Response.Redirect("../Error/ErrorPage.aspx");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Page_Profile : System.Web.UI.Page
{
    public string PHolder1 = "";
    public string PHolder2 = "";
    public string selectQuery;
    
    public string username;
    public string email;
    public string region;
    public string password;
    public int num;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("../Error/ErrorPage.aspx");
        }

        else if (Session["username"] != null)
        {
            string fileName = "database.accdb";
            selectQuery = "SELECT * FROM  accounts";
            DataTable table = MyAdoHelper.ExecuteDataTable(fileName, selectQuery);
            int length = table.Rows.Count;

            for (int i = 0; i < length; i++){

                string User = " " + table.Rows[i]["username"];
                string User1 = " " + Session["username"];

                if (User == User1) {

                    PHolder1 += "<tr>";
                    PHolder1 += "<td><input type='text' name='username' value='" + table.Rows[i]["username"] + "' readonly/></td>";
                    PHolder1 += "<td><input type='text' name='email' value='" + table.Rows[i]["email"] + "' readonly/></td>";
                    PHolder1 += "<td><input type='text' name='region' value='" + table.Rows[i]["region"] + "' readonly/></td>";
                    PHolder1 += "<td><input type='text' name='password' value='" + table.Rows[i]["password"] + "' readonly/></td>";
                    PHolder1 += "<td><button name='edit'>Edit</button></td>";
                    PHolder1 += "</tr>";

                    if (User1 == " Admin")
                    {
                        PHolder1 += "<tr>";
                        PHolder1 += "<td><button name='admin-btn' style='position:absolute; width:1046px;'>Admin</button></td>";
                        PHolder1 += "</tr>";
                    }

                    num = i;
                }
            }

            if (Request.Form["edit"] != null)
            {
                PHolder1 = "";
                PHolder1 += "<tr>";
                PHolder1 += "<td><input type='text' name='username' id='username' value='" + table.Rows[num]["username"] + "' /></td>";
                PHolder1 += "<td><input type='text' name='email' id='email' value='" + table.Rows[num]["email"] + "' /></td>";
                PHolder1 += "<td><input type='text' name='region' id='region' value='" + table.Rows[num]["region"] + "' /></td>";
                PHolder1 += "<td><input type='text' name='password' id='password' value='" + table.Rows[num]["password"] + "' /></td>";
                PHolder1 += "<td><button name='submit' onclick='return SignupValidation2()'>Submit</button></td>";
                PHolder1 += "</tr>";

                PHolder2 += "<br/><br/><br/><h2>Must:</h2>";
                PHolder2 += "<br/><br/><strong><span class='error' id='username-error'>Username length must be between 4 - 12 letters</span></strong><br/><br/>";
                PHolder2 += "<strong><span class='error' id='email-error'>Email must containt only 1 '@' </span></strong><br/><br/>";
                PHolder2 += "<strong><span class='error' id='password-error'>Password length must be between 5 - 18 letters</span></strong><br/><br/>";
                PHolder2 += "<strong><span class='error' id='region-error'>Region must be : Europe, North America, South America, Asia, Oceania or South east Asia</span></strong>";
            }

            if (Request.Form["submit"] != null)
            {

                string updateQuery = "UPDATE [accounts] SET ";

                username = Request.Form["username"];
                email = Request.Form["email"];
                region = Request.Form["region"];
                password = Request.Form["password"];

                updateQuery += String.Format("[username] = '{0}', ", username);
                updateQuery += String.Format("[email] = '{0}', ", email);
                updateQuery += String.Format("[region] = '{0}', ", region);
                updateQuery += String.Format("[password] = '{0}', ", password);

                updateQuery = updateQuery.Remove(updateQuery.Length - 2, 2);
                updateQuery += String.Format(" WHERE [username] = '{0}'", username);
                updateQuery += "";
                MyAdoHelper.ExecuteNonQuery(fileName, updateQuery);

                Response.Redirect("../Page/UpdateProfile.aspx");
            }

            if (Request.Form["admin-btn"] != null)
            {
                Response.Redirect("/Page/Admin.aspx");
            }
        }
    }
}
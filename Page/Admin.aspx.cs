using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
public partial class Page_Admin : System.Web.UI.Page
{
    public string PHolder = "";
    public string PHolder1 = "";
    public string Uname;
    public string selectQuery;
    public string username;
    public string email;
    public string region;
    public string password;
    public string rank;

    protected void Page_Load(object sender, EventArgs e)
    {
        if ((string)Session["username"]!="Admin")
        {
            Response.Redirect("../Error/ErrorPage.aspx");
        }

        else if (Session["username"] != null)
        {
            string fileName = "database.accdb";
            selectQuery = "SELECT * FROM  accounts";
            DataTable table = MyAdoHelper.ExecuteDataTable(fileName, selectQuery);
            int length = table.Rows.Count;

            for (int i = 0; i < length; i++)
            {
                if ("" + table.Rows[i]["username"] != "Admin") {
                    PHolder1 = "";
                    PHolder += "<tr>";
                    PHolder += "<td><input type='text' name='Num' value='" + i + "' readonly/></td>";
                    PHolder += "<td><input type='text' name='username' value='" + table.Rows[i]["username"] + "' readonly/></td>";
                    PHolder += "<td><input type='text' name='email' value='" + table.Rows[i]["email"] + "' readonly/></td>";
                    PHolder += "<td><input type='text' name='region' value='" + table.Rows[i]["region"] + "' readonly/></td>";
                    PHolder += "<td><input type='text' name='password' value='" + table.Rows[i]["password"] + "' readonly/></td>";
                    PHolder += "<td><input type='text' name='rank' value='" + table.Rows[i]["rank"] + "' readonly/></td>";
                    PHolder += "<td><button name='edit " + i + "'>Edit</button></td>";
                    PHolder += "<td><button name='remove " + i + "'>Remove</button></td>";
                    PHolder += "</tr>";
                }
            }
              
            for (int i = 0; i < length; i++)
            {
                if (Request.Form["edit " + i + ""] != null)
                {
                    PHolder = "";
                    PHolder += "<tr>";
                    PHolder += "<td><input type='text' name='Num' value='" + i + "' readonly/></td>";
                    PHolder += "<td><input type='text' name='username' id='username' value='" + table.Rows[i]["username"] + "'/></td>";
                    PHolder += "<td><input type='text' name='email' id='email' value='" + table.Rows[i]["email"] + "'/></td>";
                    PHolder += "<td><input type='text' name='region' id='region' value='" + table.Rows[i]["region"] + "'/></td>";
                    PHolder += "<td><input type='text' name='password' id='password' value='" + table.Rows[i]["password"] + "'/></td>";
                    PHolder += "<td><input type='text' name='rank' value='" + table.Rows[i]["rank"] + "'/></td>";
                    PHolder += "<td><button name='submit2' onclick='return SignupValidation2()'>Submit</button></td>";
                    PHolder += "<td><button name='remove'>Remove</button></td>";
                    PHolder += "</tr>";

                    PHolder1 += "<br/><br/><br/><h2>Must:</h2>";
                    PHolder1 += "<br/><br/><strong><span class='error' id='username-error'>Username length must be between 4 - 12 letters</span></strong><br/><br/>";
                    PHolder1 += "<strong><span class='error' id='email-error'>Email must containt only 1 '@' </span></strong><br/><br/>";
                    PHolder1 += "<strong><span class='error' id='password-error'>Password length must be between 5 - 18 letters</span></strong><br/><br/>";
                    PHolder1 += "<strong><span class='error' id='region-error'>Region must be : Europe, North America, South America, Asia, Oceania or South east Asia</span></strong>";
                }
            }

            if (Request.Form["submit2"] != null)
            {

                string updateQuery = "UPDATE [accounts] SET ";

                username = Request.Form["username"];
                email = Request.Form["email"];
                region = Request.Form["region"];
                password = Request.Form["password"];
                rank = Request.Form["rank"];

                updateQuery += String.Format("[username] = '{0}', ", username);
                updateQuery += String.Format("[email] = '{0}', ", email);
                updateQuery += String.Format("[region] = '{0}', ", region);
                updateQuery += String.Format("[password] = '{0}', ", password);
                updateQuery += String.Format("[rank] = '{0}', ", rank);

                updateQuery = updateQuery.Remove(updateQuery.Length - 2, 2);
                updateQuery += String.Format(" WHERE [username] = '{0}'", username);
                updateQuery += "";
                MyAdoHelper.ExecuteNonQuery(fileName, updateQuery);

                Response.Redirect("../Page/Admin.aspx");
            }

            for (int i = 0; i < length; i++)
            {
                selectQuery = "SELECT * FROM  accounts";
                DataTable table1 = MyAdoHelper.ExecuteDataTable(fileName, selectQuery);

                if (Request.Form["remove " + i + ""] != null)
                {
                    string username1 = (string)table1.Rows[i]["username"];
                    string sql12 = "DELETE * FROM accounts WHERE username='" + username1 + "'";
                    MyAdoHelper.ExecuteNonQuery(fileName, sql12);
                    Response.Redirect("../Page/Admin.aspx");
                }
            }

            if (Request.Form["search-btn"] != null)
            {
                string searchKeyword = "'%" + Request.Form["search"] + "%'";
                string searchBy = Request.Form["search"];
                string selectQuery2 = "SELECT * FROM accounts WHERE username LIKE ";
                if (searchBy != null)
                {
                    selectQuery2 += searchKeyword;
                    selectQuery2 += " OR email LIKE ";
                    selectQuery2 += searchKeyword;
                    selectQuery2 += " OR region LIKE ";
                    selectQuery2 += searchKeyword;
                    selectQuery2 += " OR password LIKE ";
                    selectQuery2 += searchKeyword;
                    selectQuery2 += " OR rank LIKE ";
                    selectQuery2 += searchKeyword;

                    PHolder = MyAdoHelper.PrintDB(fileName, selectQuery2); ;
                }
            }
        }
    }
}
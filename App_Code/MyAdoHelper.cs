using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.OleDb;

public class MyAdoHelper
{
    const string dbLocation = "App_Data/";

    public MyAdoHelper()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static OleDbConnection CreateDBConnection(string fileName)
    {
        string path = HttpContext.Current.Server.MapPath(dbLocation) + fileName;
        string conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + path;
        OleDbConnection con = new OleDbConnection(conString);
        return con;
    }

    public static void ExecuteNonQuery(string fileName, string query)
    {
        OleDbConnection con = CreateDBConnection(fileName);
        con.Open();
        OleDbCommand command = new OleDbCommand(query, con);
        command.ExecuteNonQuery();
        command.Dispose();
        con.Close();
    }

    public static bool Exist(string fileName, string query)
    {
        OleDbConnection con = CreateDBConnection(fileName);
        con.Open();
        OleDbCommand command = new OleDbCommand(query, con);
        OleDbDataReader data = command.ExecuteReader();
        bool result = (bool)data.Read();
        con.Close();
        return result;
    }

    public static DataTable ExecuteDataTable(string fileName, string query)
    {
        OleDbConnection con = CreateDBConnection(fileName);
        con.Open();
        OleDbDataAdapter tableAdapter = new OleDbDataAdapter(query, con);
        DataTable dt = new DataTable();
        tableAdapter.Fill(dt);
        return dt;
    }

    public static string PrintDB(string fileName, string query)
    {
        DataTable dt = ExecuteDataTable(fileName, query);

        string htmlFormatTable = "";

        for (int i = 0; i < dt.Rows.Count; i++)
        {

            DataRow row = dt.Rows[i];
            int length = row.ItemArray.Length;
            htmlFormatTable += "<tr>";
            int z = i + 1;
            htmlFormatTable += "<td><input type='text' name='Num' value='" + z + "' readonly/></td>";

            for (int j = 0; j < length; j++)
            {
                object item = row.ItemArray[j];
                htmlFormatTable += "<td>" + "<input type='text' value='" + item.ToString() + "' readonly/>" + "</td>";
            }
            htmlFormatTable += "<td><button>Return</button></td>";
            htmlFormatTable += "<td><button>_</button></td>";
            htmlFormatTable += "</tr>";
        }
        return htmlFormatTable;
    }
}

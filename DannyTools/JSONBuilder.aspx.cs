using DBHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DannyTools
{
    public partial class JSONBuilder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var table = DBTools.getAllEssUser();
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                sb.Append("{name:\"" + table.Rows[i]["姓名"].ToString().Trim() + "\",pic:\"" + table.Rows[i]["url"].ToString().Trim() + "\",dept:\"" + table.Rows[i]["部门"].ToString().Trim() + "\",attend:true},");
            }
            sb.Append("]");
            lblUserList.Text = sb.ToString();
        }
    }
}
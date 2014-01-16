using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace DannyTools
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnProcess_Click(object sender, EventArgs e)
        {
            string code = txtCode.Value;
            string template = txtTemplate.Value;

            var codelist = code.Split('\n');

            StringBuilder result = new StringBuilder();
            if (codelist.Length > 1)
            {
                for (var i = 0; i < codelist.Length; i++)
                {
                    result.Append(template.ToString().Replace("{*}", codelist[i].ToString().Trim()));
                }
            }
            txtResult.Text = result.ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DXWebApplication
{
    public partial class spreadsheetform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ASPxSpreadsheet1.WorkDirectory = Server.MapPath(@"~\App_Data\SampleDocuments");
                var filepath = Path.Combine(ASPxSpreadsheet1.WorkDirectory, "BreakevenAnalysis.xlsx");
                ASPxSpreadsheet1.Open(filepath);

            }
        }
    }
}
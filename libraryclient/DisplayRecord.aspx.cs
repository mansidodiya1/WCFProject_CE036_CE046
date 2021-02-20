using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using libraryclient.ServiceReference1;

namespace libraryclient
{
    public partial class DisplayRecord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            grdRecord.DataSource = client.GetRecords();
            grdRecord.DataBind();
        }
    }
}

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
    public partial class DeleteRecord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindGridData();
            }
        }

        //Bind Grid  
        public void BindGridData()
        {
            DataSet ds = new DataSet();
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            ds = client.GetRecords();
            grdRecord.DataSource = ds;
            grdRecord.DataBind();
        }


        protected void btnDelete_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

            ServiceReference1.Book bk = new ServiceReference1.Book();
            bk.Id = txtSearch.Text.Trim();
            string result = client.DeleteRecords(bk);

            if (result == "Record Deleted Successfully!")
            {
                BindGridData();
                lblSearchResult.Text = "ID: " + txtSearch.Text.Trim() + "Deleted Successfully!";
            }
            else
            {
                lblSearchResult.Text = "ID: " + txtSearch.Text.Trim() + "Not Found!";
            }
        }
    }
}
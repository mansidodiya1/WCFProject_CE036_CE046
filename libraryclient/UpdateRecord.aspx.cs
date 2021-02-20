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
    public partial class UpdateRecord : System.Web.UI.Page
    {
        ServiceReference1.Book bk = new ServiceReference1.Book();
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SetPanel(true, false);
            }
        }


        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                bk.Id = txtSearch.Text.Trim();
                ds = new DataSet();
                ds = client.SearchRecord(bk);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lblId.Text = ds.Tables[0].Rows[0]["Id"].ToString();
                    txtName.Text = ds.Tables[0].Rows[0]["student_name"].ToString();
                    txtSid.Text = ds.Tables[0].Rows[0]["student_id"].ToString();
                    SetPanel(false, true);

                }
                else
                {
                    lblSearchResult.Text = "Please Enter ID !";
                    lblSearchResult.ForeColor = System.Drawing.Color.White;
                }

            }
            else
            {
                lblSearchResult.Text = "Please Enter ID !";
            }
        }

        private void SetPanel(bool pSearch, bool pUpdate)
        {
            panSearch.Visible = pSearch;
            panUpdate.Visible = pUpdate;
        }

        protected void bntReset_Click(object sender, EventArgs e)
        {
            SetPanel(true, false);
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            SetPanel(true, false);
            lblMsg.Text = "";
        }

        protected void bntUpdated_Click(object sender, EventArgs e)
        {
            bk.Id = lblId.Text.Trim();
            bk.student_name = txtName.Text;
            bk.student_id = txtSid.Text;

            string result = client.Updateinfo(bk);
            lblSearchResult.Text = result;
            SetPanel(true, false);
            txtName.Text = "";
            txtSid.Text = "";
            lblId.Text = "";

        }

    }
}
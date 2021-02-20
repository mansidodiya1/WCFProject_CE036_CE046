using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using libraryclient.ServiceReference1;

namespace libraryclient
{
    public partial class AddNewRecord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                txtId.Text = "";
                txtName.Text = "";
                txtSid.Text = "";
                txtBname.Text = "";
                txtAname.Text = "";
                txtprice.Text = "";
                lblMsg.Text = "";
                txtId.Focus();
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //Adding New Records  

            if ((txtId.Text != "") || (txtName.Text != "") || (txtSid.Text != "") || (txtBname.Text != "") || (txtAname.Text != "") || (txtprice.Text != ""))
            {
                try
                {
                    ServiceReference1.Book bk = new ServiceReference1.Book();
                    bk.Id = txtId.Text;
                    bk.student_name = txtName.Text;
                    bk.student_id = txtSid.Text;
                    bk.book_name = txtBname.Text;
                    bk.author_name = txtAname.Text;
                    bk.price = txtprice.Text;


                    ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
                    lblMsg.Text = "ID: " + bk.Id + ", " + client.AddRecord(bk);
                }
                catch (Exception ex)
                {
                    lblMsg.Text = "ID must be unique! ";
                }


            }
            else
            {

                lblMsg.Text = "All fields are mandatory! ";
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }


        }

        protected void bntReset_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtSid.Text = "";
            txtBname.Text = "";
            txtAname.Text = "";
            txtprice.Text = "";
            lblMsg.Text = "";
            txtId.Focus();
        }


    }
}


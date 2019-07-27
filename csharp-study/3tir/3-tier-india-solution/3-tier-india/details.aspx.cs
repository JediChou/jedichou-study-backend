using System;
using BAL;

public partial class Details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack || string.IsNullOrWhiteSpace(Request.QueryString["autoid"])) return;
        ViewState["AutoId"] = Request.QueryString["autoid"];
        var autoid = int.Parse(Request.QueryString["autoid"]);
        ShowDetails(autoid);
    }

    private void ShowDetails(int autoid)
    {
        try
        {
            DetailView1.DataSource = new PersonalBLL().Load(autoid);
            DetailView1.DataBind();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message;
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        if (ViewState["AutoId"] == null)
            return;

        try
        {
            var autoid = int.Parse(ViewState["AutoId"].ToString());
            var result = new PersonalBLL().Delete(autoid);

            if (result > 0)
            {
                lblMessage.Text = "Record deleted successfully !";
                btnDelete.Visible = false;
            }
            else
            {
                lblMessage.Text = "No record affected.";
            }
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message;
        }
    }
}
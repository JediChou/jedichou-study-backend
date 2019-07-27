using System;
using System.Web.UI;
using BAL;

public partial class Update : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack && !string.IsNullOrWhiteSpace(Request.QueryString["autoid"]))
        {
            ViewState["AutoId"] = Request.QueryString["autoid"];
            var autoId = int.Parse(Request.QueryString["autoid"]);
            FillInPersonalDetails(autoId);
        }
        else if (!IsPostBack)
        {
            Response.Redirect("~/Default.aspx", true);
        }
    }

    private void FillInPersonalDetails(int autoId)
    {
        try
        {
            var table = new PersonalBLL().Load(autoId);
            if (table.Rows.Count <= 0) return;
            var row = table.Rows[0];
            txtAge.Text = row["Age"].ToString();
            txtFirstName.Text = row["FirstName"].ToString();
            txtLastName.Text = row["LastName"].ToString();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message;
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (ViewState["AutoId"] == null) return;

        try
        {
            // validate your data, if any
            int age;
            int.TryParse(txtAge.Text, out age);
            var autoId = int.Parse(ViewState["AutoId"].ToString());
            var result = new PersonalBLL().Update(autoId, txtFirstName.Text.Trim(), txtLastName.Text.Trim(), age);
            lblMessage.Text = result > 0 ? "Record update successfuly !" : "No record afftected.";
        }
        catch (Exception ex)
        {
            lblMessage.Text = "Error occured. " + ex.Message;
        }
    }
}
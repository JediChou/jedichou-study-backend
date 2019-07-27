using System;
using BAL;

public partial class Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            LoadRecords();
    }

    private void LoadRecords()
    {
        try
        {
            var table = new PersonalBLL().LoadAll();
            GridView1.DataSource = table;
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message;
        }
    }
}
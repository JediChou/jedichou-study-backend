using System;
using System.Web.UI;
using BAL;

public partial class Insert : Page
{
    protected void Page_Load(object sender, EventArgs e) {}

    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            // Validate your data, if any
            int age;
            int.TryParse(txtAge.Text, out age);
            var result = new PersonalBLL().Insert(txtFirstName.Text.Trim(), txtLastName.Text.Trim(), age);
            lblMessage.Text = result >= 0 ? "Record inserted successfully!" : "No record afftected.";
        }
        catch (Exception ex)
        {
            lblMessage.Text = "Error occured. " + ex.Message;
        }
    }
}
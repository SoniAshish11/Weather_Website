using System;

namespace Weather_Website
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Any page initialization logic can go here
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text;
            string state = txtState.Text;

            // Redirect to another page or process the weather API logic here
            Response.Redirect($"Results.aspx?city={city}&state={state}");
        }
    }
}

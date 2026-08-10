using PostManCloneLibrary;

namespace PostmanCloneUI;

public partial class Dashboard : Form
{
    private readonly ApiAccess api = new();
    public Dashboard()
    {
        InitializeComponent();
    }

    private async void callApi_Click(object sender, EventArgs e)
    {
        //validate the API URL 

        try
        {
            systemStatus.Text = "Calling API ...";

            resultsText.Text = await api.CallApiAsync(apiText.Text);

            systemStatus.Text = "Ready";

        }
        catch (Exception ex)
        {
            resultsText.Text = "Error" + ex.Message;
            systemStatus.Text = "Error";
        }
    }
}

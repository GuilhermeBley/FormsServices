using FormsServices.Client.Services;
using Microsoft.Extensions.Configuration;

namespace FormsServices.Client.Forms;

public partial class Form1 : Form
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ISampleService _sampleService;
    private readonly IConfiguration _configuration;

    public Form1(IConfiguration configuration, IServiceProvider serviceProvider, ISampleService sampleService)
    {
        InitializeComponent();
        
        _serviceProvider = serviceProvider;
        _sampleService = sampleService;
        _configuration = configuration;

        Label1.Text = _configuration.GetConnectionString("Teste");
    }

    private void Button1_Click(object sender, EventArgs e)
    {
        var form = (Form2)_serviceProvider.GetService(typeof(Form2))!;

        if (form is null)
        {
            MessageBox.Show($"Failed in collect service {nameof(Form2)}");
            return;
        }

        form.ShowDialog(this);
    }
}

using FormsServices.Client.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsServices.Client.Forms
{
    public partial class Form2 : Form
    {
        private readonly ISampleService _sampleService;

        public Form2(ISampleService sampleService)
        {
            InitializeComponent();
            _sampleService = sampleService;
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            ListView1.Items.Clear();

            Button1.Enabled = false;

            var numbers = await _sampleService.GetRandomNumbers();

            foreach (string number in numbers.Select(n => n.ToString()))
                ListView1.Items.Add(number);

            Button1.Enabled = true;
        }
    }
}

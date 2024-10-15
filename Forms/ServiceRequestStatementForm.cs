using PROG7312ST10202241.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312ST10202241
{
    public partial class ServiceRequestStatementForm : Form
    {
        private ResourceManager resourceManager;

        public ServiceRequestStatementForm()
        {
            InitializeComponent();
            resourceManager = new ResourceManager("PROG7312ST10202241.Properties.Strings", typeof(Form1).Assembly);
            ApplyLocalization();
        }

        private void ApplyLocalization()
        {
            this.Text = resourceManager.GetString("ServiceRequestStatementTitle");
            button1.Text = resourceManager.GetString("BackToMainMenuBtn");
        }
        public void ChangeLanguage(string cultureName)
        {
            CultureInfo culture = new CultureInfo(cultureName);
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            ApplyLocalization();
        }

        private void backToMainMenuBtn_Click(object sender, EventArgs e)
        {
            ServiceRequestStatementForm formy = new ServiceRequestStatementForm();
            Form1 Form = new Form1();
            Form.Show();
            this.Hide();
            formy.Close();
        }

        private void ServiceRequestStatementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}

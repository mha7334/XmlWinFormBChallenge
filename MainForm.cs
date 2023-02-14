using System.Globalization;
using WebOrderLib;

namespace BoyumChallenge
{
    public partial class BoyumChallenge : Form
    {
        public BoyumChallenge()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Open Xml File";
            openFileDialog.Filter = "XML file (*.xml)|*.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                txtFilePath.Text = filePath;
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializationService service = new();
                var webOrder = service.Process(txtFilePath.Text);

                lblId.Text = webOrder.Id;
                lblCustomer.Text = webOrder.Customer;
                lblDate.Text = webOrder.Date.ToString("dd. MMMM. yyyy");
                lblPrice.Text = webOrder.AveragePrice.ToString("N03", CultureInfo.CreateSpecificCulture("da-DK")); ;
                lblTotal.Text = webOrder.TotalPrice.ToString("N03", CultureInfo.CreateSpecificCulture("da-DK"));

            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
    }
}
using System.Runtime.CompilerServices;

namespace CharlesGrace_GUI_HW8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        /// <summary> Populates all of the read-only text boxes in the form</summary>
        /// <param name="customer"> A Customer object with which you would like to populate the form. </param>
        public void PopulateForm(Customer customer)
        {
            this.IdTextBox.Text = customer.Id;
            this.NameTextBox.Text = customer.Name;
            this.AddressTextBox.Text = customer.Address;
            this.CityTextBox.Text = customer.City;
            this.StateTextBox.Text = customer.State;
            this.ZipTextBox.Text = customer.Zip;
            this.PhoneTextBox.Text = customer.Phone;
            this.EmailTextBox.Text = customer.Email;
        }

        /// <summary> Populates the Form's DataGridView </summary>
        /// <param name="incidents"> An IncidentList with which the DataGridView will be populated. </param>
        public void PopulateDataGridView(IncidentList incidents)
        {
            this.IncidentDataGridView.Rows.Clear();
            this.IncidentDataGridView.ColumnCount = 4;

            this.IncidentDataGridView.Columns[0].Name = "Product";
            this.IncidentDataGridView.Columns[1].Name = "Date Opened";
            this.IncidentDataGridView.Columns[2].Name = "Date Closed";
            this.IncidentDataGridView.Columns[3].Name = "Notes";

            foreach (Incident incident in incidents)
            {
                string[] row = { incident.Product, incident.DateOpened, incident.DateClosed, incident.Title };
                this.IncidentDataGridView.Rows.Add(row);
            }
        }

        /// <summary> Handles the form load event. </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary> Handles the Click event of the Get Customer link label</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void GetCustomerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.CustomerIdTextBox.Text != "0001" && this.CustomerIdTextBox.Text != "0002" &&
                this.CustomerIdTextBox.Text != "0003")
            {
                MessageBox.Show("Invalid Customer ID", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                var customer = Customer.NewInstance(this.CustomerIdTextBox.Text);
                this.PopulateForm(customer);
                var incidents = IncidentList.NewInstance(this.CustomerIdTextBox.Text);
                this.PopulateDataGridView(incidents);
            }
        }
    }
}
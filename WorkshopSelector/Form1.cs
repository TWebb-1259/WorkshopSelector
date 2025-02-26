namespace WorkshopSelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int days,
            registrationFee,
            lodgingFee,
            total;

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            string workshop,
                   location;

            displayDetails.Text = "";

            if (workshopListBox.SelectedIndex != -1)
            {
                workshop = workshopListBox.SelectedItem.ToString();
                                              

                switch (workshop)
                {
                    case "Handling Stress":
                        days = 3;
                        registrationFee = 1000;
                        displayDetails.Text = "Registration: $" + registrationFee.ToString();
                        break;
                    case "Time Management":
                        days = 3;
                        registrationFee = 800;
                        displayDetails.Text = "Registration: $" + registrationFee.ToString();
                        break;
                    case "Supervision Skills":
                        days = 3;
                        registrationFee = 1500;
                        displayDetails.Text = "Registration: $" + registrationFee.ToString();
                        break;
                    case "Negotiation":
                        days = 5;
                        registrationFee = 1300;
                        displayDetails.Text = "Registration: $" + registrationFee.ToString();
                        break;
                    case "How to Interview":
                        days = 1;
                        registrationFee = 500;
                        displayDetails.Text = "Registration: $" + registrationFee.ToString();
                        break;
                }

                if (locationListBox.SelectedIndex != -1)
                {
                    location = locationListBox.SelectedItem.ToString();

                    switch (location)
                    {
                        case "Austin":
                            lodgingFee = 150;
                            displayDetails.Text += "\nLodging: $" + lodgingFee.ToString() + " x " + days.ToString() + " days = $" + (days * lodgingFee).ToString();
                            break;
                        case "Chicago":
                            lodgingFee = 225;
                            displayDetails.Text += "\nLodging: $" + lodgingFee.ToString() + " x " + days.ToString() + " days = $" + (days * lodgingFee).ToString();
                            break;
                        case "Dallas":
                            lodgingFee = 175;
                            displayDetails.Text += "\nLodging: $" + lodgingFee.ToString() + " x " + days.ToString() + " days = $" + (days * lodgingFee).ToString();
                            break;
                        case "Orlando":
                            lodgingFee = 300;
                            displayDetails.Text += "\nLodging: $" + lodgingFee.ToString() + " x " + days.ToString() + " days = $" + (days * lodgingFee).ToString();
                            break;
                        case "Phoenix":
                            lodgingFee = 175;
                            displayDetails.Text += "\nLodging: $" + lodgingFee.ToString() + " x " + days.ToString() + " days = $" + (days * lodgingFee).ToString();
                            break;
                        case "Raleigh":
                            lodgingFee = 150;
                            displayDetails.Text += "\nLodging: $" + lodgingFee.ToString() + " x " + days.ToString() + " days = $" + (days * lodgingFee).ToString();
                            break;
                    }

                    total = days * lodgingFee + registrationFee;
                    displayDetails.Text += "\nTotal: $" + total.ToString();

                }
                else
                {
                    displayDetails.Text = "Select a location";
                }
            }
            else
                {
                displayDetails.Text = "Select a workshop";
                }                      
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

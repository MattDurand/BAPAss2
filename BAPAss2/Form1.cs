using System;
using System.Windows.Forms;

namespace BAPAss2
{
    public partial class Form1 : Form
    {
        // Location Base Prices
        const double cliffsPrice = 55;
        const double kylemorePrice = 50;
        const double bunrattyPrice = 75;
        const double burrenPrice = 45;
        const double connemaraPrice = 75;
        const double belmulletPrice = 99;

        // Departure Time Discounts
        const double sevenAmDiscount = 0.8;
        const double eightAmDiscount = 0.9;
        const double nineAmDiscount = 0.95;
        const double onePmDiscount = 0.75;

        // Hotel Prices
        const double fiveStarHotel = 100;
        const double fourStarHotel = 75;
        const double threeStarHotel = 55;

        // Group pricing discount -7.5%
        const double groupDiscount = 0.925;

        // Variables for calculations of values is individual booking
        double bookingGrandTotal;
        double bookingTicketFee;
        double bookingLunchFee;
        double bookingHotelFee;
        double selectedLocation;
        double selectedTimeDiscount = 1;
        double selectedHotel = 0;
        double lunch;
        int guests = 0;
        double currentGroupDiscount = groupDiscount;

        // Booking Summary Variables
        int bookings = 0;
        double totalRevenue = 0;
        double totalTicketFees = 0;
        double totalLunchFees = 0;
        double totalHotelFees = 0;
        double totalLunches;
        double avgLunch = 0;
        double avgBooking = 0;
        int totalGuests;


        public Form1()
        {
            InitializeComponent();
        }

        // Close the program
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Clear selections
        private void clearBtn_Click(object sender, EventArgs e)
        {
            // Deselect ListBox selections
            locationListBox.SelectedIndex = -1;
            timeListBox.SelectedIndex = -1;

            // Clear number of guests
            guestTextBox.Text = "0";

            // Unchecking Luck CheckBox
            lunchCheckBox.Checked = false;

            // Unchecking Hotel RadioButtons
            fiveStarRadio.Checked = false;
            fourStarRadio.Checked = false;
            threeStarRadio.Checked = false;

        }

        // Display Booking details
        private void displaySummaryBtn_Click(object sender, EventArgs e)
        {


            /* UpDown box for number of guests allows users to either type a number 
               or use arrow keys to increase/decrease number */
            try
            {
                guests = Convert.ToInt32(((UpDownBase)guestTextBox).Text);
                //throw new FormatException("A number must be entered");
            }
            catch (FormatException)
            {
                ((UpDownBase)guestTextBox).Text = "0";
                return;
            }


            // Invalid guest number error handling
            if (guests < 1)
            {
                MessageBox.Show("The value " + ((UpDownBase)guestTextBox).Text + " is out of range. Please enter a whole, positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Apply group discount
            if (guests >= 3)
            {
                currentGroupDiscount = groupDiscount;
            }

            // Setting price based on selected location, with missing input error handling
            switch (locationListBox.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Please select a destination", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                case 0:
                    selectedLocation = cliffsPrice;
                    break;

                case 1:
                    selectedLocation = kylemorePrice;
                    break;

                case 2:
                    selectedLocation = bunrattyPrice;
                    break;

                case 3:
                    selectedLocation = burrenPrice;
                    break;

                case 4:
                    selectedLocation = connemaraPrice;
                    break;

                case 5:
                    selectedLocation = belmulletPrice;
                    break;
            }

            
            // Setting discount based on time selection, with missing input error handling
            switch (timeListBox.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Please select a departure time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                case 0:
                    selectedTimeDiscount = sevenAmDiscount;
                    break;

                case 1:
                    selectedTimeDiscount = eightAmDiscount;
                    break;

                case 2:
                    selectedTimeDiscount = nineAmDiscount;
                    break;

                case 3:

                    break;

                case 4:

                    break;

                case 5:
                    selectedTimeDiscount = onePmDiscount;
                    break;
            }

            // Offer user group discount
            if (guests < 3)
            {
                if (MessageBox.Show("Are you sure you wish to continue? Book for three or more guests and receive 7.5% off your entire booking!", "Validation Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    currentGroupDiscount = 1;
                    // Program will continue
                }
            }

            // Setting cost of hotel if one is selected
            if (fiveStarRadio.Checked == true)
            {
                selectedHotel = fiveStarHotel;
            }
            else if (fourStarRadio.Checked == true)
            {
                selectedHotel = fourStarHotel;
            }
            else if (threeStarRadio.Checked == true)
            {
                selectedHotel = threeStarHotel;
            }
            else if (noHotelRadio.Checked == true)
            {
                selectedHotel = 0;
            }
            else
            {
                throw new System.ArgumentException();
            }




            // Calculating and populating the grand total for the booking
            bookingGrandTotal = (((((selectedLocation * selectedTimeDiscount) + lunch + selectedHotel)) * guests) * currentGroupDiscount);
            grandTotal.Text = "€" + Math.Round(bookingGrandTotal, 2);

            // Calculating and Populating total excursion
            bookingTicketFee = ((selectedLocation * selectedTimeDiscount) * guests);
            ticketTotalBox.Text = "€" + Math.Round(bookingTicketFee, 2);

            // Calculating and populating total cost of lunches
            bookingLunchFee = (lunch * guests);
            lunchTotalBox.Text = "€" + Math.Round(bookingLunchFee, 2);

            // Calculating and populating total cost of hotels
            bookingHotelFee = (selectedHotel * guests);
            hotelTotalBox.Text = "€" + Math.Round(bookingHotelFee, 2);

            // Calculating and populating total ticket discount
            discountTotalBox.Text = "€" + Math.Round(((selectedLocation - (selectedLocation * selectedTimeDiscount)) * guests), 2);

            // Calculating and populating group discount
            grpDiscountBox.Text = "€" + Math.Round((bookingGrandTotal - (bookingGrandTotal * currentGroupDiscount)), 2);

            /* Populates DisplaySummary
               TrimEnd() is used to remove specified characters until an unspecified 
               character is reached so that only the placename is displayed*/
            dispLocationBox.Text = locationListBox.Text.TrimEnd(' ', '|', '€', '0', '4', '5', '7', '9');

            // Replace() is used to replace a specified string with a different one.
            dispTimeBox.Text = timeListBox.Text.Replace("% discount", "");
            dispTimeBox.Text = dispTimeBox.Text.TrimEnd('|', ' ', '0', '1', '2', '5');

            dispGuestBox.Text = guestTextBox.Text;


            // Switches visible Group Boxes
            locationGrpBox.Visible = false;
            timeGrpBox.Visible = false;
            guestsGrpBox.Visible = false;
            lunchGrpBox.Visible = false;
            hotelGrpBox.Visible = false;
            displaySummaryGrpBox.Visible = true;
            ctrlGrpBox.Visible = false;
        }

        //Return to home menu
        private void returnButton_Click(object sender, EventArgs e)
        {
            if (bookButton.Enabled == false)
            {
                bookButton.Enabled = true;
            }
            locationGrpBox.Visible = true;
            timeGrpBox.Visible = true;
            guestsGrpBox.Visible = true;
            lunchGrpBox.Visible = true;
            hotelGrpBox.Visible = true;
            displaySummaryGrpBox.Visible = false;
            ctrlGrpBox.Visible = true;
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            // Disable button to prevent double booking
            bookButton.Enabled = false;

            // Total Bookings
            bookings++;
            if (bookingSummaryBtn.Enabled == false)
            {
                bookingSummaryBtn.Enabled = true;
            }
            totalBookingBox.Text = bookings.ToString();

            //Total Revenue
            totalRevenue = totalRevenue + bookingGrandTotal;
            totalRevenueBox.Text = "€" + totalRevenue;

            // Total Ticket Fees
            totalTicketFees = totalTicketFees + bookingTicketFee;
            totalTicketFeeBox.Text = "€" + totalTicketFees;

            // Total Hotel Fees
            totalHotelFees = totalHotelFees + bookingHotelFee;
            totalHotelFeeBox.Text = "€" + totalHotelFees;

            // Total guests
            totalGuests = totalGuests + guests;

            // Average lunch fee
            for(int i = 0; i <= totalGuests; i++)
            {
                totalLunches = i;
            }
            avgLunch = Math.Round((totalLunchFees / totalLunches), 2);
            avgLunchBox.Text = "€" + avgLunch;

            // Average Booking
            avgBooking = Math.Round((bookingGrandTotal / bookings), 2);
            avgBookingBox.Text = "€" + avgBooking;

        }

        // Include lunch toggle
        private void lunchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (lunchCheckBox.Checked == true)
            {
                lunch = 11.5;
            }
            else if (lunchCheckBox.Checked == false)
            {
                lunch = 0;
            }
        }

        // Show Booking Summary Page
        private void bookingSummaryBtn_Click(object sender, EventArgs e)
        {
            if (displaySummaryGrpBox.Visible == true)
            {
                displaySummaryGrpBox.Visible = false;
                
            }else if(displaySummaryGrpBox.Visible == false)
            {
                locationGrpBox.Visible = false;
                timeGrpBox.Visible = false;
                guestsGrpBox.Visible = false;
                lunchGrpBox.Visible = false;
                hotelGrpBox.Visible = false;
                bookingSummaryGrpBox.Visible = true;
                ctrlGrpBox.Visible = false;
            }
        }

        // Return to home page
        private void summaryReturnBtn_Click(object sender, EventArgs e)
        {
            locationGrpBox.Visible = true;
            timeGrpBox.Visible = true;
            guestsGrpBox.Visible = true;
            lunchGrpBox.Visible = true;
            hotelGrpBox.Visible = true;
            displaySummaryGrpBox.Visible = false;
            bookingSummaryGrpBox.Visible = false;
            ctrlGrpBox.Visible = true;

            if (bookButton.Enabled == false)
            {
                bookButton.Enabled = true;
            }
        }
    }
}

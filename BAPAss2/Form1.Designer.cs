namespace BAPAss2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.locationGrpBox = new System.Windows.Forms.GroupBox();
            this.locationListBox = new System.Windows.Forms.ListBox();
            this.timeGrpBox = new System.Windows.Forms.GroupBox();
            this.timeListBox = new System.Windows.Forms.ListBox();
            this.guestsGrpBox = new System.Windows.Forms.GroupBox();
            this.guestTextBox = new System.Windows.Forms.NumericUpDown();
            this.lunchGrpBox = new System.Windows.Forms.GroupBox();
            this.lunchCheckBox = new System.Windows.Forms.CheckBox();
            this.hotelGrpBox = new System.Windows.Forms.GroupBox();
            this.noHotelRadio = new System.Windows.Forms.RadioButton();
            this.threeStarRadio = new System.Windows.Forms.RadioButton();
            this.fourStarRadio = new System.Windows.Forms.RadioButton();
            this.fiveStarRadio = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.displaySummaryBtn = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.bookingSummaryBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.displaySummaryGrpBox = new System.Windows.Forms.GroupBox();
            this.grpDiscountBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.discountTotalBox = new System.Windows.Forms.TextBox();
            this.bookButton = new System.Windows.Forms.Button();
            this.hotelTotalBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lunchTotalBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ticketTotalBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grandTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dispGuestBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dispTimeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dispLocationBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bookingSummaryGrpBox = new System.Windows.Forms.GroupBox();
            this.summaryReturnBtn = new System.Windows.Forms.Button();
            this.avgBookingBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.avgLunchBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.totalHotelFeeBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.totalTicketFeeBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.totalRevenueBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.totalBookingBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ctrlGrpBox = new System.Windows.Forms.GroupBox();
            this.locationGrpBox.SuspendLayout();
            this.timeGrpBox.SuspendLayout();
            this.guestsGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestTextBox)).BeginInit();
            this.lunchGrpBox.SuspendLayout();
            this.hotelGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.displaySummaryGrpBox.SuspendLayout();
            this.bookingSummaryGrpBox.SuspendLayout();
            this.ctrlGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // locationGrpBox
            // 
            this.locationGrpBox.BackColor = System.Drawing.Color.AliceBlue;
            this.locationGrpBox.Controls.Add(this.locationListBox);
            this.locationGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationGrpBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.locationGrpBox.Location = new System.Drawing.Point(20, 171);
            this.locationGrpBox.Name = "locationGrpBox";
            this.locationGrpBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.locationGrpBox.Size = new System.Drawing.Size(179, 114);
            this.locationGrpBox.TabIndex = 1;
            this.locationGrpBox.TabStop = false;
            this.locationGrpBox.Text = "Locations and Base Pricing";
            // 
            // locationListBox
            // 
            this.locationListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationListBox.FormattingEnabled = true;
            this.locationListBox.Items.AddRange(new object[] {
            "Cliffs of Moher  |  €55",
            "Kylemore Abbey  |  €50",
            "Bunratty Castle  |  €75",
            "The Burren  |  €45",
            "Connemara  |  €75",
            "Belmullet  |  €99"});
            this.locationListBox.Location = new System.Drawing.Point(7, 20);
            this.locationListBox.Name = "locationListBox";
            this.locationListBox.Size = new System.Drawing.Size(167, 82);
            this.locationListBox.TabIndex = 0;
            // 
            // timeGrpBox
            // 
            this.timeGrpBox.BackColor = System.Drawing.Color.AliceBlue;
            this.timeGrpBox.Controls.Add(this.timeListBox);
            this.timeGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeGrpBox.Location = new System.Drawing.Point(199, 171);
            this.timeGrpBox.Name = "timeGrpBox";
            this.timeGrpBox.Size = new System.Drawing.Size(189, 114);
            this.timeGrpBox.TabIndex = 2;
            this.timeGrpBox.TabStop = false;
            this.timeGrpBox.Text = "Departure Time";
            // 
            // timeListBox
            // 
            this.timeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeListBox.FormattingEnabled = true;
            this.timeListBox.Items.AddRange(new object[] {
            "7 AM  |  20% discount",
            "8 AM  |  10% discount",
            "9 AM  |  5% discount",
            "10 AM  |  0% discount",
            "11 AM  |  0% discount",
            "1 PM  |  25% discount"});
            this.timeListBox.Location = new System.Drawing.Point(6, 18);
            this.timeListBox.Name = "timeListBox";
            this.timeListBox.Size = new System.Drawing.Size(169, 82);
            this.timeListBox.TabIndex = 3;
            // 
            // guestsGrpBox
            // 
            this.guestsGrpBox.BackColor = System.Drawing.Color.AliceBlue;
            this.guestsGrpBox.Controls.Add(this.guestTextBox);
            this.guestsGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestsGrpBox.Location = new System.Drawing.Point(20, 289);
            this.guestsGrpBox.Name = "guestsGrpBox";
            this.guestsGrpBox.Size = new System.Drawing.Size(180, 51);
            this.guestsGrpBox.TabIndex = 3;
            this.guestsGrpBox.TabStop = false;
            this.guestsGrpBox.Text = "Number of Guests";
            // 
            // guestTextBox
            // 
            this.guestTextBox.Location = new System.Drawing.Point(8, 19);
            this.guestTextBox.Name = "guestTextBox";
            this.guestTextBox.Size = new System.Drawing.Size(167, 20);
            this.guestTextBox.TabIndex = 15;
            // 
            // lunchGrpBox
            // 
            this.lunchGrpBox.BackColor = System.Drawing.Color.AliceBlue;
            this.lunchGrpBox.Controls.Add(this.lunchCheckBox);
            this.lunchGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lunchGrpBox.Location = new System.Drawing.Point(200, 289);
            this.lunchGrpBox.Name = "lunchGrpBox";
            this.lunchGrpBox.Size = new System.Drawing.Size(188, 51);
            this.lunchGrpBox.TabIndex = 4;
            this.lunchGrpBox.TabStop = false;
            this.lunchGrpBox.Text = "Packed Lunch";
            // 
            // lunchCheckBox
            // 
            this.lunchCheckBox.AutoSize = true;
            this.lunchCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lunchCheckBox.Location = new System.Drawing.Point(6, 22);
            this.lunchCheckBox.Name = "lunchCheckBox";
            this.lunchCheckBox.Size = new System.Drawing.Size(112, 17);
            this.lunchCheckBox.TabIndex = 11;
            this.lunchCheckBox.Text = "€11.50 per person";
            this.lunchCheckBox.UseVisualStyleBackColor = true;
            this.lunchCheckBox.CheckedChanged += new System.EventHandler(this.lunchCheckBox_CheckedChanged);
            // 
            // hotelGrpBox
            // 
            this.hotelGrpBox.BackColor = System.Drawing.Color.AliceBlue;
            this.hotelGrpBox.Controls.Add(this.noHotelRadio);
            this.hotelGrpBox.Controls.Add(this.threeStarRadio);
            this.hotelGrpBox.Controls.Add(this.fourStarRadio);
            this.hotelGrpBox.Controls.Add(this.fiveStarRadio);
            this.hotelGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelGrpBox.Location = new System.Drawing.Point(21, 342);
            this.hotelGrpBox.Name = "hotelGrpBox";
            this.hotelGrpBox.Size = new System.Drawing.Size(178, 130);
            this.hotelGrpBox.TabIndex = 5;
            this.hotelGrpBox.TabStop = false;
            this.hotelGrpBox.Text = "Hotel (Optional)";
            // 
            // noHotelRadio
            // 
            this.noHotelRadio.AutoSize = true;
            this.noHotelRadio.Checked = true;
            this.noHotelRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noHotelRadio.Location = new System.Drawing.Point(8, 97);
            this.noHotelRadio.Name = "noHotelRadio";
            this.noHotelRadio.Size = new System.Drawing.Size(67, 17);
            this.noHotelRadio.TabIndex = 4;
            this.noHotelRadio.TabStop = true;
            this.noHotelRadio.Text = "No Hotel";
            this.noHotelRadio.UseVisualStyleBackColor = true;
            // 
            // threeStarRadio
            // 
            this.threeStarRadio.AutoSize = true;
            this.threeStarRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeStarRadio.Location = new System.Drawing.Point(8, 71);
            this.threeStarRadio.Name = "threeStarRadio";
            this.threeStarRadio.Size = new System.Drawing.Size(149, 17);
            this.threeStarRadio.TabIndex = 3;
            this.threeStarRadio.Text = "★★★☆☆ | €55 per person";
            this.threeStarRadio.UseVisualStyleBackColor = true;
            // 
            // fourStarRadio
            // 
            this.fourStarRadio.AutoSize = true;
            this.fourStarRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourStarRadio.Location = new System.Drawing.Point(8, 44);
            this.fourStarRadio.Name = "fourStarRadio";
            this.fourStarRadio.Size = new System.Drawing.Size(149, 17);
            this.fourStarRadio.TabIndex = 2;
            this.fourStarRadio.Text = "★★★★☆ | €75 per person";
            this.fourStarRadio.UseVisualStyleBackColor = true;
            // 
            // fiveStarRadio
            // 
            this.fiveStarRadio.AutoSize = true;
            this.fiveStarRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveStarRadio.Location = new System.Drawing.Point(8, 19);
            this.fiveStarRadio.Name = "fiveStarRadio";
            this.fiveStarRadio.Size = new System.Drawing.Size(155, 17);
            this.fiveStarRadio.TabIndex = 1;
            this.fiveStarRadio.Text = "★★★★★ | €100 per person";
            this.fiveStarRadio.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BAPAss2.Properties.Resources.Screenshot_2020_11_08_UTF_8__Assignment_202_20__202020_21_20V2_1_281_29_pdf1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(20, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 153);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // displaySummaryBtn
            // 
            this.displaySummaryBtn.BackColor = System.Drawing.Color.White;
            this.displaySummaryBtn.Location = new System.Drawing.Point(0, 7);
            this.displaySummaryBtn.Name = "displaySummaryBtn";
            this.displaySummaryBtn.Size = new System.Drawing.Size(89, 44);
            this.displaySummaryBtn.TabIndex = 6;
            this.displaySummaryBtn.Text = "&Display Summary";
            this.displaySummaryBtn.UseVisualStyleBackColor = false;
            this.displaySummaryBtn.Click += new System.EventHandler(this.displaySummaryBtn_Click);
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.White;
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.Location = new System.Drawing.Point(101, 220);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(74, 44);
            this.returnButton.TabIndex = 7;
            this.returnButton.Text = "&Return";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // bookingSummaryBtn
            // 
            this.bookingSummaryBtn.BackColor = System.Drawing.Color.White;
            this.bookingSummaryBtn.Enabled = false;
            this.bookingSummaryBtn.Location = new System.Drawing.Point(92, 7);
            this.bookingSummaryBtn.Name = "bookingSummaryBtn";
            this.bookingSummaryBtn.Size = new System.Drawing.Size(89, 44);
            this.bookingSummaryBtn.TabIndex = 8;
            this.bookingSummaryBtn.Text = "&Booking Summary";
            this.bookingSummaryBtn.UseVisualStyleBackColor = false;
            this.bookingSummaryBtn.Click += new System.EventHandler(this.bookingSummaryBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(0, 52);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(89, 44);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "&Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.White;
            this.exitBtn.ForeColor = System.Drawing.Color.Black;
            this.exitBtn.Location = new System.Drawing.Point(92, 52);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(89, 44);
            this.exitBtn.TabIndex = 10;
            this.exitBtn.Text = "&Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // displaySummaryGrpBox
            // 
            this.displaySummaryGrpBox.BackColor = System.Drawing.Color.AliceBlue;
            this.displaySummaryGrpBox.Controls.Add(this.grpDiscountBox);
            this.displaySummaryGrpBox.Controls.Add(this.label10);
            this.displaySummaryGrpBox.Controls.Add(this.label9);
            this.displaySummaryGrpBox.Controls.Add(this.discountTotalBox);
            this.displaySummaryGrpBox.Controls.Add(this.bookButton);
            this.displaySummaryGrpBox.Controls.Add(this.hotelTotalBox);
            this.displaySummaryGrpBox.Controls.Add(this.label7);
            this.displaySummaryGrpBox.Controls.Add(this.lunchTotalBox);
            this.displaySummaryGrpBox.Controls.Add(this.label6);
            this.displaySummaryGrpBox.Controls.Add(this.ticketTotalBox);
            this.displaySummaryGrpBox.Controls.Add(this.label5);
            this.displaySummaryGrpBox.Controls.Add(this.grandTotal);
            this.displaySummaryGrpBox.Controls.Add(this.label4);
            this.displaySummaryGrpBox.Controls.Add(this.dispGuestBox);
            this.displaySummaryGrpBox.Controls.Add(this.label3);
            this.displaySummaryGrpBox.Controls.Add(this.dispTimeBox);
            this.displaySummaryGrpBox.Controls.Add(this.label2);
            this.displaySummaryGrpBox.Controls.Add(this.dispLocationBox);
            this.displaySummaryGrpBox.Controls.Add(this.label1);
            this.displaySummaryGrpBox.Controls.Add(this.returnButton);
            this.displaySummaryGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displaySummaryGrpBox.Location = new System.Drawing.Point(20, 171);
            this.displaySummaryGrpBox.Name = "displaySummaryGrpBox";
            this.displaySummaryGrpBox.Size = new System.Drawing.Size(368, 308);
            this.displaySummaryGrpBox.TabIndex = 11;
            this.displaySummaryGrpBox.TabStop = false;
            this.displaySummaryGrpBox.Text = "Booking Details";
            this.displaySummaryGrpBox.Visible = false;
            // 
            // grpDiscountBox
            // 
            this.grpDiscountBox.Enabled = false;
            this.grpDiscountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDiscountBox.Location = new System.Drawing.Point(239, 99);
            this.grpDiscountBox.Name = "grpDiscountBox";
            this.grpDiscountBox.Size = new System.Drawing.Size(100, 20);
            this.grpDiscountBox.TabIndex = 25;
            this.grpDiscountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(181, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 26);
            this.label10.TabIndex = 24;
            this.label10.Text = "Group\r\nDiscount:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(181, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Discount:";
            // 
            // discountTotalBox
            // 
            this.discountTotalBox.Enabled = false;
            this.discountTotalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountTotalBox.Location = new System.Drawing.Point(239, 61);
            this.discountTotalBox.Name = "discountTotalBox";
            this.discountTotalBox.Size = new System.Drawing.Size(100, 20);
            this.discountTotalBox.TabIndex = 22;
            this.discountTotalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bookButton
            // 
            this.bookButton.BackColor = System.Drawing.Color.White;
            this.bookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookButton.Location = new System.Drawing.Point(210, 220);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(74, 44);
            this.bookButton.TabIndex = 21;
            this.bookButton.Text = "&Book";
            this.bookButton.UseVisualStyleBackColor = false;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // hotelTotalBox
            // 
            this.hotelTotalBox.Enabled = false;
            this.hotelTotalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelTotalBox.Location = new System.Drawing.Point(75, 113);
            this.hotelTotalBox.Name = "hotelTotalBox";
            this.hotelTotalBox.Size = new System.Drawing.Size(100, 20);
            this.hotelTotalBox.TabIndex = 20;
            this.hotelTotalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Hotels:";
            // 
            // lunchTotalBox
            // 
            this.lunchTotalBox.Enabled = false;
            this.lunchTotalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lunchTotalBox.Location = new System.Drawing.Point(75, 87);
            this.lunchTotalBox.Name = "lunchTotalBox";
            this.lunchTotalBox.Size = new System.Drawing.Size(100, 20);
            this.lunchTotalBox.TabIndex = 18;
            this.lunchTotalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Lunches:";
            // 
            // ticketTotalBox
            // 
            this.ticketTotalBox.Enabled = false;
            this.ticketTotalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketTotalBox.Location = new System.Drawing.Point(75, 61);
            this.ticketTotalBox.Name = "ticketTotalBox";
            this.ticketTotalBox.Size = new System.Drawing.Size(100, 20);
            this.ticketTotalBox.TabIndex = 16;
            this.ticketTotalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Grand Total:";
            // 
            // grandTotal
            // 
            this.grandTotal.Enabled = false;
            this.grandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandTotal.Location = new System.Drawing.Point(184, 153);
            this.grandTotal.Name = "grandTotal";
            this.grandTotal.Size = new System.Drawing.Size(100, 20);
            this.grandTotal.TabIndex = 14;
            this.grandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tickets:";
            // 
            // dispGuestBox
            // 
            this.dispGuestBox.Enabled = false;
            this.dispGuestBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispGuestBox.Location = new System.Drawing.Point(317, 15);
            this.dispGuestBox.Name = "dispGuestBox";
            this.dispGuestBox.Size = new System.Drawing.Size(45, 20);
            this.dispGuestBox.TabIndex = 12;
            this.dispGuestBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Guests:";
            // 
            // dispTimeBox
            // 
            this.dispTimeBox.Enabled = false;
            this.dispTimeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispTimeBox.Location = new System.Drawing.Point(220, 15);
            this.dispTimeBox.Name = "dispTimeBox";
            this.dispTimeBox.Size = new System.Drawing.Size(45, 20);
            this.dispTimeBox.TabIndex = 10;
            this.dispTimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Time:";
            // 
            // dispLocationBox
            // 
            this.dispLocationBox.Enabled = false;
            this.dispLocationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispLocationBox.Location = new System.Drawing.Point(75, 15);
            this.dispLocationBox.Name = "dispLocationBox";
            this.dispLocationBox.Size = new System.Drawing.Size(100, 20);
            this.dispLocationBox.TabIndex = 8;
            this.dispLocationBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Destination:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(-3, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 26);
            this.label8.TabIndex = 12;
            this.label8.Text = "Groups of three or more receive \r\n7.5% off their total booking!";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bookingSummaryGrpBox
            // 
            this.bookingSummaryGrpBox.BackColor = System.Drawing.Color.AliceBlue;
            this.bookingSummaryGrpBox.Controls.Add(this.summaryReturnBtn);
            this.bookingSummaryGrpBox.Controls.Add(this.avgBookingBox);
            this.bookingSummaryGrpBox.Controls.Add(this.label16);
            this.bookingSummaryGrpBox.Controls.Add(this.avgLunchBox);
            this.bookingSummaryGrpBox.Controls.Add(this.label15);
            this.bookingSummaryGrpBox.Controls.Add(this.totalHotelFeeBox);
            this.bookingSummaryGrpBox.Controls.Add(this.label14);
            this.bookingSummaryGrpBox.Controls.Add(this.totalTicketFeeBox);
            this.bookingSummaryGrpBox.Controls.Add(this.label13);
            this.bookingSummaryGrpBox.Controls.Add(this.totalRevenueBox);
            this.bookingSummaryGrpBox.Controls.Add(this.label12);
            this.bookingSummaryGrpBox.Controls.Add(this.totalBookingBox);
            this.bookingSummaryGrpBox.Controls.Add(this.label11);
            this.bookingSummaryGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingSummaryGrpBox.Location = new System.Drawing.Point(20, 171);
            this.bookingSummaryGrpBox.Name = "bookingSummaryGrpBox";
            this.bookingSummaryGrpBox.Size = new System.Drawing.Size(360, 308);
            this.bookingSummaryGrpBox.TabIndex = 13;
            this.bookingSummaryGrpBox.TabStop = false;
            this.bookingSummaryGrpBox.Text = "Booking Summary:";
            this.bookingSummaryGrpBox.Visible = false;
            // 
            // summaryReturnBtn
            // 
            this.summaryReturnBtn.BackColor = System.Drawing.Color.White;
            this.summaryReturnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryReturnBtn.Location = new System.Drawing.Point(274, 186);
            this.summaryReturnBtn.Name = "summaryReturnBtn";
            this.summaryReturnBtn.Size = new System.Drawing.Size(74, 31);
            this.summaryReturnBtn.TabIndex = 15;
            this.summaryReturnBtn.Text = "&Return";
            this.summaryReturnBtn.UseVisualStyleBackColor = false;
            this.summaryReturnBtn.Click += new System.EventHandler(this.summaryReturnBtn_Click);
            // 
            // avgBookingBox
            // 
            this.avgBookingBox.Enabled = false;
            this.avgBookingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgBookingBox.Location = new System.Drawing.Point(165, 166);
            this.avgBookingBox.Name = "avgBookingBox";
            this.avgBookingBox.Size = new System.Drawing.Size(100, 20);
            this.avgBookingBox.TabIndex = 27;
            this.avgBookingBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(57, 169);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Average Booking: ";
            // 
            // avgLunchBox
            // 
            this.avgLunchBox.Enabled = false;
            this.avgLunchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgLunchBox.Location = new System.Drawing.Point(165, 140);
            this.avgLunchBox.Name = "avgLunchBox";
            this.avgLunchBox.Size = new System.Drawing.Size(100, 20);
            this.avgLunchBox.TabIndex = 25;
            this.avgLunchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(57, 143);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Average Lunch Fee:";
            // 
            // totalHotelFeeBox
            // 
            this.totalHotelFeeBox.Enabled = false;
            this.totalHotelFeeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHotelFeeBox.Location = new System.Drawing.Point(165, 114);
            this.totalHotelFeeBox.Name = "totalHotelFeeBox";
            this.totalHotelFeeBox.Size = new System.Drawing.Size(100, 20);
            this.totalHotelFeeBox.TabIndex = 23;
            this.totalHotelFeeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(57, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Total Hotel Fees:";
            // 
            // totalTicketFeeBox
            // 
            this.totalTicketFeeBox.Enabled = false;
            this.totalTicketFeeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTicketFeeBox.Location = new System.Drawing.Point(165, 88);
            this.totalTicketFeeBox.Name = "totalTicketFeeBox";
            this.totalTicketFeeBox.Size = new System.Drawing.Size(100, 20);
            this.totalTicketFeeBox.TabIndex = 21;
            this.totalTicketFeeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(57, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Total Ticket Fees:";
            // 
            // totalRevenueBox
            // 
            this.totalRevenueBox.Enabled = false;
            this.totalRevenueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRevenueBox.Location = new System.Drawing.Point(165, 62);
            this.totalRevenueBox.Name = "totalRevenueBox";
            this.totalRevenueBox.Size = new System.Drawing.Size(100, 20);
            this.totalRevenueBox.TabIndex = 19;
            this.totalRevenueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(57, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Total Revenue:";
            // 
            // totalBookingBox
            // 
            this.totalBookingBox.Enabled = false;
            this.totalBookingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBookingBox.Location = new System.Drawing.Point(165, 36);
            this.totalBookingBox.Name = "totalBookingBox";
            this.totalBookingBox.Size = new System.Drawing.Size(100, 20);
            this.totalBookingBox.TabIndex = 17;
            this.totalBookingBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(57, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Total Bookings:";
            // 
            // ctrlGrpBox
            // 
            this.ctrlGrpBox.BackColor = System.Drawing.Color.AliceBlue;
            this.ctrlGrpBox.Controls.Add(this.displaySummaryBtn);
            this.ctrlGrpBox.Controls.Add(this.bookingSummaryBtn);
            this.ctrlGrpBox.Controls.Add(this.label8);
            this.ctrlGrpBox.Controls.Add(this.clearBtn);
            this.ctrlGrpBox.Controls.Add(this.exitBtn);
            this.ctrlGrpBox.Location = new System.Drawing.Point(200, 342);
            this.ctrlGrpBox.Name = "ctrlGrpBox";
            this.ctrlGrpBox.Size = new System.Drawing.Size(188, 130);
            this.ctrlGrpBox.TabIndex = 15;
            this.ctrlGrpBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(406, 485);
            this.Controls.Add(this.displaySummaryGrpBox);
            this.Controls.Add(this.hotelGrpBox);
            this.Controls.Add(this.ctrlGrpBox);
            this.Controls.Add(this.lunchGrpBox);
            this.Controls.Add(this.guestsGrpBox);
            this.Controls.Add(this.timeGrpBox);
            this.Controls.Add(this.locationGrpBox);
            this.Controls.Add(this.bookingSummaryGrpBox);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mild Atlantic Bus Tours";
            this.locationGrpBox.ResumeLayout(false);
            this.timeGrpBox.ResumeLayout(false);
            this.guestsGrpBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guestTextBox)).EndInit();
            this.lunchGrpBox.ResumeLayout(false);
            this.lunchGrpBox.PerformLayout();
            this.hotelGrpBox.ResumeLayout(false);
            this.hotelGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.displaySummaryGrpBox.ResumeLayout(false);
            this.displaySummaryGrpBox.PerformLayout();
            this.bookingSummaryGrpBox.ResumeLayout(false);
            this.bookingSummaryGrpBox.PerformLayout();
            this.ctrlGrpBox.ResumeLayout(false);
            this.ctrlGrpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox locationGrpBox;
        private System.Windows.Forms.GroupBox timeGrpBox;
        private System.Windows.Forms.ListBox locationListBox;
        private System.Windows.Forms.ListBox timeListBox;
        private System.Windows.Forms.GroupBox guestsGrpBox;
        private System.Windows.Forms.GroupBox lunchGrpBox;
        private System.Windows.Forms.GroupBox hotelGrpBox;
        private System.Windows.Forms.RadioButton threeStarRadio;
        private System.Windows.Forms.RadioButton fourStarRadio;
        private System.Windows.Forms.RadioButton fiveStarRadio;
        private System.Windows.Forms.Button displaySummaryBtn;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button bookingSummaryBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.CheckBox lunchCheckBox;
        private System.Windows.Forms.GroupBox displaySummaryGrpBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dispLocationBox;
        private System.Windows.Forms.TextBox dispTimeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dispGuestBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox grandTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown guestTextBox;
        private System.Windows.Forms.RadioButton noHotelRadio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ticketTotalBox;
        private System.Windows.Forms.TextBox lunchTotalBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hotelTotalBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox discountTotalBox;
        private System.Windows.Forms.TextBox grpDiscountBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox bookingSummaryGrpBox;
        private System.Windows.Forms.TextBox totalBookingBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox totalRevenueBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox totalTicketFeeBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox totalHotelFeeBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox avgBookingBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox avgLunchBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button summaryReturnBtn;
        private System.Windows.Forms.GroupBox ctrlGrpBox;
    }
}


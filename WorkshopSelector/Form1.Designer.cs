namespace WorkshopSelector
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            workshopListBox = new ListBox();
            locationListBox = new ListBox();
            WorkshopLabel = new Label();
            LocationLabel = new Label();
            displayDetails = new Label();
            showDetailsButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // workshopListBox
            // 
            workshopListBox.FormattingEnabled = true;
            workshopListBox.Items.AddRange(new object[] { "Handling Stress", "Time Management", "Supervision Skills", "Negotiation", "How to Interview" });
            workshopListBox.Location = new Point(39, 53);
            workshopListBox.Name = "workshopListBox";
            workshopListBox.Size = new Size(168, 104);
            workshopListBox.TabIndex = 0;
            // 
            // locationListBox
            // 
            locationListBox.FormattingEnabled = true;
            locationListBox.Items.AddRange(new object[] { "Austin", "Chicago", "Dallas", "Orlando", "Phoenix", "Raleigh" });
            locationListBox.Location = new Point(248, 53);
            locationListBox.Name = "locationListBox";
            locationListBox.Size = new Size(181, 104);
            locationListBox.TabIndex = 1;
            // 
            // WorkshopLabel
            // 
            WorkshopLabel.AutoSize = true;
            WorkshopLabel.Location = new Point(39, 30);
            WorkshopLabel.Name = "WorkshopLabel";
            WorkshopLabel.Size = new Size(134, 20);
            WorkshopLabel.TabIndex = 2;
            WorkshopLabel.Text = "Select a Workshop:";
            // 
            // LocationLabel
            // 
            LocationLabel.AutoSize = true;
            LocationLabel.Location = new Point(248, 30);
            LocationLabel.Name = "LocationLabel";
            LocationLabel.Size = new Size(125, 20);
            LocationLabel.TabIndex = 3;
            LocationLabel.Text = "Select a Location:";
            // 
            // displayDetails
            // 
            displayDetails.BorderStyle = BorderStyle.FixedSingle;
            displayDetails.Location = new Point(51, 183);
            displayDetails.Name = "displayDetails";
            displayDetails.Size = new Size(359, 73);
            displayDetails.TabIndex = 4;
            displayDetails.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // showDetailsButton
            // 
            showDetailsButton.Location = new Point(113, 278);
            showDetailsButton.Name = "showDetailsButton";
            showDetailsButton.Size = new Size(94, 55);
            showDetailsButton.TabIndex = 5;
            showDetailsButton.Text = "Show Details";
            showDetailsButton.UseVisualStyleBackColor = true;
            showDetailsButton.Click += showDetailsButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(248, 278);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 55);
            exitButton.TabIndex = 6;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 369);
            Controls.Add(exitButton);
            Controls.Add(showDetailsButton);
            Controls.Add(displayDetails);
            Controls.Add(LocationLabel);
            Controls.Add(WorkshopLabel);
            Controls.Add(locationListBox);
            Controls.Add(workshopListBox);
            Name = "Form1";
            Text = "Workshop Scheduler";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox workshopListBox;
        private ListBox locationListBox;
        private Label WorkshopLabel;
        private Label LocationLabel;
        private Label displayDetails;
        private Button showDetailsButton;
        private Button exitButton;
    }
}

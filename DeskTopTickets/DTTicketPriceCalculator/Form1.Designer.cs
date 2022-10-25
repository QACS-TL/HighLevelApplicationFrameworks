namespace DTTicketPriceCalculator
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
            this.moviesList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GetTicketButton = new System.Windows.Forms.Button();
            this.numOfAdultsNUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numOfChildrenNUD = new System.Windows.Forms.NumericUpDown();
            this.perfDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.ticketDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.ticketChoiceLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.filmNameLabel = new System.Windows.Forms.Label();
            this.perfTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numOfAdultsNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfChildrenNUD)).BeginInit();
            this.ticketDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // moviesList
            // 
            this.moviesList.FormattingEnabled = true;
            this.moviesList.ItemHeight = 15;
            this.moviesList.Location = new System.Drawing.Point(31, 38);
            this.moviesList.Name = "moviesList";
            this.moviesList.Size = new System.Drawing.Size(174, 409);
            this.moviesList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movies:";
            // 
            // GetTicketButton
            // 
            this.GetTicketButton.Location = new System.Drawing.Point(304, 273);
            this.GetTicketButton.Name = "GetTicketButton";
            this.GetTicketButton.Size = new System.Drawing.Size(75, 23);
            this.GetTicketButton.TabIndex = 2;
            this.GetTicketButton.Text = "Get Ticket";
            this.GetTicketButton.UseVisualStyleBackColor = true;
            this.GetTicketButton.Click += new System.EventHandler(this.GetTicketButton_Click);
            // 
            // numOfAdultsNUD
            // 
            this.numOfAdultsNUD.Location = new System.Drawing.Point(305, 38);
            this.numOfAdultsNUD.Name = "numOfAdultsNUD";
            this.numOfAdultsNUD.Size = new System.Drawing.Size(120, 23);
            this.numOfAdultsNUD.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Adults";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number of Children";
            // 
            // numOfChildrenNUD
            // 
            this.numOfChildrenNUD.Location = new System.Drawing.Point(305, 97);
            this.numOfChildrenNUD.Name = "numOfChildrenNUD";
            this.numOfChildrenNUD.Size = new System.Drawing.Size(120, 23);
            this.numOfChildrenNUD.TabIndex = 5;
            // 
            // perfDate
            // 
            this.perfDate.Location = new System.Drawing.Point(304, 167);
            this.perfDate.Name = "perfDate";
            this.perfDate.Size = new System.Drawing.Size(200, 23);
            this.perfDate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Select date of performance:";
            // 
            // ticketDetailsGroupBox
            // 
            this.ticketDetailsGroupBox.Controls.Add(this.totalCostLabel);
            this.ticketDetailsGroupBox.Controls.Add(this.ticketChoiceLabel);
            this.ticketDetailsGroupBox.Controls.Add(this.timeLabel);
            this.ticketDetailsGroupBox.Controls.Add(this.dateLabel);
            this.ticketDetailsGroupBox.Controls.Add(this.filmNameLabel);
            this.ticketDetailsGroupBox.Location = new System.Drawing.Point(305, 320);
            this.ticketDetailsGroupBox.Name = "ticketDetailsGroupBox";
            this.ticketDetailsGroupBox.Size = new System.Drawing.Size(305, 178);
            this.ticketDetailsGroupBox.TabIndex = 9;
            this.ticketDetailsGroupBox.TabStop = false;
            this.ticketDetailsGroupBox.Text = "Ticket Info";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(13, 133);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(83, 15);
            this.totalCostLabel.TabIndex = 4;
            this.totalCostLabel.Text = "totalCostLabel";
            // 
            // ticketChoiceLabel
            // 
            this.ticketChoiceLabel.AutoSize = true;
            this.ticketChoiceLabel.Location = new System.Drawing.Point(13, 104);
            this.ticketChoiceLabel.Name = "ticketChoiceLabel";
            this.ticketChoiceLabel.Size = new System.Drawing.Size(101, 15);
            this.ticketChoiceLabel.TabIndex = 3;
            this.ticketChoiceLabel.Text = "ticketChoiceLabel";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(13, 78);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(59, 15);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "timeLabel";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(13, 54);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(58, 15);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "dateLabel";
            // 
            // filmNameLabel
            // 
            this.filmNameLabel.AutoSize = true;
            this.filmNameLabel.Location = new System.Drawing.Point(13, 29);
            this.filmNameLabel.Name = "filmNameLabel";
            this.filmNameLabel.Size = new System.Drawing.Size(88, 15);
            this.filmNameLabel.TabIndex = 0;
            this.filmNameLabel.Text = "filmNameLabel";
            // 
            // perfTime
            // 
            this.perfTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.perfTime.Location = new System.Drawing.Point(304, 217);
            this.perfTime.Name = "perfTime";
            this.perfTime.Size = new System.Drawing.Size(200, 23);
            this.perfTime.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Select time of performance:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.perfTime);
            this.Controls.Add(this.ticketDetailsGroupBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.perfDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numOfChildrenNUD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numOfAdultsNUD);
            this.Controls.Add(this.GetTicketButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.moviesList);
            this.Name = "Form1";
            this.Text = "Ticket Price Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numOfAdultsNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfChildrenNUD)).EndInit();
            this.ticketDetailsGroupBox.ResumeLayout(false);
            this.ticketDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox moviesList;
        private Label label1;
        private Button GetTicketButton;
        private NumericUpDown numOfAdultsNUD;
        private Label label2;
        private Label label3;
        private NumericUpDown numOfChildrenNUD;
        private DateTimePicker perfDate;
        private Label label4;
        private GroupBox ticketDetailsGroupBox;
        private Label totalCostLabel;
        private Label ticketChoiceLabel;
        private Label timeLabel;
        private Label dateLabel;
        private Label filmNameLabel;
        private DateTimePicker perfTime;
        private Label label5;
    }
}
namespace HospitalCharges
{
    partial class HospitalCharges
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.daysSpentLabel = new System.Windows.Forms.Label();
            this.medChargesLabel = new System.Windows.Forms.Label();
            this.surgicalChargesLabel = new System.Windows.Forms.Label();
            this.labFeesLabel = new System.Windows.Forms.Label();
            this.rehabChargesLabel = new System.Windows.Forms.Label();
            this.daysSpentTextbox = new System.Windows.Forms.TextBox();
            this.medChargesTextbox = new System.Windows.Forms.TextBox();
            this.rehabChargesTextbox = new System.Windows.Forms.TextBox();
            this.surgChargesTextbox = new System.Windows.Forms.TextBox();
            this.labFeesTextbox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.billGroupBox = new System.Windows.Forms.GroupBox();
            this.stayChargesLabel = new System.Windows.Forms.Label();
            this.miscChargesLabel = new System.Windows.Forms.Label();
            this.totalChargesLabel = new System.Windows.Forms.Label();
            this.stayChargesOutputLabel = new System.Windows.Forms.Label();
            this.miscChargesOutputLabel = new System.Windows.Forms.Label();
            this.totalChargesOutputLabel = new System.Windows.Forms.Label();
            this.billGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(180, 9);
            this.instructionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(460, 19);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "This application will calculate the total cost of a hospital stay.";
            // 
            // daysSpentLabel
            // 
            this.daysSpentLabel.AutoSize = true;
            this.daysSpentLabel.Location = new System.Drawing.Point(80, 48);
            this.daysSpentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.daysSpentLabel.Name = "daysSpentLabel";
            this.daysSpentLabel.Size = new System.Drawing.Size(178, 19);
            this.daysSpentLabel.TabIndex = 1;
            this.daysSpentLabel.Text = "Days spent in hospital:";
            // 
            // medChargesLabel
            // 
            this.medChargesLabel.AutoSize = true;
            this.medChargesLabel.Location = new System.Drawing.Point(41, 87);
            this.medChargesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.medChargesLabel.Name = "medChargesLabel";
            this.medChargesLabel.Size = new System.Drawing.Size(220, 19);
            this.medChargesLabel.TabIndex = 2;
            this.medChargesLabel.Text = "Amount of Medical Charges:";
            // 
            // surgicalChargesLabel
            // 
            this.surgicalChargesLabel.AutoSize = true;
            this.surgicalChargesLabel.Location = new System.Drawing.Point(38, 126);
            this.surgicalChargesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surgicalChargesLabel.Name = "surgicalChargesLabel";
            this.surgicalChargesLabel.Size = new System.Drawing.Size(223, 19);
            this.surgicalChargesLabel.TabIndex = 3;
            this.surgicalChargesLabel.Text = "Amount of Surgical Charges:";
            // 
            // labFeesLabel
            // 
            this.labFeesLabel.AutoSize = true;
            this.labFeesLabel.Location = new System.Drawing.Point(94, 166);
            this.labFeesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labFeesLabel.Name = "labFeesLabel";
            this.labFeesLabel.Size = new System.Drawing.Size(166, 19);
            this.labFeesLabel.TabIndex = 4;
            this.labFeesLabel.Text = "Amount of Lab Fees:";
            // 
            // rehabChargesLabel
            // 
            this.rehabChargesLabel.AutoSize = true;
            this.rehabChargesLabel.Location = new System.Drawing.Point(49, 205);
            this.rehabChargesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rehabChargesLabel.Name = "rehabChargesLabel";
            this.rehabChargesLabel.Size = new System.Drawing.Size(212, 19);
            this.rehabChargesLabel.TabIndex = 5;
            this.rehabChargesLabel.Text = "Amount of Rehab Charges:";
            // 
            // daysSpentTextbox
            // 
            this.daysSpentTextbox.Location = new System.Drawing.Point(256, 47);
            this.daysSpentTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.daysSpentTextbox.Name = "daysSpentTextbox";
            this.daysSpentTextbox.Size = new System.Drawing.Size(112, 26);
            this.daysSpentTextbox.TabIndex = 6;
            // 
            // medChargesTextbox
            // 
            this.medChargesTextbox.Location = new System.Drawing.Point(256, 86);
            this.medChargesTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.medChargesTextbox.Name = "medChargesTextbox";
            this.medChargesTextbox.Size = new System.Drawing.Size(112, 26);
            this.medChargesTextbox.TabIndex = 7;
            // 
            // rehabChargesTextbox
            // 
            this.rehabChargesTextbox.Location = new System.Drawing.Point(256, 204);
            this.rehabChargesTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rehabChargesTextbox.Name = "rehabChargesTextbox";
            this.rehabChargesTextbox.Size = new System.Drawing.Size(112, 26);
            this.rehabChargesTextbox.TabIndex = 8;
            // 
            // surgChargesTextbox
            // 
            this.surgChargesTextbox.Location = new System.Drawing.Point(256, 125);
            this.surgChargesTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.surgChargesTextbox.Name = "surgChargesTextbox";
            this.surgChargesTextbox.Size = new System.Drawing.Size(112, 26);
            this.surgChargesTextbox.TabIndex = 9;
            // 
            // labFeesTextbox
            // 
            this.labFeesTextbox.Location = new System.Drawing.Point(256, 164);
            this.labFeesTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labFeesTextbox.Name = "labFeesTextbox";
            this.labFeesTextbox.Size = new System.Drawing.Size(112, 26);
            this.labFeesTextbox.TabIndex = 10;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(322, 256);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(85, 27);
            this.calculateButton.TabIndex = 11;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(428, 256);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(85, 27);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // billGroupBox
            // 
            this.billGroupBox.Controls.Add(this.totalChargesOutputLabel);
            this.billGroupBox.Controls.Add(this.miscChargesOutputLabel);
            this.billGroupBox.Controls.Add(this.stayChargesOutputLabel);
            this.billGroupBox.Controls.Add(this.totalChargesLabel);
            this.billGroupBox.Controls.Add(this.miscChargesLabel);
            this.billGroupBox.Controls.Add(this.stayChargesLabel);
            this.billGroupBox.Location = new System.Drawing.Point(398, 86);
            this.billGroupBox.Name = "billGroupBox";
            this.billGroupBox.Size = new System.Drawing.Size(313, 122);
            this.billGroupBox.TabIndex = 13;
            this.billGroupBox.TabStop = false;
            this.billGroupBox.Text = "Bill";
            // 
            // stayChargesLabel
            // 
            this.stayChargesLabel.AutoSize = true;
            this.stayChargesLabel.Location = new System.Drawing.Point(25, 22);
            this.stayChargesLabel.Name = "stayChargesLabel";
            this.stayChargesLabel.Size = new System.Drawing.Size(142, 19);
            this.stayChargesLabel.TabIndex = 0;
            this.stayChargesLabel.Text = "Charges for Stay:";
            // 
            // miscChargesLabel
            // 
            this.miscChargesLabel.AutoSize = true;
            this.miscChargesLabel.Location = new System.Drawing.Point(11, 57);
            this.miscChargesLabel.Name = "miscChargesLabel";
            this.miscChargesLabel.Size = new System.Drawing.Size(156, 19);
            this.miscChargesLabel.TabIndex = 1;
            this.miscChargesLabel.Text = "Total Misc Charges:";
            // 
            // totalChargesLabel
            // 
            this.totalChargesLabel.AutoSize = true;
            this.totalChargesLabel.Location = new System.Drawing.Point(48, 92);
            this.totalChargesLabel.Name = "totalChargesLabel";
            this.totalChargesLabel.Size = new System.Drawing.Size(119, 19);
            this.totalChargesLabel.TabIndex = 2;
            this.totalChargesLabel.Text = "Total Charges:";
            // 
            // stayChargesOutputLabel
            // 
            this.stayChargesOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stayChargesOutputLabel.Location = new System.Drawing.Point(173, 18);
            this.stayChargesOutputLabel.Name = "stayChargesOutputLabel";
            this.stayChargesOutputLabel.Size = new System.Drawing.Size(118, 26);
            this.stayChargesOutputLabel.TabIndex = 3;
            this.stayChargesOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // miscChargesOutputLabel
            // 
            this.miscChargesOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.miscChargesOutputLabel.Location = new System.Drawing.Point(173, 53);
            this.miscChargesOutputLabel.Name = "miscChargesOutputLabel";
            this.miscChargesOutputLabel.Size = new System.Drawing.Size(118, 26);
            this.miscChargesOutputLabel.TabIndex = 4;
            this.miscChargesOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalChargesOutputLabel
            // 
            this.totalChargesOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalChargesOutputLabel.Location = new System.Drawing.Point(173, 88);
            this.totalChargesOutputLabel.Name = "totalChargesOutputLabel";
            this.totalChargesOutputLabel.Size = new System.Drawing.Size(118, 26);
            this.totalChargesOutputLabel.TabIndex = 5;
            this.totalChargesOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HospitalCharges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(776, 296);
            this.Controls.Add(this.billGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.labFeesTextbox);
            this.Controls.Add(this.surgChargesTextbox);
            this.Controls.Add(this.rehabChargesTextbox);
            this.Controls.Add(this.medChargesTextbox);
            this.Controls.Add(this.daysSpentTextbox);
            this.Controls.Add(this.rehabChargesLabel);
            this.Controls.Add(this.labFeesLabel);
            this.Controls.Add(this.surgicalChargesLabel);
            this.Controls.Add(this.medChargesLabel);
            this.Controls.Add(this.daysSpentLabel);
            this.Controls.Add(this.instructionLabel);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HospitalCharges";
            this.Text = "Hospital Charges";
            this.billGroupBox.ResumeLayout(false);
            this.billGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label daysSpentLabel;
        private System.Windows.Forms.Label medChargesLabel;
        private System.Windows.Forms.Label surgicalChargesLabel;
        private System.Windows.Forms.Label labFeesLabel;
        private System.Windows.Forms.Label rehabChargesLabel;
        private System.Windows.Forms.TextBox daysSpentTextbox;
        private System.Windows.Forms.TextBox medChargesTextbox;
        private System.Windows.Forms.TextBox rehabChargesTextbox;
        private System.Windows.Forms.TextBox surgChargesTextbox;
        private System.Windows.Forms.TextBox labFeesTextbox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox billGroupBox;
        private System.Windows.Forms.Label stayChargesLabel;
        private System.Windows.Forms.Label totalChargesOutputLabel;
        private System.Windows.Forms.Label miscChargesOutputLabel;
        private System.Windows.Forms.Label stayChargesOutputLabel;
        private System.Windows.Forms.Label totalChargesLabel;
        private System.Windows.Forms.Label miscChargesLabel;
    }
}


namespace MegaDesk_Roberts
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.exitButton = new System.Windows.Forms.Button();
            this.customerNameInput = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.widthInputLabel = new System.Windows.Forms.Label();
            this.depthInputLabel = new System.Windows.Forms.Label();
            this.drawerInputLabel = new System.Windows.Forms.Label();
            this.numberDrawersInput = new System.Windows.Forms.NumericUpDown();
            this.materialInput = new System.Windows.Forms.ComboBox();
            this.materialInputLabel = new System.Windows.Forms.Label();
            this.rushInputLabel = new System.Windows.Forms.Label();
            this.rushDaysInput = new System.Windows.Forms.ComboBox();
            this.createQuoteButton = new System.Windows.Forms.Button();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.depthInput = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numberDrawersInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(12, 502);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(114, 55);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // customerNameInput
            // 
            this.customerNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.customerNameInput.Location = new System.Drawing.Point(17, 39);
            this.customerNameInput.Name = "customerNameInput";
            this.customerNameInput.Size = new System.Drawing.Size(188, 30);
            this.customerNameInput.TabIndex = 1;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.customerNameLabel.Location = new System.Drawing.Point(13, 9);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(161, 24);
            this.customerNameLabel.TabIndex = 2;
            this.customerNameLabel.Text = "Enter Your Name:";
            // 
            // widthInputLabel
            // 
            this.widthInputLabel.AutoSize = true;
            this.widthInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.widthInputLabel.Location = new System.Drawing.Point(12, 83);
            this.widthInputLabel.Name = "widthInputLabel";
            this.widthInputLabel.Size = new System.Drawing.Size(170, 25);
            this.widthInputLabel.TabIndex = 4;
            this.widthInputLabel.Text = "Enter Desk Width:";
            // 
            // depthInputLabel
            // 
            this.depthInputLabel.AutoSize = true;
            this.depthInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.depthInputLabel.Location = new System.Drawing.Point(12, 155);
            this.depthInputLabel.Name = "depthInputLabel";
            this.depthInputLabel.Size = new System.Drawing.Size(171, 25);
            this.depthInputLabel.TabIndex = 6;
            this.depthInputLabel.Text = "Enter Desk Depth:";
            // 
            // drawerInputLabel
            // 
            this.drawerInputLabel.AutoSize = true;
            this.drawerInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.drawerInputLabel.Location = new System.Drawing.Point(12, 233);
            this.drawerInputLabel.Name = "drawerInputLabel";
            this.drawerInputLabel.Size = new System.Drawing.Size(236, 25);
            this.drawerInputLabel.TabIndex = 8;
            this.drawerInputLabel.Text = "Enter Number of Drawers:";
            // 
            // numberDrawersInput
            // 
            this.numberDrawersInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.numberDrawersInput.Location = new System.Drawing.Point(17, 261);
            this.numberDrawersInput.Name = "numberDrawersInput";
            this.numberDrawersInput.Size = new System.Drawing.Size(99, 30);
            this.numberDrawersInput.TabIndex = 7;
            // 
            // materialInput
            // 
            this.materialInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.materialInput.FormattingEnabled = true;
            this.materialInput.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Venner"});
            this.materialInput.Location = new System.Drawing.Point(17, 333);
            this.materialInput.Name = "materialInput";
            this.materialInput.Size = new System.Drawing.Size(165, 33);
            this.materialInput.TabIndex = 9;
            this.materialInput.Text = "Select Material";
            // 
            // materialInputLabel
            // 
            this.materialInputLabel.AutoSize = true;
            this.materialInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.materialInputLabel.Location = new System.Drawing.Point(12, 305);
            this.materialInputLabel.Name = "materialInputLabel";
            this.materialInputLabel.Size = new System.Drawing.Size(224, 25);
            this.materialInputLabel.TabIndex = 10;
            this.materialInputLabel.Text = "Select Desktop Material:";
            // 
            // rushInputLabel
            // 
            this.rushInputLabel.AutoSize = true;
            this.rushInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rushInputLabel.Location = new System.Drawing.Point(12, 388);
            this.rushInputLabel.Name = "rushInputLabel";
            this.rushInputLabel.Size = new System.Drawing.Size(211, 25);
            this.rushInputLabel.TabIndex = 12;
            this.rushInputLabel.Text = "Select Delivery Speed:";
            // 
            // rushDaysInput
            // 
            this.rushDaysInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rushDaysInput.FormattingEnabled = true;
            this.rushDaysInput.Items.AddRange(new object[] {
            "3 Days",
            "5 Days",
            "7 Days",
            "No Rush (About 14 Days)"});
            this.rushDaysInput.Location = new System.Drawing.Point(17, 416);
            this.rushDaysInput.Name = "rushDaysInput";
            this.rushDaysInput.Size = new System.Drawing.Size(165, 33);
            this.rushDaysInput.TabIndex = 11;
            this.rushDaysInput.Text = "Select # of Days";
            // 
            // createQuoteButton
            // 
            this.createQuoteButton.Location = new System.Drawing.Point(211, 502);
            this.createQuoteButton.Name = "createQuoteButton";
            this.createQuoteButton.Size = new System.Drawing.Size(114, 55);
            this.createQuoteButton.TabIndex = 13;
            this.createQuoteButton.Text = "Create Quote";
            this.createQuoteButton.UseVisualStyleBackColor = true;
            this.createQuoteButton.Click += new System.EventHandler(this.createQuoteButton_Click);
            // 
            // widthInput
            // 
            this.widthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.widthInput.Location = new System.Drawing.Point(17, 111);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(188, 30);
            this.widthInput.TabIndex = 14;
            this.widthInput.Validating += new System.ComponentModel.CancelEventHandler(this.widthInput_Validating);
            // 
            // depthInput
            // 
            this.depthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.depthInput.Location = new System.Drawing.Point(17, 183);
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(188, 30);
            this.depthInput.TabIndex = 15;
            this.depthInput.Validating += new System.ComponentModel.CancelEventHandler(this.depthInput_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(337, 569);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.createQuoteButton);
            this.Controls.Add(this.rushInputLabel);
            this.Controls.Add(this.rushDaysInput);
            this.Controls.Add(this.materialInputLabel);
            this.Controls.Add(this.materialInput);
            this.Controls.Add(this.drawerInputLabel);
            this.Controls.Add(this.numberDrawersInput);
            this.Controls.Add(this.depthInputLabel);
            this.Controls.Add(this.widthInputLabel);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.customerNameInput);
            this.Controls.Add(this.exitButton);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            ((System.ComponentModel.ISupportInitialize)(this.numberDrawersInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox customerNameInput;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label widthInputLabel;
        private System.Windows.Forms.Label depthInputLabel;
        private System.Windows.Forms.Label drawerInputLabel;
        private System.Windows.Forms.NumericUpDown numberDrawersInput;
        private System.Windows.Forms.ComboBox materialInput;
        private System.Windows.Forms.Label materialInputLabel;
        private System.Windows.Forms.Label rushInputLabel;
        private System.Windows.Forms.ComboBox rushDaysInput;
        private System.Windows.Forms.Button createQuoteButton;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.TextBox depthInput;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
namespace MegaDesk_Roberts
{
    partial class DisplayQuote
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
        public void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.customerName = new System.Windows.Forms.Label();
            this.deskWidth = new System.Windows.Forms.Label();
            this.deskDepth = new System.Windows.Forms.Label();
            this.numDrawers = new System.Windows.Forms.Label();
            this.surfaceMaterial = new System.Windows.Forms.Label();
            this.rushDays = new System.Windows.Forms.Label();
            this.quoteDate = new System.Windows.Forms.Label();
            this.totalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(398, 407);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(114, 55);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.customerName.Location = new System.Drawing.Point(12, 9);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(64, 25);
            this.customerName.TabIndex = 4;
            this.customerName.Text = "label1";
            // 
            // deskWidth
            // 
            this.deskWidth.AutoSize = true;
            this.deskWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.deskWidth.Location = new System.Drawing.Point(12, 34);
            this.deskWidth.Name = "deskWidth";
            this.deskWidth.Size = new System.Drawing.Size(64, 25);
            this.deskWidth.TabIndex = 5;
            this.deskWidth.Text = "label2";
            // 
            // deskDepth
            // 
            this.deskDepth.AutoSize = true;
            this.deskDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.deskDepth.Location = new System.Drawing.Point(12, 60);
            this.deskDepth.Name = "deskDepth";
            this.deskDepth.Size = new System.Drawing.Size(64, 25);
            this.deskDepth.TabIndex = 6;
            this.deskDepth.Text = "label3";
            // 
            // numDrawers
            // 
            this.numDrawers.AutoSize = true;
            this.numDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.numDrawers.Location = new System.Drawing.Point(12, 84);
            this.numDrawers.Name = "numDrawers";
            this.numDrawers.Size = new System.Drawing.Size(64, 25);
            this.numDrawers.TabIndex = 7;
            this.numDrawers.Text = "label4";
            // 
            // surfaceMaterial
            // 
            this.surfaceMaterial.AutoSize = true;
            this.surfaceMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.surfaceMaterial.Location = new System.Drawing.Point(12, 109);
            this.surfaceMaterial.Name = "surfaceMaterial";
            this.surfaceMaterial.Size = new System.Drawing.Size(64, 25);
            this.surfaceMaterial.TabIndex = 8;
            this.surfaceMaterial.Text = "label5";
            // 
            // rushDays
            // 
            this.rushDays.AutoSize = true;
            this.rushDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rushDays.Location = new System.Drawing.Point(12, 134);
            this.rushDays.Name = "rushDays";
            this.rushDays.Size = new System.Drawing.Size(64, 25);
            this.rushDays.TabIndex = 9;
            this.rushDays.Text = "label6";
            // 
            // quoteDate
            // 
            this.quoteDate.AutoSize = true;
            this.quoteDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.quoteDate.Location = new System.Drawing.Point(12, 159);
            this.quoteDate.Name = "quoteDate";
            this.quoteDate.Size = new System.Drawing.Size(64, 25);
            this.quoteDate.TabIndex = 10;
            this.quoteDate.Text = "label7";
            // 
            // totalCost
            // 
            this.totalCost.AutoSize = true;
            this.totalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.totalCost.Location = new System.Drawing.Point(12, 184);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(64, 25);
            this.totalCost.TabIndex = 11;
            this.totalCost.Text = "label8";
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 474);
            this.Controls.Add(this.totalCost);
            this.Controls.Add(this.quoteDate);
            this.Controls.Add(this.rushDays);
            this.Controls.Add(this.surfaceMaterial);
            this.Controls.Add(this.numDrawers);
            this.Controls.Add(this.deskDepth);
            this.Controls.Add(this.deskWidth);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.exitButton);
            this.Name = "DisplayQuote";
            this.Text = "Display Quote";
            this.Activated += new System.EventHandler(this.DisplayQuote_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.Label deskWidth;
        private System.Windows.Forms.Label deskDepth;
        private System.Windows.Forms.Label numDrawers;
        private System.Windows.Forms.Label surfaceMaterial;
        private System.Windows.Forms.Label rushDays;
        private System.Windows.Forms.Label quoteDate;
        private System.Windows.Forms.Label totalCost;
    }
}
namespace MegaDesk_Roberts
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.addNewQuoteButton = new System.Windows.Forms.Button();
            this.viewQuotesButton = new System.Windows.Forms.Button();
            this.searchQuotesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.deskPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.deskPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewQuoteButton
            // 
            this.addNewQuoteButton.Location = new System.Drawing.Point(13, 13);
            this.addNewQuoteButton.Name = "addNewQuoteButton";
            this.addNewQuoteButton.Size = new System.Drawing.Size(168, 68);
            this.addNewQuoteButton.TabIndex = 0;
            this.addNewQuoteButton.Text = "Add New Quote";
            this.addNewQuoteButton.UseVisualStyleBackColor = true;
            this.addNewQuoteButton.Click += new System.EventHandler(this.addNewQuote_Click);
            // 
            // viewQuotesButton
            // 
            this.viewQuotesButton.Location = new System.Drawing.Point(13, 87);
            this.viewQuotesButton.Name = "viewQuotesButton";
            this.viewQuotesButton.Size = new System.Drawing.Size(168, 68);
            this.viewQuotesButton.TabIndex = 1;
            this.viewQuotesButton.Text = "View Quotes";
            this.viewQuotesButton.UseVisualStyleBackColor = true;
            this.viewQuotesButton.Click += new System.EventHandler(this.viewQuotes_Click);
            // 
            // searchQuotesButton
            // 
            this.searchQuotesButton.Location = new System.Drawing.Point(12, 161);
            this.searchQuotesButton.Name = "searchQuotesButton";
            this.searchQuotesButton.Size = new System.Drawing.Size(168, 68);
            this.searchQuotesButton.TabIndex = 2;
            this.searchQuotesButton.Text = "Search Quotes";
            this.searchQuotesButton.UseVisualStyleBackColor = true;
            this.searchQuotesButton.Click += new System.EventHandler(this.searchQuotes_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(13, 235);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(168, 68);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exit_Click);
            // 
            // deskPicture
            // 
            this.deskPicture.Image = ((System.Drawing.Image)(resources.GetObject("deskPicture.Image")));
            this.deskPicture.InitialImage = null;
            this.deskPicture.Location = new System.Drawing.Point(280, 56);
            this.deskPicture.Name = "deskPicture";
            this.deskPicture.Size = new System.Drawing.Size(298, 221);
            this.deskPicture.TabIndex = 4;
            this.deskPicture.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deskPicture);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.searchQuotesButton);
            this.Controls.Add(this.viewQuotesButton);
            this.Controls.Add(this.addNewQuoteButton);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.deskPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNewQuoteButton;
        private System.Windows.Forms.Button viewQuotesButton;
        private System.Windows.Forms.Button searchQuotesButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox deskPicture;
    }
}


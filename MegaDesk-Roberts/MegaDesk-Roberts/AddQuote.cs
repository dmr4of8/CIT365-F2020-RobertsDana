using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Roberts
{
    public partial class AddQuote : Form
    {
        private DeskQuote deskQuote { get; set; }
        public AddQuote()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void depthInput_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int x = Int32.Parse(depthInput.Text);
                errorProvider1.SetError(depthInput, "");
                if (x < 12 || x > 48)
                {
                    errorProvider1.SetError(depthInput, "Depth must be between 12 and 48");
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(depthInput, "Not an integer value.");
            }
        }

        private void widthInput_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int x = Int32.Parse(widthInput.Text);
                errorProvider1.SetError(widthInput, "");
                if (x < 24 || x > 96)
                {
                    errorProvider1.SetError(widthInput, "Width must be between 24 and 96");
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(widthInput, "Not an integer value.");
            }
        }

        
        private void createQuoteButton_Click(object sender, EventArgs e)
        {
            int width = Int32.Parse(widthInput.Text);
            int depth = Int32.Parse(depthInput.Text);
            int rushDays = 0;
            if (rushDaysInput.SelectedItem.ToString().Contains("3"))
            {
                rushDays = 3;
            }
            else if (rushDaysInput.SelectedItem.ToString().Contains("5"))
            {
                rushDays = 5;
            }
            else if (rushDaysInput.SelectedItem.ToString().Contains("7"))
            {
                rushDays = 7;
            }
            Desk tempDesk = new Desk(width, depth, (int)numberDrawersInput.Value, (string)materialInput.SelectedItem);
            deskQuote = new DeskQuote(tempDesk, rushDays, customerNameInput.Text, (string)materialInput.SelectedItem);
            DisplayQuote displayQuote = new DisplayQuote();
            displayQuote.deskQuote = deskQuote;
            MainMenu mainMenu = new MainMenu();
            displayQuote.Tag = mainMenu;
            displayQuote.Show(mainMenu);
            Hide();
        }
    }
}

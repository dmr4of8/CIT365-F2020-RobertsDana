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
    public partial class DisplayQuote : Form
    {
        public DeskQuote deskQuote { get; set; }
    public DisplayQuote()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void DisplayQuote_Activated(object sender, EventArgs e)
        {
            customerName.Text = "Name: " + deskQuote.CustomerName;
            deskWidth.Text = "Width: " + deskQuote.desk.Width;
            deskDepth.Text = "Depth: " + deskQuote.desk.Depth;
            numDrawers.Text = deskQuote.desk.NumDrawers + " Drawers";
            surfaceMaterial.Text = deskQuote.Material;
            rushDays.Text = "Days Rushed: " + deskQuote.RushDays;
            quoteDate.Text = deskQuote.date.ToString();
            totalCost.Text = "Cost: " + deskQuote.TotalCost;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Roberts
{
    public class DeskQuote
    {
        public Desk desk { get; set; }
        public int RushDays { get; set; }
        public string CustomerName { get; set; }
        public DateTime date { get; set; }
        public int TotalCost { get; set; }
        public string Material { get; set; }
        public DeskQuote(Desk tempDesk, int rushDays, string customerName, string material)
        {
            desk = tempDesk;
            RushDays = rushDays;
            CustomerName = customerName;
            date = DateTime.Today;
            TotalCost = getQuoteTotal();
            Material = material;
        }
        private int getQuoteTotal()
        {
            int surfaceArea = desk.Width * desk.Depth;
            int basePrice = 200;
            int rushCost = 0;
            int costDrawers = desk.NumDrawers * 50;
            int costSurface = desk.SurfaceCost;
            if (surfaceArea > 1000)
            {
                basePrice += surfaceArea - 1000;
            }
            if (RushDays == 3)
            {
                if (surfaceArea < 1000)
                {
                    rushCost = 60;
                } else if (surfaceArea >= 1000 && surfaceArea <= 2000 )
                {
                    rushCost = 70;
                } else
                {
                    rushCost = 80;
                }
            }
            if (RushDays == 5)
            {
                if (surfaceArea < 1000)
                {
                    rushCost = 40;
                }
                else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                {
                    rushCost = 50;
                }
                else
                {
                    rushCost = 60;
                }
            }
            if (RushDays == 7)
            {
                if (surfaceArea < 1000)
                {
                    rushCost = 30;
                }
                else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                {
                    rushCost = 35;
                }
                else
                {
                    rushCost = 40;
                }
            }
            int totalCost = basePrice + rushCost + costDrawers + costSurface;
            return totalCost;
        }

    }
}

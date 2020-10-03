using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Roberts
{
    enum DesktopMaterial
    {
        Oak = 200,
        Laminate = 100,
        Pine = 50,
        Rosewood = 300,
        Veneer = 125
    }
    public class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumDrawers { get; set; }
        public int SurfaceCost { get; set; }
        public const int maxWidth = 96;
        public const int minWidth = 24;
        public const int maxDepth = 48;
        public const int minDepth = 12;
        public Desk(int width, int depth, int numDrawers, string material)
        {
            Width = width;
            Depth = depth;
            NumDrawers = numDrawers;
            SurfaceCost = (int)Enum.Parse(typeof(DesktopMaterial), material);
        }
    }
}

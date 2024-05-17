using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace megaDesk
{
    internal class Desk
    {
        public enum Material
        {
            Pine,
            Laminate,
            Veneer,
            Oak,
            Rosewood
        };

        public static int MIN_DESK_W = 24;
        public static int MAX_DESK_W = 96;

        public int _width { get; }
        public int _depth { get; }
        public int _drawerCount { get; }
        public Material _material { get; }
        public int _size => _width * _depth;


        public Desk(int deskWidth, int deskDepth, int drawerCount, Material material) =>
            (_width, _depth, _drawerCount, _material) = (deskWidth, deskDepth, drawerCount, material);
    }
}
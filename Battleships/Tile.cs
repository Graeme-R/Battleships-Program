using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    public class Tile
    {
        public bool TileHit { get; set; }
        public string TileId { get; set; }

        public TileCodes TileCode { get; set; }
     }
}

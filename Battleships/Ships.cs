using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    public class Ships
    {
        public string ShipName { get; set; } 

        public List<Tile> ShipTiles { get; set; }

        public Ships(List<string> shipCoordinates) 
        {
            ShipTiles = new List<Tile>();

            foreach (string ship in shipCoordinates)
            {
                var tile = new Tile();

                tile.TileId = ship;
                tile.TileHit = false;
                tile.TileCode = TileCodes.ship;

                ShipTiles.Add(tile);
            }          
        }

    }
}

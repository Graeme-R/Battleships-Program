using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    public class PlayerShips
    {
        
        public List<Ships> Ships { get; set; }

        public bool isInShip(string coordinates)
        {
            foreach(var ship in Ships)
            {
                foreach (var tile in ship.ShipTiles)
                {
                    if(tile.TileId == coordinates)
                    {
                        tile.TileHit = true;
                        return true;
                    }

                }
            }
            return false;
        }

        public bool shipsNotHit()
        {
            foreach (var ship in Ships)
            {
                foreach (var tile in ship.ShipTiles)
                {
                    if (tile.TileHit == false)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}

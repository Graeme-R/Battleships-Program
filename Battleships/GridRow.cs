using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    public class GridRow
    { 
        
        public List<Tile> RowTiles { get; set; }


        public GridRow(string RowInitial, string Content)
        {
            RowTiles = new List<Tile>(); 



            // i is index

            // i is the current time in the loop

            // loop 10 times


            // int i = 1; Staring point of loop

            // i <= 10; condition to end loop 

            //i++  add 1 to i at end of each loop around
            for (int i = 1; i <= 10; i++) 
            {
                // creates new tile object
                var tile = new Tile();


                // tile id will be null 
                // single = we asign a value to a variable 
                tile.TileId = RowInitial + i;

                tile.TileCode = TileCodes.undiscovered;

                RowTiles.Add(tile);
            }

        }

       


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    internal class Grid
    {
      public List<GridRow> Rows { get; set; }


        public Grid()
        {
            Rows = new List<GridRow>();
            // ("Row initial","content") being deffined here 
            Rows.Add(new GridRow("A", "~"));
            Rows.Add(new GridRow("B", "?"));
            // Add new grid row object to the list of rows for grid
            Rows.Add(new GridRow("C", "#"));
            Rows.Add(new GridRow("D", "@"));
            Rows.Add(new GridRow("E", "&"));
            Rows.Add(new GridRow("F", "$"));
            Rows.Add(new GridRow("G", "£"));
            Rows.Add(new GridRow("H", "!"));
            Rows.Add(new GridRow("I", "%"));
            Rows.Add(new GridRow("J", "*"));
        }

        public void UpdateGrid(bool isShip, string TileId)
        {
            foreach (var row in Rows)
            {
                foreach (var tile in row.RowTiles)
                {
                    if(tile.TileId == TileId)
                    {
                        if (isShip)
                        {
                            tile.TileCode = TileCodes.ship;
                        }
                        else
                        {
                            tile.TileCode = TileCodes.water;
                        }
                    }
                }
            }
        }

        // dispalys grid to console 
        public void DisplayGrid()
        {

            foreach (GridRow row in Rows)
            {
                var displayoutput = string.Empty;

                string rowOutput = string.Empty;

                foreach (var tile in row.RowTiles)
                {
                    switch (tile.TileCode)
                    {
                        // if water _ 

                        case TileCodes.water:
                            rowOutput += "[_]";
                            break;

                        // undiscoved ~
                        case TileCodes.undiscovered:
                            rowOutput += "[~]";
                            break;

                        //if ship *
                        case TileCodes.ship:
                            rowOutput += "[*]";
                            break;

                        default:
                            // Error
                            rowOutput += "[!]";
                            break;
                    }
                }
                Console.WriteLine(rowOutput);  
                
                
                    

            }
        }

    }
}

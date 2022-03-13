using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    public class Program
    {
        static void Main(string[] args)
        {
            // make the grid object in memory 
            var grid = new Grid();

            var PlayerShips = new PlayerShips();

            PlayerShips.Ships = new List<Ships>
            {
                new Ships(new List<string> {"A1", "A2","A3"})

            };

            
            grid.DisplayGrid();

            // set initial value
            var shipsNotHit = true;

            while (shipsNotHit)
            {             
                var enteredValue = Console.ReadLine();

                if(enteredValue == "END")
                {
                    return;
                }

                var isShip = PlayerShips.isInShip(enteredValue);

                grid.UpdateGrid(isShip, enteredValue);

                Console.Clear();

                grid.DisplayGrid();


                // set value to the result (the returned value of the function ships not hit)
                shipsNotHit = PlayerShips.shipsNotHit();

            }

            return;

        }
    }
}
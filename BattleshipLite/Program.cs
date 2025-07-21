using BattleshipLiteLibrary;
using BattleshipLiteLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SOLID - Single Responsiblity Principle - S
            // every method should have 1 responsbility
            WelcomeMessage();

            PlayerInfoModel activePlayer = CreatePlayer("Player 1");
            PlayerInfoModel opponent = CreatePlayer("Player 2");
            PlayerInfoModel winner = null;

            //tuple - allows two or more type together

            do
            {
                // Display grid from active player on where they fired.
                DisplayShotGrid(activePlayer);


                // Ask active player for a shot
                // Determine if it is a valid shot
                // Determine shot results
                // Determine if the game is over
                // if over, set active player as winner,
                // else , swap position( active player -> opponent)
                 
            } while (winner == null);


            Console.ReadLine();
        }

        private static void DisplayShotGrid(PlayerInfoModel activePlayer)
        {


            foreach (var gridSpot in activePlayer.ShotGrid)
            {
                if (gridSpot.Status == GridSpotStatus.Empty)
                {
                    Console.Write($" {gridSpot.SpotLetter}{gridSpot.SpotNumber}");
                }
            }
        }

        private static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Battleship Lite");
            Console.WriteLine("Created by Earl Syx");
            Console.WriteLine();
        }

        //Addds as a dependency that the UI has
        private static PlayerInfoModel CreatePlayer(string playerTitle)
        {
            PlayerInfoModel output = new PlayerInfoModel();

            Console.WriteLine($"Player information for {playerTitle}");
            // Ask the user for their name
            output.UsersName = AskForUsersName();

            // Load up the shot grid
            GameLogic.InitializeGrid(output);

            // Ask the user for their 5 ship placement.
            PlaceShips(output);

            // Clear
            Console.Clear();

            return output;
        }

        private static string AskForUsersName()
        {
            Console.Write("What is your name: ");
            string output = Console.ReadLine();

            return output;
        }

        private static void PlaceShips(PlayerInfoModel model)
        {
            do
            {
                Console.Write($"Where do you want to place ship number {model.ShipLocation.Count + 1}: ");
                string location = Console.ReadLine();

                bool isValidLocation = GameLogic.PlaceShip(model, location);

                if (isValidLocation == false)
                {
                    Console.WriteLine("That was not a valid location. Please try again");
                }

            } while (model.ShipLocation.Count < 5);
        }
    }
}

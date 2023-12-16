using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Web;
using System.Runtime.CompilerServices;
// Niko Huber
// IGME 201
// Final Exam

namespace question6
{
    // Player Class
    public class Player
    {

        // Cannot be instanciated
        private Player()
        {

        }

        // instanciates one singular player object
        private static readonly Player player = new Player();

        // editable variables
        public string player_name;
        public int level;
        public int hp;
        public List<string> inventory;
        public string license_key;

        // gets player data from file.json
        public static Player GetPlayerData()
        {
            StreamReader reader = new StreamReader("file.json");

            string input = reader.ReadToEnd();
            reader.Close();

            Player inputPlayer = JsonConvert.DeserializeObject<Player>(input);

            Console.WriteLine("Setting Read...");

            return inputPlayer;
        }

        // writes data to file.json
        public void SavePlayerData(Player player)
        {
            StreamWriter writer = new StreamWriter("file.json");

            string output = JsonConvert.SerializeObject(player);

            writer.Write(output);

            writer.Close();

            Console.WriteLine("Settings Updated...");
        }
    }

    // main
    internal class Program
    {
        
        static void Main(string[] args)
        {
            // get data
            Player player = Player.GetPlayerData();

            // edit data
            // player.player_name = "eeee";

            // save data
            player.SavePlayerData(player);

        }
    }
}

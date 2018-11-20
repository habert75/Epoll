using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Epoll.Controllers
{
    public class PlayerController : Controller
    {
        // GET: Player
        public ActionResult Index()
        {
            var players = from p in getPlayerList()
                          orderby p.ID
                          select p;

            return View(players);
        }
        public ActionResult About()
        {

            return View();
        }


        // GET: Player/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Player/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                //Method to collect data from the form ,and to insert data into the list
                
                Models.Player player = new Models.Player();
                player.Name = collection["Name"];
                string age = collection["Age"];
                player.Age = Int32.Parse(age);
                player.Position = collection["Position"];
                player.Country = collection["Country"];
                player.Club = collection["Club"];
                string goals = collection["Goals"];
                player.Goals = Int32.Parse(goals);
                string trophies = collection["Trophies"];
                player.Trophies = Int32.Parse(trophies);
                playerList.Add(player);
                return RedirectToAction("Index");
                
            }
            catch
            {
                return View();
            }
        }
        //A list of  data to start with when application is launched
   public static List<Models.Player> playerList = new List<Models.Player>{
   new Models.Player{
                   ID=1,
                   Name="Messi",
                   Age=30,
                   Position="W",
                   Country="Argentine",
                   Club="Barcelona",
                   Goals=50,
                   Trophies=3
   },

   new Models.Player{
                   ID=2,
                   Name="Leo Messi",
                   Age=30,
                   Position="W",
                   Country="Argentine",
                   Club="Barcelona",
                   Goals=50,
                   Trophies=3
   },
      new Models.Player{
                   ID=3,
                   Name="Gimmy Gatete",
                   Age=37,
                   Position="F",
                   Country="Rwanda",
                   Club="APR FC",
                   Goals=40,
                   Trophies=3
   },
         new Models.Player{
                   ID=4,
                   Name="HABINSHUTI J Bertrand",
                   Age=24,
                   Position="D",
                   Country="Rwanda",
                   Club="Bohemia Podebrady ",
                   Goals=2,
                   Trophies=0
   }

        };
        public List<Models.Player> getPlayerList()
        {
            return playerList;
        }
    }
}

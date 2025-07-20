using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLiteLibrary.Models
{
    public class PlayerInfoModel
    {
        public string UsersName { get; set; }

        public List<GridSpotModel> ShipLocation = new List<GridSpotModel>();

        public List<GridSpotModel> ShotGrid = new List<GridSpotModel>();

    }
}

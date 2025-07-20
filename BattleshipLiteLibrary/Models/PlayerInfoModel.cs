using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLiteLibrary.Models
{
    public class PlayerInfoModel
    {
        public string Name { get; set; }
        public List<GridSpotModel> location = new List<GridSpotModel>();
        public List<GridSpotModel> shotgrid = new List<GridSpotModel>();

    }
}

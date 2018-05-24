using System;
using System.Collections.Generic;
using System.Text;

namespace MusicAppFinal.Models
{
    public enum MenuType
    {
        Browse,
        About,
        Blog,
        Videos
    }
    public class HomeMenuItem : BaseModel
    {
        public HomeMenuItem()
        {
            MenuType = MenuType.Browse;
        }
        public string Icon { get; set; }
        public MenuType MenuType { get; set; }
    }
}

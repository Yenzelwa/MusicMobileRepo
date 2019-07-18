using System;
using System.Collections.Generic;
using System.Text;

namespace MusicAppFinal.Models
{
     public  class ApiLibrary
    {

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CoverFilePath { get; set; }
        public decimal? Price { get; set; }
        public string Type { get; set; }
        public string Artist { get; set; }
        public DateTime DateCreated { get; set; }
    }
}

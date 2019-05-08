using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAppFinalBLL.Models
{
   public  class LibraryModel
    {

        public long Id { get; set; }
        public string Name { get; set; }
        public string CoverFilePath { get; set; }
        public decimal? Price { get; set; }
        public string Type { get; set; }
        public string Artist { get; set; }
        public DateTime DateCreated { get; set; }
    }
}

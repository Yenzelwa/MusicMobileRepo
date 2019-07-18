using System;
using System.Collections.Generic;
using System.Text;

namespace MusicAppFinal.Models
{
   public class LibraryResponse
    {
        public List<ApiLibrary> ResponseObject { set; get; }
        public int ResponseType { set; get; }

        public string ResponseMessage { set; get; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_API.API.Models
{
    public class Posts
    {
        public long page { get; set; }
        public long per_page { get; set; }
        public long total { get; set; }
        public long total_pages { get; set; }
        //public List<Datum> Data { get; set; }
        //public Support Support { get; set; }
    }
}

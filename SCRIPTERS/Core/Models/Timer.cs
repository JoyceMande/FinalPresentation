using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCRIPTERS.Core.Models
{
    public class Timer
    {
        public int Id { set; get; }
        public DateTime Hours { set; get; }
        public DateTime Minutes { set; get; }
        public DateTime Seconds { set; get; }
    }
}
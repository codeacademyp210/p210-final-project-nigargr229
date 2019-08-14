using Area.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Area.ViewModel
{
    public class CreateE
    {
        public Employee Employee { get; set; }
        public List<Position> Positions { get; set; }
        public string Action { get; set; }

    }
}
using Area.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Area.ViewModel
{
    public class CreateVM
    {
        public Student Student { get; set; }
        public List<Group> Groups { get; set; }

        public string Action { get; set; }
    }
}
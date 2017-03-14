using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace home.Models
{
    public class Result
    {
            public int id { get; set; }
            public string name { get; set; }
            public string emails { get; set; }
        }

        public class RootObject
        {
            public List<Result> result { get; set; }
        }
    }

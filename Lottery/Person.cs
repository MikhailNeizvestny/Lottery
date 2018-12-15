using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lottery
{
    public class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool winner { get; set; }

        public Person(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    class Diller
    {
        public string Name { get; set; }

        public Diller()
        {
            this.Name = "Diller OLEG =)";
        }
        public override string ToString()
        {
            return $"Name = {Name}";
        }
    }
}
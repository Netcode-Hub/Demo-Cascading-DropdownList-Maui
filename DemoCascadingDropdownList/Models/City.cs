﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCascadingDropdownList.Models
{
    public class City
    {
        public int Id { get; set; }
        public int CountryId  { get; set; }
        public string Name { get; set; }
    }
}

﻿using PracticeSFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeSFWeb.Models
{
    public class SimchosVM
    {
        public List<Simcha> Simchos { get; set; }
        public List<Contribution> Contributions { get; set; }
        public List<Contributor> Contributors { get; set; }

    }
}

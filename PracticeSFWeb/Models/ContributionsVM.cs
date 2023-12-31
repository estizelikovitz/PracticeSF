﻿using PracticeSFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeSFWeb.Models
{
    public class ContributionsVM
    {
        public List<Contributor> Contributors { get; set; }
        public List<Deposit> Deposits { get; set; }
        public List<Contribution> Contributions { get; set; }
        public List<Simcha> Simchos { get; set; }
        public int Id { get; set; }
    }
}

﻿using FestaLive.Core.Entities.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestaLive.Core.Entities.Concrete
{
    public class OperationClaim : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

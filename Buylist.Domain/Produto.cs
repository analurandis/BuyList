﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buylist.Domain
{
    public class Produto : Base
    {
        public string? Nome {get;set;}   
        public string? CodigoBarras {get;set;}
        public string? Descricao { get; set; }
    }
}

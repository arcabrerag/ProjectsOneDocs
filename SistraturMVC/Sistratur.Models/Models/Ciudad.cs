﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistratur.Models.Models
{
    public class Ciudad
    {
        public int Id { get; set; }
        public String Descripcion { get; set; }

        public virtual ICollection<Proveedor> Proveedor { get; set; }
    }
}
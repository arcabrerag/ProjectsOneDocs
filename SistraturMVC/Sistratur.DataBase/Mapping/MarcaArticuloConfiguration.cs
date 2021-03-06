﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.Entity.ModelConfiguration;

using Sistratur.Models.Models;

namespace Sistratur.DataBase.Mapping
{
    class MarcaArticuloConfiguration : EntityTypeConfiguration<MarcaArticulo>
    {
        public MarcaArticuloConfiguration()
        {

            ToTable("MarcaArticulo", "dbo");
            HasKey(o => o.Id);
            Property(o => o.Descripcion)
                .HasMaxLength(50)
                .IsRequired();
            Property(o => o.Observaciones)
                .HasMaxLength(200);

        }
    }
}
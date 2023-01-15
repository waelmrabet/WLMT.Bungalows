﻿using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class CommercialConfiguration : IEntityTypeConfiguration<Commercial>
    {
        public void Configure(EntityTypeBuilder<Commercial> builder)
        {
            builder.ToTable("Commercials");
        }
    }
}

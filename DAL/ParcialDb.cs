﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ParcialDb : DbContext
    {
        public ParcialDb():base("ConStr")
        {

        }
        public DbSet<Prestamos> Prestamos { get; set; }

    }
}

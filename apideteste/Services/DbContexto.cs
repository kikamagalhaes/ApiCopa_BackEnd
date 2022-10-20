﻿using apicopa.models;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace apicopa.Services
{
    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions<DbContexto> options) : base(options) { }


        public DbContexto() { }


        public DbSet<Admin> Admin { get; set; }
        public DbSet<FaseCopa> FaseCopa { get; set; }
        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<Selecao> Selecao { get; set; }

    }
}

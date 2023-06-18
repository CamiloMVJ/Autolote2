﻿using Autolote.Models;
using Microsoft.EntityFrameworkCore;

namespace Autolote.Data
{
    public class AutoloteContext : DbContext
    {
        public AutoloteContext(DbContextOptions<AutoloteContext> options) : base(options){ }

        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<RegistroVenta> RegistrosVentas { get; set; }

    }
}
